using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Security.Cryptography.Pkcs;

namespace KutuphaneYonetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=LAPTOP-1UFMMF5R;Database=DbKutuphane;Trusted_Connection=True;TrustServerCertificate=True;");


        FormyeniKayit formyeniKayit;
        FormkayitGuncelle formkayitGuncelle;
        FormkayitSil formkayitSil;

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            FormKitaplar formkitaplar;

            string sifre = "";
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT sifre FROM TableKutuphaneYoneticileri WHERE KullaniciAdi = @p1", baglanti);
                sqlCommand.Parameters.AddWithValue("@p1", textBoxKullaniciAdi.Text);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    sifre = reader[0].ToString();
                }

                if (sifre == textBoxSifre.Text)
                {
                    label3.Text = "Þifre Doðru!";
                    formkitaplar = new FormKitaplar();
                    this.Hide();
                    formkitaplar.Show();

                }
                else
                {
                    MessageBox.Show("Kullanýcý Adý veya Þifre Hatalý");
                    textBoxKullaniciAdi.Text = "";
                    textBoxSifre.Text = "";
                    label3.Text = "...";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Baðlantý Hatasý!" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formyeniKayit = new FormyeniKayit();
            this.Hide();
            formyeniKayit.Show();
        }

        private void buttonkayitGuncelle_Click(object sender, EventArgs e)
        {
            formkayitGuncelle = new FormkayitGuncelle();
            this.Hide();
            formkayitGuncelle.Show();
        }

        private void buttonkayitSil_Click(object sender, EventArgs e)
        {
            formkayitSil = new FormkayitSil();
            this.Hide();
            formkayitSil.Show();
        }
    }
}
    