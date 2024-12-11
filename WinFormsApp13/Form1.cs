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
            // ������������� ������� � ����
            Author author1 = new Author { Name = "��� �������" };
            author1.Books.Add(new Book { Title = "����� � ���", Author = author1 });
            author1.Books.Add(new Book { Title = "���� ��������", Author = author1 });

            Author author2 = new Author { Name = "Ը��� �����������" };
            author2.Books.Add(new Book { Title = "������������ � ���������", Author = author2 });
            author2.Books.Add(new Book { Title = "������ ����������", Author = author2 });

            Author author3 = new Author { Name = "��������� ������" };
            author3.Books.Add(new Book { Title = "������� ������", Author = author3 });
            author3.Books.Add(new Book { Title = "������ � �������", Author = author3 });

            Author author4 = new Author { Name = "����� �����" };
            author4.Books.Add(new Book { Title = "������� ���", Author = author4 });
            author4.Books.Add(new Book { Title = "������� � �������", Author = author4 });

            authors.Add(author1);
            authors.Add(author2);
            authors.Add(author3);
            authors.Add(author4);

            // ��������� ������� � ComboBox
            foreach (var author in authors)
            {
                comboBox1.Items.Add(author);
            }

            // �������� ������� ������ �� ���������
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
                        MessageBox.Show("��� ������ �� ����� ���� ������.");
                        return;
                    }

                    authors.Add(newAuthor);
                    comboBox1.Items.Add(newAuthor);
                    comboBox1.SelectedItem = newAuthor;
                    MessageBox.Show($"����� {newAuthor.Name} ��������.");
                }
            }

            UpdateBooksList();
        }

        private void AddBookMenuItem_Click(object sender, EventArgs e)
        {
            Author selectedAuthor = comboBox1.SelectedItem as Author;
            if (selectedAuthor == null)
            {
                MessageBox.Show("�������� ������ ����� ����������� �����.");
                return;
            }

            Book newBook = new Book();

            using (Form3 form3 = new Form3(newBook, authors, true))
            {
                if (form3.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(newBook.Title))
                    {
                        MessageBox.Show("�������� ����� �� ����� ���� ������.");
                        return;
                    }

                    selectedAuthor.Books.Add(newBook);
                    newBook.Author = selectedAuthor;

                    MessageBox.Show($"����� \"{newBook.Title}\" ��������� ������ {selectedAuthor.Name}.");
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
                        listBox1.Items.Add($"{book.Title} (�����: {selectedAuthor.Name})");
                    }
                }
            }
            else
            {
                foreach (var author in authors)
                {
                    foreach (var book in author.Books)
                    {
                        listBox1.Items.Add($"{book.Title} (�����: {author.Name})");
                    }
                }
            }
        }

        private void RemoveAuthorMenuItem_Click(object sender, EventArgs e)
        {
            Author selectedAuthor = comboBox1.SelectedItem as Author;
            if (selectedAuthor == null)
            {
                MessageBox.Show("�������� ������, �������� ������ �������.");
                return;
            }

            var result = MessageBox.Show(
                $"������������� �� �� ������ ������� ������ \"{selectedAuthor.Name}\" � ��� ��� �����?",
                "�������� ������",
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
                MessageBox.Show("�������� ������, �������� ������ �������������.");
                return;
            }

            using (Form2 form2 = new Form2(selectedAuthor, false))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(selectedAuthor.Name))
                    {
                        MessageBox.Show("��� ������ �� ����� ���� ������.");
                        return;
                    }

                    comboBox1.Items[comboBox1.SelectedIndex] = selectedAuthor;
                    UpdateBooksList();

                    MessageBox.Show($"����� \"{selectedAuthor.Name}\" ������� ��������������.");
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
                MessageBox.Show("�������� �����, ������� ������ �������������.");
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
                        $"������������� �� �� ������ ������� ����� \"{selectedBook.Title}\"?",
                        "�������� �����",
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
                MessageBox.Show("�������� �����, ������� ������ �������.");
            }
        }

        private void SaveToFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "��������� ������ � ����"
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

                    MessageBox.Show("������ ������� ��������� � ����.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������ ��� ����������: {ex.Message}");
                }
            }
        }

        private void LoadFromFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "������� ����"
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

                    MessageBox.Show("������ ������� ��������� �� �����.");
                    UpdateBooksList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������ ��� ��������: {ex.Message}");
                }
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
