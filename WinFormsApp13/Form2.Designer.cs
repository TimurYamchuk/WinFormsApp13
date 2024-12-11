using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp13
{
    partial class Form2
    {
        /// <summary>
        /// Обязательная переменная для компонентов дизайнера.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистка ресурсов, которые используются.
        /// </summary>
        /// <param name="disposing">True, если управляемые ресурсы должны быть освобождены; в противном случае — false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Генерируемый код для формы

        /// <summary>
        /// Метод для поддержки дизайнера формы. Не изменяйте содержимое этого метода.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 30);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 0;
            label1.Text = "Пожалуйста, введите имя автора:";

            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 27);
            textBox1.TabIndex = 1;

            // 
            // button1
            // 
            button1.Location = new Point(15, 100);
            button1.Name = "button1";
            button1.Size = new Size(95, 30);
            button1.TabIndex = 2;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;

            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 150);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Добавить или изменить автора";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}
