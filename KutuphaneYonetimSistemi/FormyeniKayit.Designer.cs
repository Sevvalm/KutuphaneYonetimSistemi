namespace KutuphaneYonetimSistemi
{
    partial class FormyeniKayit
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
            button1 = new Button();
            textBoxyeniKullanici = new TextBox();
            textBoxyeniSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(23, 129);
            button1.Name = "button1";
            button1.Size = new Size(79, 29);
            button1.TabIndex = 0;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxyeniKullanici
            // 
            textBoxyeniKullanici.Location = new Point(122, 39);
            textBoxyeniKullanici.Name = "textBoxyeniKullanici";
            textBoxyeniKullanici.Size = new Size(110, 23);
            textBoxyeniKullanici.TabIndex = 1;
            // 
            // textBoxyeniSifre
            // 
            textBoxyeniSifre.Location = new Point(122, 83);
            textBoxyeniSifre.Name = "textBoxyeniSifre";
            textBoxyeniSifre.Size = new Size(110, 23);
            textBoxyeniSifre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 42);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 3;
            label1.Text = " Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 91);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Şifre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 143);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 5;
            label3.Text = "--";
            // 
            // button2
            // 
            button2.Location = new Point(23, 184);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Giriş";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormyeniKayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 290);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxyeniSifre);
            Controls.Add(textBoxyeniKullanici);
            Controls.Add(button1);
            Name = "FormyeniKayit";
            Text = "FormyeniKayit";
            FormClosed += FormyeniKayit_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxyeniKullanici;
        private TextBox textBoxyeniSifre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}