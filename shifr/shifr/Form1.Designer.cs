﻿
namespace shifr
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(311, 319);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(334, 22);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 718);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вариант 10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(912, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Шокина А.Н.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Исходное сообщение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Перестановка:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Размер открытого текста:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(206, 252);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 22);
            this.textBox3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Размер блока:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(470, 256);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(52, 22);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(444, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Необходимо дополнить открытый текст пробелами в количестве:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(479, 285);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(61, 22);
            this.textBox5.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(262, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Шифртекст для исходного сообщения:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(424, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Сравнение частот символов в открытом тексте и шифртексте:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(41, 415);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(252, 171);
            this.textBox6.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Открытый текст";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(362, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Шифртекст";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(365, 415);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(261, 171);
            this.textBox7.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 610);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(483, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Вывод: частоты появления символов в открытом тексте и шифртексте ";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(526, 610);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(177, 22);
            this.textBox8.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 642);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(315, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Открытый текст зашифрованного сообщения ";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(365, 639);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(581, 22);
            this.textBox9.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 780);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Лаб. 5 Шокина";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox9;
    }
}

