namespace KutuphaneYonetimSistemi
{
    partial class FormkayitGuncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxySifre = new TextBox();
            textBoxyKullaniciAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBoxySifre
            // 
            textBoxySifre.Location = new Point(131, 62);
            textBoxySifre.Name = "textBoxySifre";
            textBoxySifre.Size = new Size(121, 23);
            textBoxySifre.TabIndex = 8;
            textBoxySifre.UseSystemPasswordChar = true;
            // 
            // textBoxyKullaniciAdi
            // 
            textBoxyKullaniciAdi.Location = new Point(131, 25);
            textBoxyKullaniciAdi.Name = "textBoxyKullaniciAdi";
            textBoxyKullaniciAdi.Size = new Size(121, 23);
            textBoxyKullaniciAdi.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F);
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 6;
            label2.Text = "Yeni Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adı:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 113);
            button1.Name = "button1";
            button1.Size = new Size(99, 23);
            button1.TabIndex = 9;
            button1.Text = "Şifre Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 121);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 10;
            label3.Text = "--";
            // 
            // button2
            // 
            button2.Location = new Point(12, 142);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Giriş";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormkayitGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 249);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBoxySifre);
            Controls.Add(textBoxyKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormkayitGuncelle";
            Text = "FormkayitGuncelle";
            FormClosed += FormkayitGuncelle_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxySifre;
        private TextBox textBoxyKullaniciAdi;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label3;
        private Button button2;
    }
}