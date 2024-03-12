using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemi
{
    public partial class FormkayitGuncelle : Form
    {
        public FormkayitGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=LAPTOP-1UFMMF5R;Database=DbKutuphane;Trusted_Connection=True;TrustServerCertificate=True;");
        Form1 formGiris;

        private void button1_Click(object sender, EventArgs e)
        {
            string sifre = "";
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT top(1) sifre FROM TableKutuphaneYoneticileri WHERE KullaniciAdi = @p1", baglanti);
                sqlCommand.Parameters.AddWithValue("@p1", textBoxyKullaniciAdi.Text);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    sifre = reader[0].ToString();
                }
                baglanti.Close();

                if (sifre == textBoxySifre.Text)
                {
                    label3.Text = "Yeni şifre eski şifre ile aynı olamaz!";
                    //todo: regex ile kontrol yapılacak
                }
                else
                {
                    baglanti.Open();
                    SqlCommand sqlCommand2 = new SqlCommand("UPDATE TableKutuphaneYoneticileri SET sifre=@P1 WHERE kullaniciAdi=@P2", baglanti);
                    sqlCommand2.Parameters.AddWithValue("@P2", textBoxyKullaniciAdi.Text);
                    sqlCommand2.Parameters.AddWithValue("@P1", textBoxySifre.Text);

                    sqlCommand2.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt güncellenirken hata oluştu!", ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formGiris = new Form1();
            this.Hide();
            formGiris.Show();
        }

        private void FormkayitGuncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
