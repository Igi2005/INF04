namespace paczka
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
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            miasto = new TextBox();
            kod = new TextBox();
            ulica = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            cena = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(49, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 163);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rodzaj przesyłki";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(21, 88);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(61, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Paczka";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(21, 63);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(43, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "List";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(21, 38);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(82, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Pocztówka";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(49, 224);
            button1.Name = "button1";
            button1.Size = new Size(216, 23);
            button1.TabIndex = 1;
            button1.Text = "Sprawdź cene";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pocztowka;
            pictureBox1.Location = new Point(49, 262);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(miasto);
            groupBox2.Controls.Add(kod);
            groupBox2.Controls.Add(ulica);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(338, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(277, 206);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dane adresowe";
            // 
            // miasto
            // 
            miasto.Location = new Point(11, 148);
            miasto.Name = "miasto";
            miasto.Size = new Size(246, 23);
            miasto.TabIndex = 5;
            // 
            // kod
            // 
            kod.Location = new Point(11, 96);
            kod.Name = "kod";
            kod.Size = new Size(129, 23);
            kod.TabIndex = 4;
            // 
            // ulica
            // 
            ulica.Location = new Point(11, 49);
            ulica.Name = "ulica";
            ulica.Size = new Size(246, 23);
            ulica.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 130);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Miasto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 78);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Kod pocztowy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 31);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Ulica z numerem";
            // 
            // button2
            // 
            button2.Location = new Point(49, 347);
            button2.Name = "button2";
            button2.Size = new Size(561, 23);
            button2.TabIndex = 4;
            button2.Text = "Zatwierdź";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cena
            // 
            cena.AutoSize = true;
            cena.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            cena.Location = new Point(178, 262);
            cena.Name = "cena";
            cena.Size = new Size(0, 28);
            cena.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 450);
            Controls.Add(cena);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Nadaj przesylke Autor El Wojtas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Button button1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private TextBox miasto;
        private TextBox kod;
        private TextBox ulica;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Label cena;
    }
}
