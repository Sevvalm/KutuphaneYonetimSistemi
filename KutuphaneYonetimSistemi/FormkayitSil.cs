using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemi
{
    public partial class FormkayitSil : Form
    {
        public FormkayitSil()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server=LAPTOP-1UFMMF5R;Database=DbKutuphane;Trusted_Connection=True;TrustServerCertificate=True;");

        Form1 formGiris;

        private void buttonkayitSil_Click(object sender, EventArgs e)
        {
            if (textBoxsilKullaniciAdi.Text == "" && textBoxsilSifre.Text == "")
            {
                labelsil.Text = "Kullanıcı adı ve şifre giriniz!";
            }
            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM TableKutuphaneYoneticileri WHERE kullaniciAdi=@P1, Sifre=@P2, ID=@P3", baglanti);
                    checkCommand.Parameters.AddWithValue("@P1", textBoxsilKullaniciAdi.Text);
                    checkCommand.Parameters.AddWithValue("@P2", textBoxsilSifre.Text);
                    checkCommand.Parameters.AddWithValue("@P3", textBoxsilID.Text);

                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        SqlCommand sqlCommand = new SqlCommand("DELETE FROM TableKutuphaneYoneticileri ky join TableiletisimKutuphaneYonetici ik on ky.ID=ik.ID WHERE ID=@P1", baglanti);

                        sqlCommand.Parameters.AddWithValue("@P1", textBoxsilKullaniciAdi.Text);
                        sqlCommand.Parameters.AddWithValue("@P2", textBoxsilSifre.Text);

                        sqlCommand.ExecuteNonQuery();

                        labelsil.Text = "Kayıt silindi!";

                    }
                    else
                    {
                        labelsil.Text = "Belirtilen kullanıcı adı ve şifre ile eşleşen kayıt bulunamadı.";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally 
                {
                    baglanti.Close();
                }
            }

            /*
            if (textBoxsilKullaniciAdi.Text == "" && textBoxsilSifre.Text == "")
            {
                labelsil.Text = "Kullanıcı adı ve şifre giriniz!";
            }
            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE TableKutuphaneYoneticileri WHERE kullaniciAdi=@P1,Sifre=@P2 ", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxsilKullaniciAdi.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", textBoxsilSifre.Text);

                    sqlCommand.ExecuteNonQuery();

                    labelsil.Text = "Kayıt silindi!";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            */
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formGiris = new Form1();
            this.Hide();
            formGiris.Show();
        }

        private void FormkayitSil_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
