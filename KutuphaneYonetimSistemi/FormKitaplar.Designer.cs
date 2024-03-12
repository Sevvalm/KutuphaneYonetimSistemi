namespace KutuphaneYonetimSistemi
{
    partial class FormKitaplar
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
            buttonKitapGuncelle = new Button();
            textBoxKitapAdi = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox6 = new GroupBox();
            buttonKayitSil = new Button();
            buttonYeniKitapEkle = new Button();
            groupBox5 = new GroupBox();
            button4 = new Button();
            buttonara = new Button();
            button2 = new Button();
            labelID = new Label();
            label6 = new Label();
            label5 = new Label();
            labelYazarSoyad = new Label();
            labelYazarAdi = new Label();
            labelKitapAdi = new Label();
            textBoxKitapTurKodu = new TextBox();
            textBoxISBN = new TextBox();
            textBoxYazarSoyad = new TextBox();
            textBoxYazarAdi = new TextBox();
            groupBox2 = new GroupBox();
            buttonKitapOduncVer = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBoxOduncAlan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            groupBox3 = new GroupBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            buttonGecikmeBedeliHesapla = new Button();
            label8 = new Label();
            labelGecikmeBedeli = new Label();
            label4 = new Label();
            groupBox4 = new GroupBox();
            dataGridViewKitaplar = new DataGridView();
            textBoxromaRakam = new TextBox();
            buttonsayiyaCevir = new Button();
            labelsayiyiGoster = new Label();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            SuspendLayout();
            // 
            // buttonKitapGuncelle
            // 
            buttonKitapGuncelle.BackColor = Color.FromArgb(255, 255, 128);
            buttonKitapGuncelle.Location = new Point(113, 15);
            buttonKitapGuncelle.Name = "buttonKitapGuncelle";
            buttonKitapGuncelle.Size = new Size(97, 39);
            buttonKitapGuncelle.TabIndex = 0;
            buttonKitapGuncelle.Text = "Kitap Bilgileri Güncelle";
            buttonKitapGuncelle.UseVisualStyleBackColor = false;
            buttonKitapGuncelle.Click += buttonKitapGuncelle_Click;
            // 
            // textBoxKitapAdi
            // 
            textBoxKitapAdi.Location = new Point(109, 49);
            textBoxKitapAdi.Name = "textBoxKitapAdi";
            textBoxKitapAdi.Size = new Size(123, 23);
            textBoxKitapAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Kitap ID :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(labelID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(labelYazarSoyad);
            groupBox1.Controls.Add(labelYazarAdi);
            groupBox1.Controls.Add(labelKitapAdi);
            groupBox1.Controls.Add(textBoxKitapTurKodu);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxISBN);
            groupBox1.Controls.Add(textBoxYazarSoyad);
            groupBox1.Controls.Add(textBoxYazarAdi);
            groupBox1.Controls.Add(textBoxKitapAdi);
            groupBox1.Location = new Point(12, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 196);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "KitapKayıt ve Güncelleme";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(buttonKayitSil);
            groupBox6.Controls.Add(buttonYeniKitapEkle);
            groupBox6.Controls.Add(buttonKitapGuncelle);
            groupBox6.Location = new Point(258, 112);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(322, 69);
            groupBox6.TabIndex = 18;
            groupBox6.TabStop = false;
            groupBox6.Text = "Kitap Kayıt";
            // 
            // buttonKayitSil
            // 
            buttonKayitSil.BackColor = Color.Tomato;
            buttonKayitSil.Location = new Point(220, 15);
            buttonKayitSil.Name = "buttonKayitSil";
            buttonKayitSil.Size = new Size(97, 39);
            buttonKayitSil.TabIndex = 16;
            buttonKayitSil.Text = "Kitap Kaydı Sil";
            buttonKayitSil.UseVisualStyleBackColor = false;
            buttonKayitSil.Click += buttonKayitSil_Click;
            // 
            // buttonYeniKitapEkle
            // 
            buttonYeniKitapEkle.BackColor = Color.FromArgb(128, 255, 128);
            buttonYeniKitapEkle.Location = new Point(8, 15);
            buttonYeniKitapEkle.Name = "buttonYeniKitapEkle";
            buttonYeniKitapEkle.Size = new Size(97, 39);
            buttonYeniKitapEkle.TabIndex = 11;
            buttonYeniKitapEkle.Text = "Yeni Kitap Ekle";
            buttonYeniKitapEkle.UseVisualStyleBackColor = false;
            buttonYeniKitapEkle.Click += buttonYeniKitapEkle_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button4);
            groupBox5.Controls.Add(buttonara);
            groupBox5.Controls.Add(button2);
            groupBox5.Location = new Point(258, 22);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(292, 74);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Arama";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 255);
            button4.Location = new Point(187, 18);
            button4.Name = "button4";
            button4.Size = new Size(86, 39);
            button4.TabIndex = 15;
            button4.Text = "Tümünü Göster";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // buttonara
            // 
            buttonara.Location = new Point(3, 18);
            buttonara.Name = "buttonara";
            buttonara.Size = new Size(86, 39);
            buttonara.TabIndex = 14;
            buttonara.Text = "Ara";
            buttonara.UseVisualStyleBackColor = true;
            buttonara.Click += buttonara_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Location = new Point(95, 18);
            button2.Name = "button2";
            button2.Size = new Size(86, 39);
            button2.TabIndex = 13;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(109, 29);
            labelID.Name = "labelID";
            labelID.Size = new Size(12, 15);
            labelID.TabIndex = 12;
            labelID.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 173);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 10;
            label6.Text = "Kitap Tür Kodu :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 142);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "ISBN :";
            // 
            // labelYazarSoyad
            // 
            labelYazarSoyad.AutoSize = true;
            labelYazarSoyad.Location = new Point(6, 115);
            labelYazarSoyad.Name = "labelYazarSoyad";
            labelYazarSoyad.Size = new Size(75, 15);
            labelYazarSoyad.TabIndex = 8;
            labelYazarSoyad.Text = "Yazar Soyad :";
            // 
            // labelYazarAdi
            // 
            labelYazarAdi.AutoSize = true;
            labelYazarAdi.Location = new Point(6, 86);
            labelYazarAdi.Name = "labelYazarAdi";
            labelYazarAdi.Size = new Size(61, 15);
            labelYazarAdi.TabIndex = 7;
            labelYazarAdi.Text = "Yazar Adı :";
            // 
            // labelKitapAdi
            // 
            labelKitapAdi.AutoSize = true;
            labelKitapAdi.Location = new Point(6, 57);
            labelKitapAdi.Name = "labelKitapAdi";
            labelKitapAdi.Size = new Size(61, 15);
            labelKitapAdi.TabIndex = 6;
            labelKitapAdi.Text = "Kitap Adı :";
            // 
            // textBoxKitapTurKodu
            // 
            textBoxKitapTurKodu.Location = new Point(109, 165);
            textBoxKitapTurKodu.Name = "textBoxKitapTurKodu";
            textBoxKitapTurKodu.Size = new Size(123, 23);
            textBoxKitapTurKodu.TabIndex = 5;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(109, 134);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(123, 23);
            textBoxISBN.TabIndex = 4;
            // 
            // textBoxYazarSoyad
            // 
            textBoxYazarSoyad.Location = new Point(109, 107);
            textBoxYazarSoyad.Name = "textBoxYazarSoyad";
            textBoxYazarSoyad.Size = new Size(123, 23);
            textBoxYazarSoyad.TabIndex = 3;
            // 
            // textBoxYazarAdi
            // 
            textBoxYazarAdi.Location = new Point(109, 78);
            textBoxYazarAdi.Name = "textBoxYazarAdi";
            textBoxYazarAdi.Size = new Size(123, 23);
            textBoxYazarAdi.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonKitapOduncVer);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(textBoxOduncAlan);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(620, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(231, 130);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap Ödünç Alma";
            // 
            // buttonKitapOduncVer
            // 
            buttonKitapOduncVer.BackColor = SystemColors.ActiveCaption;
            buttonKitapOduncVer.Location = new Point(50, 72);
            buttonKitapOduncVer.Name = "buttonKitapOduncVer";
            buttonKitapOduncVer.Size = new Size(97, 39);
            buttonKitapOduncVer.TabIndex = 11;
            buttonKitapOduncVer.Text = "Kitap Ödünç Ver";
            buttonKitapOduncVer.UseVisualStyleBackColor = false;
            buttonKitapOduncVer.Click += buttonKitapOduncVer_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(50, 43);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(167, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // textBoxOduncAlan
            // 
            textBoxOduncAlan.Location = new Point(91, 17);
            textBoxOduncAlan.Name = "textBoxOduncAlan";
            textBoxOduncAlan.Size = new Size(100, 23);
            textBoxOduncAlan.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 52);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "Tarih :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 25);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 7;
            label2.Text = "Ödünç Alan  :";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(127, 78);
            button1.Name = "button1";
            button1.Size = new Size(101, 39);
            button1.TabIndex = 12;
            button1.Text = "Kitap İade Et";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(buttonGecikmeBedeliHesapla);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(labelGecikmeBedeli);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(620, 145);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(270, 130);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kitap İade";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "2", "4", "6", "8", "10" });
            comboBox1.Location = new Point(127, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 52);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 14;
            label7.Text = "Gecikme Bedeli Seç :";
            // 
            // buttonGecikmeBedeliHesapla
            // 
            buttonGecikmeBedeliHesapla.BackColor = Color.Silver;
            buttonGecikmeBedeliHesapla.Location = new Point(22, 78);
            buttonGecikmeBedeliHesapla.Name = "buttonGecikmeBedeliHesapla";
            buttonGecikmeBedeliHesapla.Size = new Size(97, 39);
            buttonGecikmeBedeliHesapla.TabIndex = 12;
            buttonGecikmeBedeliHesapla.Text = "Gecikme Bedeli Hesapla";
            buttonGecikmeBedeliHesapla.UseVisualStyleBackColor = false;
            buttonGecikmeBedeliHesapla.Click += buttonGecikmeBedeliHesapla_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(139, 25);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 10;
            label8.Text = "TL";
            // 
            // labelGecikmeBedeli
            // 
            labelGecikmeBedeli.AutoSize = true;
            labelGecikmeBedeli.Location = new Point(106, 25);
            labelGecikmeBedeli.Name = "labelGecikmeBedeli";
            labelGecikmeBedeli.Size = new Size(12, 15);
            labelGecikmeBedeli.TabIndex = 9;
            labelGecikmeBedeli.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 25);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 8;
            label4.Text = "Gecikme Bedeli :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewKitaplar);
            groupBox4.Location = new Point(2, 271);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(951, 154);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kitap Listesi";
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKitaplar.Dock = DockStyle.Fill;
            dataGridViewKitaplar.Location = new Point(3, 19);
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.Size = new Size(945, 132);
            dataGridViewKitaplar.TabIndex = 0;
            dataGridViewKitaplar.CellClick += dataGridViewKitaplar_CellClick;
            // 
            // textBoxromaRakam
            // 
            textBoxromaRakam.Location = new Point(121, 232);
            textBoxromaRakam.Name = "textBoxromaRakam";
            textBoxromaRakam.Size = new Size(100, 23);
            textBoxromaRakam.TabIndex = 7;
            // 
            // buttonsayiyaCevir
            // 
            buttonsayiyaCevir.Location = new Point(236, 232);
            buttonsayiyaCevir.Name = "buttonsayiyaCevir";
            buttonsayiyaCevir.Size = new Size(75, 23);
            buttonsayiyaCevir.TabIndex = 8;
            buttonsayiyaCevir.Text = "Çevir";
            buttonsayiyaCevir.UseVisualStyleBackColor = true;
            buttonsayiyaCevir.Click += buttonsayiyaCevir_Click;
            // 
            // labelsayiyiGoster
            // 
            labelsayiyiGoster.AutoSize = true;
            labelsayiyiGoster.Location = new Point(327, 240);
            labelsayiyiGoster.Name = "labelsayiyiGoster";
            labelsayiyiGoster.Size = new Size(16, 15);
            labelsayiyiGoster.TabIndex = 9;
            labelsayiyiGoster.Text = "...";
            // 
            // FormKitaplar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 426);
            Controls.Add(labelsayiyiGoster);
            Controls.Add(buttonsayiyaCevir);
            Controls.Add(textBoxromaRakam);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormKitaplar";
            Text = "Kütüphane Yönetim Sistemi";
            FormClosed += FormKitaplar_FormClosed;
            Load += FormKitaplar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonKitapGuncelle;
        private TextBox textBoxKitapAdi;
        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label labelYazarSoyad;
        private Label labelYazarAdi;
        private Label labelKitapAdi;
        private TextBox textBoxKitapTurKodu;
        private TextBox textBoxISBN;
        private TextBox textBoxYazarSoyad;
        private TextBox textBoxYazarAdi;
        private Button buttonYeniKitapEkle;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxOduncAlan;
        private Label label3;
        private Label label2;
        private Button buttonKitapOduncVer;
        private GroupBox groupBox3;
        private Button buttonGecikmeBedeliHesapla;
        private Label label8;
        private Label labelGecikmeBedeli;
        private Label label4;
        private GroupBox groupBox4;
        private DataGridView dataGridViewKitaplar;
        private Label labelID;
        private Button button1;
        private ComboBox comboBox1;
        private Label label7;
        private Button buttonara;
        private Button button2;
        private Button button4;
        private Button buttonKayitSil;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private TextBox textBoxromaRakam;
        private Button buttonsayiyaCevir;
        private Label labelsayiyiGoster;
    }
}