namespace KutuphaneYonetimSistemi
{
    partial class FormkayitSil
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
            labelsil = new Label();
            buttonkayitSil = new Button();
            textBoxsilSifre = new TextBox();
            textBoxsilKullaniciAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBoxsilID = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // labelsil
            // 
            labelsil.AutoSize = true;
            labelsil.Location = new Point(93, 155);
            labelsil.Name = "labelsil";
            labelsil.Size = new Size(17, 15);
            labelsil.TabIndex = 16;
            labelsil.Text = "--";
            // 
            // buttonkayitSil
            // 
            buttonkayitSil.Location = new Point(12, 147);
            buttonkayitSil.Name = "buttonkayitSil";
            buttonkayitSil.Size = new Size(75, 23);
            buttonkayitSil.TabIndex = 15;
            buttonkayitSil.Text = "Sil";
            buttonkayitSil.UseVisualStyleBackColor = true;
            buttonkayitSil.Click += buttonkayitSil_Click;
            // 
            // textBoxsilSifre
            // 
            textBoxsilSifre.Location = new Point(135, 103);
            textBoxsilSifre.Name = "textBoxsilSifre";
            textBoxsilSifre.Size = new Size(121, 23);
            textBoxsilSifre.TabIndex = 14;
            textBoxsilSifre.UseSystemPasswordChar = true;
            // 
            // textBoxsilKullaniciAdi
            // 
            textBoxsilKullaniciAdi.Location = new Point(135, 66);
            textBoxsilKullaniciAdi.Name = "textBoxsilKullaniciAdi";
            textBoxsilKullaniciAdi.Size = new Size(121, 23);
            textBoxsilKullaniciAdi.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F);
            label2.Location = new Point(16, 103);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 12;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F);
            label1.Location = new Point(16, 66);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 11;
            label1.Text = "Kullanıcı Adı:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 185);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxsilID
            // 
            textBoxsilID.Location = new Point(135, 28);
            textBoxsilID.Name = "textBoxsilID";
            textBoxsilID.Size = new Size(121, 23);
            textBoxsilID.TabIndex = 19;
            textBoxsilID.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F);
            label3.Location = new Point(16, 28);
            label3.Name = "label3";
            label3.Size = new Size(33, 19);
            label3.TabIndex = 18;
            label3.Text = "ID :";
            // 
            // FormkayitSil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 250);
            Controls.Add(textBoxsilID);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(labelsil);
            Controls.Add(buttonkayitSil);
            Controls.Add(textBoxsilSifre);
            Controls.Add(textBoxsilKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormkayitSil";
            Text = "FormkayitSil";
            FormClosed += FormkayitSil_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelsil;
        private Button buttonkayitSil;
        private TextBox textBoxsilSifre;
        private TextBox textBoxsilKullaniciAdi;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBoxsilID;
        private Label label3;
    }
}