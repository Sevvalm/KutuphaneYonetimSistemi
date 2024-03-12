namespace KutuphaneYonetimSistemi
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F);
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F);
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 216);
            label3.Name = "label3";
            label3.Size = new Size(16, 15);
            label3.TabIndex = 2;
            label3.Text = "...";
            // 
            // textBoxKullaniciAdi
            // 
            textBoxKullaniciAdi.Location = new Point(131, 57);
            textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            textBoxKullaniciAdi.Size = new Size(121, 23);
            textBoxKullaniciAdi.TabIndex = 3;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(131, 111);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(121, 23);
            textBoxSifre.TabIndex = 4;
            textBoxSifre.UseSystemPasswordChar = true;
            // 
            // buttonGiris
            // 
            buttonGiris.Location = new Point(131, 156);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(99, 41);
            buttonGiris.TabIndex = 5;
            buttonGiris.Text = "Giriş";
            buttonGiris.UseVisualStyleBackColor = true;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(341, 268);
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
    }
}
