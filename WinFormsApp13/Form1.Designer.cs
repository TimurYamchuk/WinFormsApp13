namespace WinFormsApp13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            fileToolStripMenuItem2 = new ToolStripMenuItem();
            openToolStripMenuItem2 = new ToolStripMenuItem();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            addAuthorToolStripMenuItem = new ToolStripMenuItem();
            deleteAuthorToolStripMenuItem = new ToolStripMenuItem();
            editAuthorToolStripMenuItem = new ToolStripMenuItem();
            addBookToolStripMenuItem = new ToolStripMenuItem();
            deleteBookToolStripMenuItem = new ToolStripMenuItem();
            editBookToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, fileToolStripMenuItem1, fileToolStripMenuItem2, optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(519, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(14, 24);
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(14, 24);
            // 
            // fileToolStripMenuItem2
            // 
            fileToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem2, saveToolStripMenuItem1, exitToolStripMenuItem1 });
            fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            fileToolStripMenuItem2.Size = new Size(59, 24);
            fileToolStripMenuItem2.Text = "File";
            // 
            // openToolStripMenuItem2
            // 
            openToolStripMenuItem2.Name = "openToolStripMenuItem2";
            openToolStripMenuItem2.Size = new Size(224, 26);
            openToolStripMenuItem2.Text = "Open";
            openToolStripMenuItem2.Click += LoadFromFileMenuItem_Click;
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.Size = new Size(224, 26);
            saveToolStripMenuItem1.Text = "Save";
            saveToolStripMenuItem1.Click += SaveToFileMenuItem_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(224, 26);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += ExitMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addAuthorToolStripMenuItem, deleteAuthorToolStripMenuItem, editAuthorToolStripMenuItem, addBookToolStripMenuItem, deleteBookToolStripMenuItem, editBookToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(70, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // addAuthorToolStripMenuItem
            // 
            addAuthorToolStripMenuItem.Name = "addAuthorToolStripMenuItem";
            addAuthorToolStripMenuItem.Size = new Size(246, 26);
            addAuthorToolStripMenuItem.Text = "Add Author";
            addAuthorToolStripMenuItem.Click += AddAuthorMenuItem_Click;
            // 
            // deleteAuthorToolStripMenuItem
            // 
            deleteAuthorToolStripMenuItem.Name = "deleteAuthorToolStripMenuItem";
            deleteAuthorToolStripMenuItem.Size = new Size(246, 26);
            deleteAuthorToolStripMenuItem.Text = "Delete Author";
            deleteAuthorToolStripMenuItem.Click += RemoveAuthorMenuItem_Click;
            // 
            // editAuthorToolStripMenuItem
            // 
            editAuthorToolStripMenuItem.Name = "editAuthorToolStripMenuItem";
            editAuthorToolStripMenuItem.Size = new Size(246, 26);
            editAuthorToolStripMenuItem.Text = "Edit Author";
            editAuthorToolStripMenuItem.Click += EditAuthorMenuItem_Click;
            // 
            // addBookToolStripMenuItem
            // 
            addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            addBookToolStripMenuItem.Size = new Size(246, 26);
            addBookToolStripMenuItem.Text = "Add Book";
            addBookToolStripMenuItem.Click += AddBookMenuItem_Click;
            // 
            // deleteBookToolStripMenuItem
            // 
            deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            deleteBookToolStripMenuItem.Size = new Size(246, 26);
            deleteBookToolStripMenuItem.Text = "Delete Book";
            deleteBookToolStripMenuItem.Click += RemoveBookMenuItem_Click;
            // 
            // editBookToolStripMenuItem
            // 
            editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            editBookToolStripMenuItem.Size = new Size(246, 26);
            editBookToolStripMenuItem.Text = "Edit Book";
            editBookToolStripMenuItem.Click += EditBookMenuItem_Click;
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.Size = new Size(224, 26);
            openToolStripMenuItem1.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(224, 26);
            saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(28, 90);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(467, 164);
            listBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(28, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(467, 28);
            comboBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(204, 271);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(116, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Filter";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 303);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Authors and Books";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem addAuthorToolStripMenuItem;
        private ToolStripMenuItem deleteAuthorToolStripMenuItem;
        private ToolStripMenuItem editAuthorToolStripMenuItem;
        private ToolStripMenuItem addBookToolStripMenuItem;
        private ToolStripMenuItem deleteBookToolStripMenuItem;
        private ToolStripMenuItem editBookToolStripMenuItem;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private ToolStripMenuItem fileToolStripMenuItem2;
        private ToolStripMenuItem openToolStripMenuItem2;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
    }
}
