namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        private List<Author> authors = new List<Author>();

        public Form1()
        {
            InitializeComponent();
            AddSampleAuthorsAndBooks();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
        }

        private void AddSampleAuthorsAndBooks()
        {
            // Инициализация авторов и книг
            Author author1 = new Author { Name = "Лев Толстой" };
            author1.Books.Add(new Book { Title = "Война и мир", Author = author1 });
            author1.Books.Add(new Book { Title = "Анна Каренина", Author = author1 });

            Author author2 = new Author { Name = "Фёдор Достоевский" };
            author2.Books.Add(new Book { Title = "Преступление и наказание", Author = author2 });
            author2.Books.Add(new Book { Title = "Братья Карамазовы", Author = author2 });

            Author author3 = new Author { Name = "Александр Пушкин" };
            author3.Books.Add(new Book { Title = "Евгений Онегин", Author = author3 });
            author3.Books.Add(new Book { Title = "Руслан и Людмила", Author = author3 });

            Author author4 = new Author { Name = "Антон Чехов" };
            author4.Books.Add(new Book { Title = "Вишнёвый сад", Author = author4 });
            author4.Books.Add(new Book { Title = "Человек в футляре", Author = author4 });

            authors.Add(author1);
            authors.Add(author2);
            authors.Add(author3);
            authors.Add(author4);

            // Добавляем авторов в ComboBox
            foreach (var author in authors)
            {
                comboBox1.Items.Add(author);
            }

            // Выбираем первого автора по умолчанию
            comboBox1.SelectedItem = author1;

            UpdateBooksList();
        }

        private void AddAuthorMenuItem_Click(object sender, EventArgs e)
        {
            Author newAuthor = new Author();

            using (Form2 form2 = new Form2(newAuthor, true))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(newAuthor.Name))
                    {
                        MessageBox.Show("Имя автора не может быть пустым.");
                        return;
                    }

                    authors.Add(newAuthor);
                    comboBox1.Items.Add(newAuthor);
                    comboBox1.SelectedItem = newAuthor;
                    MessageBox.Show($"Автор {newAuthor.Name} добавлен.");
                }
            }

            UpdateBooksList();
        }

        private void AddBookMenuItem_Click(object sender, EventArgs e)
        {
            Author selectedAuthor = comboBox1.SelectedItem as Author;
            if (selectedAuthor == null)
            {
                MessageBox.Show("Выберите автора перед добавлением книги.");
                return;
            }

            Book newBook = new Book();

            using (Form3 form3 = new Form3(newBook, authors, true))
            {
                if (form3.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(newBook.Title))
                    {
                        MessageBox.Show("Название книги не может быть пустым.");
                        return;
                    }

                    selectedAuthor.Books.Add(newBook);
                    newBook.Author = selectedAuthor;

                    MessageBox.Show($"Книга \"{newBook.Title}\" добавлена автору {selectedAuthor.Name}.");
                    UpdateBooksList();
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBooksList();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBooksList();
        }

        private void UpdateBooksList()
        {
            listBox1.Items.Clear();

            if (checkBox1.Checked)
            {
                if (comboBox1.SelectedItem is Author selectedAuthor)
                {
                    foreach (var book in selectedAuthor.Books)
                    {
                        listBox1.Items.Add($"{book.Title} (Автор: {selectedAuthor.Name})");
                    }
                }
            }
            else
            {
                foreach (var author in authors)
                {
                    foreach (var book in author.Books)
                    {
                        listBox1.Items.Add($"{book.Title} (Автор: {author.Name})");
                    }
                }
            }
        }

        private void RemoveAuthorMenuItem_Click(object sender, EventArgs e)
        {
            Author selectedAuthor = comboBox1.SelectedItem as Author;
            if (selectedAuthor == null)
            {
                MessageBox.Show("Выберите автора, которого хотите удалить.");
                return;
            }

            var result = MessageBox.Show(
                $"Действительно ли вы хотите удалить автора \"{selectedAuthor.Name}\" и все его книги?",
                "Удаление автора",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                authors.Remove(selectedAuthor);
                comboBox1.Items.Remove(selectedAuthor);

                UpdateBooksList();
            }
        }

        private void EditAuthorMenuItem_Click(object sender, EventArgs e)
        {
            Author selectedAuthor = comboBox1.SelectedItem as Author;
            if (selectedAuthor == null)
            {
                MessageBox.Show("Выберите автора, которого хотите редактировать.");
                return;
            }

            using (Form2 form2 = new Form2(selectedAuthor, false))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(selectedAuthor.Name))
                    {
                        MessageBox.Show("Имя автора не может быть пустым.");
                        return;
                    }

                    comboBox1.Items[comboBox1.SelectedIndex] = selectedAuthor;
                    UpdateBooksList();

                    MessageBox.Show($"Автор \"{selectedAuthor.Name}\" успешно отредактирован.");
                }
            }
        }

        private void EditBookMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is string selectedBookInfo &&
                comboBox1.SelectedItem is Author selectedAuthor)
            {
                Book selectedBook = selectedAuthor.Books.FirstOrDefault(book =>
                    selectedBookInfo.StartsWith(book.Title));

                if (selectedBook != null)
                {
                    using (Form3 form3 = new Form3(selectedBook, authors, false))
                    {
                        if (form3.ShowDialog() == DialogResult.OK)
                        {
                            UpdateBooksList();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите книгу, которую хотите редактировать.");
            }
        }

        private void RemoveBookMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is string selectedBookInfo &&
                comboBox1.SelectedItem is Author selectedAuthor)
            {
                Book selectedBook = selectedAuthor.Books.FirstOrDefault(book =>
                    selectedBookInfo.StartsWith(book.Title));

                if (selectedBook != null)
                {
                    var result = MessageBox.Show(
                        $"Действительно ли вы хотите удалить книгу \"{selectedBook.Title}\"?",
                        "Удаление книги",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        selectedAuthor.Books.Remove(selectedBook);
                        UpdateBooksList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите книгу, которую хотите удалить.");
            }
        }

        private void SaveToFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Сохранить данные в файл"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (var author in authors)
                        {
                            writer.WriteLine($"Author:{author.Name}");

                            foreach (var book in author.Books)
                            {
                                writer.WriteLine($"Book:{book.Title}");
                            }
                        }
                    }

                    MessageBox.Show("Данные успешно сохранены в файл.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
                }
            }
        }

        private void LoadFromFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Открыть файл"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        authors.Clear();
                        comboBox1.Items.Clear();

                        string line;
                        Author currentAuthor = null;

                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.StartsWith("Author:"))
                            {
                                string authorName = line.Substring(7).Trim();
                                currentAuthor = new Author { Name = authorName };
                                authors.Add(currentAuthor);
                                comboBox1.Items.Add(currentAuthor);
                            }
                            else if (line.StartsWith("Book:") && currentAuthor != null)
                            {
                                string bookTitle = line.Substring(5).Trim();
                                Book newBook = new Book { Title = bookTitle, Author = currentAuthor };
                                currentAuthor.Books.Add(newBook);
                            }
                        }
                    }

                    MessageBox.Show("Данные успешно загружены из файла.");
                    UpdateBooksList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке: {ex.Message}");
                }
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
