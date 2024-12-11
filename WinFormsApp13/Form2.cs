using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp13
{
    public partial class Form2 : Form
    {
        private Author author;
        private bool isAddMode;

        public Form2(Author author, bool isAddMode)
        {
            InitializeComponent();
            this.author = author;
            this.isAddMode = isAddMode;

            FormBorderStyle = FormBorderStyle.FixedDialog;
            Text = isAddMode ? "Добавить автора" : "Редактировать автора";

            if (!isAddMode)
            {
                textBox1.Text = author.Name;
            }

            button1.Click += SaveButton_Click;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Имя автора не может быть пустым.");
                return;
            }

            author.Name = textBox1.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
