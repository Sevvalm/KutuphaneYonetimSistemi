﻿namespace KutuphaneYonetimSistemi
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxKullaniciAdi = new TextBox();
            textBoxSifre = new TextBox();
            buttonGiris = new Button();
            button1 = new Button();
            buttonkayitGuncelle = new Button();
            buttonkayitSil = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F);
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 130);
            label3.Name = "label3";
            label3.Size = new Size(16, 15);
            label3.TabIndex = 2;
            label3.Text = "...";
            // 
            // textBoxKullaniciAdi
            // 
            textBoxKullaniciAdi.Location = new Point(131, 20);
            textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            textBoxKullaniciAdi.Size = new Size(121, 23);
            textBoxKullaniciAdi.TabIndex = 3;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(131, 57);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(121, 23);
            textBoxSifre.TabIndex = 4;
            textBoxSifre.UseSystemPasswordChar = true;
            // 
            // buttonGiris
            // 
            buttonGiris.Location = new Point(131, 86);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(99, 41);
            buttonGiris.TabIndex = 5;
            buttonGiris.Text = "Giriş";
            buttonGiris.UseVisualStyleBackColor = true;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 166);
            button1.Name = "button1";
            button1.Size = new Size(85, 31);
            button1.TabIndex = 6;
            button1.Text = "Yeni Kayıt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonkayitGuncelle
            // 
            buttonkayitGuncelle.Location = new Point(114, 166);
            buttonkayitGuncelle.Name = "buttonkayitGuncelle";
            buttonkayitGuncelle.Size = new Size(99, 31);
            buttonkayitGuncelle.TabIndex = 7;
            buttonkayitGuncelle.Text = "Kayıt Güncelle";
            buttonkayitGuncelle.UseVisualStyleBackColor = true;
            buttonkayitGuncelle.Click += buttonkayitGuncelle_Click;
            // 
            // buttonkayitSil
            // 
            buttonkayitSil.Location = new Point(230, 166);
            buttonkayitSil.Name = "buttonkayitSil";
            buttonkayitSil.Size = new Size(85, 31);
            buttonkayitSil.TabIndex = 8;
            buttonkayitSil.Text = "Kayıt Sil";
            buttonkayitSil.UseVisualStyleBackColor = true;
            buttonkayitSil.Click += buttonkayitSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(341, 268);
            Controls.Add(buttonkayitSil);
            Controls.Add(buttonkayitGuncelle);
            Controls.Add(button1);
            Controls.Add(buttonGiris);
            Controls.Add(textBoxSifre);
            Controls.Add(textBoxKullaniciAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxKullaniciAdi;
        private TextBox textBoxSifre;
        private Button buttonGiris;
        private Button button1;
        private Button buttonkayitGuncelle;
        private Button buttonkayitSil;
    }
}
