using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemi
{
    public partial class FormKitaplar : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=LAPTOP-1UFMMF5R;Database=DbKutuphane;Trusted_Connection=True;TrustServerCertificate=True;");
        public FormKitaplar()
        {
            InitializeComponent();
        }



        private void buttonYeniKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO TableKitaplar(KitapAdi,YazarAdi,YazarSoyadi,ISBN,Durum,KitapTurKodu) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxYazarSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", "False");
                sqlCommand.Parameters.AddWithValue("@P6", textBoxKitapTurKodu.Text);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap eklerken hata oluştu.Lütfen veritabanını kontrol ediniz!" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            verileriGoster();

        }


        private void verileriGoster()
        {
            try
            {
                string q = "SELECT * FROM TableKitaplar";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormKitaplar_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridViewKitaplar.SelectedCells[0].RowIndex;
            labelID.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxKitapAdi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxYazarAdi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxYazarSoyad.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[3].Value.ToString();
            textBoxISBN.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[4].Value.ToString();
            textBoxKitapTurKodu.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[8].Value.ToString();

            textBoxOduncAlan.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[6].Value.ToString();

            if (dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value != DBNull.Value)

                dateTimePicker1.Value = (DateTime)dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value;

        }

        private void buttonKitapGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET KitapAdi=@P1, YazarAdi=@P2, YazarsoyAdi=@P3, ISBN= @P4, KitapTurKodu=@P5 WHERE ID=@P6", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxYazarSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", textBoxKitapTurKodu.Text);
                sqlCommand.Parameters.AddWithValue("@P6", labelID.Text);

                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap güncellenirken hata oluştu.Lütfen veritabanını kontrol ediniz!" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            verileriGoster();
        }

        private void buttonKitapOduncVer_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {


                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET OduncAlan= @P1, OduncAlmaTarihi= @P2, Durum= @P3 WHERE ID=@P4 ", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxOduncAlan.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    sqlCommand.Parameters.AddWithValue("@P3", "True");
                    sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);

                    sqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap ödünç işlemi sırasında hata oluştu!" + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }

                verileriGoster();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {


                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET OduncAlan= @P1, OduncAlmaTarihi= @P2, Durum= @P3 WHERE ID=@P4 ", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", DBNull.Value);
                    sqlCommand.Parameters.AddWithValue("@P2", DBNull.Value);
                    sqlCommand.Parameters.AddWithValue("@P3", false);
                    sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);

                    sqlCommand.ExecuteNonQuery();

                    textBoxOduncAlan.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap iadesi sırasında hata oluştu!" + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }

                verileriGoster();
            }
        }

        private void buttonGecikmeBedeliHesapla_Click(object sender, EventArgs e)
        {


            if (comboBox1.Text != null)
            {
                int secilenfiyat = int.Parse(comboBox1.Text);
                int gunFarki = 0;
                int gecikmeBedeli = 0;

                try
                {
                    if (labelID.Text != "-")
                    {
                        DateTime bugununtarihi = DateTime.Now;
                        gunFarki = (int)(bugununtarihi - dateTimePicker1.Value.Date).TotalDays;
                        gecikmeBedeli = Math.Max(0,(gunFarki - 10) * secilenfiyat);

                    }
                    labelGecikmeBedeli.Text = gecikmeBedeli.ToString();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Gecikme bedeli hesaplanırken hata oluştu!" + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }

                verileriGoster();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        public void kutucuklariTemizle()
        {
            labelID.Text = "-";
            textBoxKitapAdi.Text = "";
            textBoxYazarAdi.Text = "";
            textBoxYazarSoyad.Text = "";
            textBoxISBN.Text = "";
            textBoxKitapTurKodu.Text = "";
            textBoxOduncAlan.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kutucuklariTemizle();
        }
        private void buttonara_Click(object sender, EventArgs e)
        {
            aramaSonuclariniGoster();
        }

        private void aramaSonuclariniGoster()
        {
            try
            {
                string q = "SELECT * FROM TableKitaplar WHERE KitapAdi LIKE '%" + textBoxKitapAdi.Text + "%' " +
                                                "AND YazarAdi LIKE '%" + textBoxYazarAdi.Text + "%' " +
                                                "AND YazarSoyadi LIKE '%" + textBoxYazarSoyad.Text + "%' " +
                                                "AND ISBN LIKE '%" + textBoxISBN.Text + "%' " +
                                                "AND KitapTurKodu LIKE '%" + textBoxKitapTurKodu.Text + "%' " +
                                                "AND OduncAlan LIKE '%" + textBoxOduncAlan.Text + "%'";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonKayitSil_Click(object sender, EventArgs e)
        {
            if (labelID.Text == "-" || labelID.Text == "")
            {
                MessageBox.Show("Lütfen Bir Kitap Seçiniz!");
            }

            else
            {

                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE TableKitaplar WHERE ID=@P1 ", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", labelID.Text);

                    sqlCommand.ExecuteNonQuery();

                    textBoxOduncAlan.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap kaydı silinirken bir hata oluştu!" + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }

                verileriGoster();
            }
        }

        private void FormKitaplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private int sayiyaDonustur(string romaRakam)
        {
            int  sayi = 0;
             
            foreach(char rakam in romaRakam)
            {
                if (rakam == 'I')
                    sayi += 1;
                else if (rakam == 'V')
                    sayi += 5;
                else if (rakam == 'X')
                    sayi += 10;
                else if (rakam == 'L')
                    sayi += 50;
                else if (rakam == 'C')
                    sayi += 100;
                else if (rakam == 'D')
                    sayi += 500;
                else if (rakam == 'M')
                    sayi += 1000;
                else
                    return -1;

            }
            return sayi;
        }

        private void buttonsayiyaCevir_Click(object sender, EventArgs e)
        {
            string romaRakam = textBoxromaRakam.Text.ToUpper();
            int sayi = sayiyaDonustur(romaRakam);
            labelsayiyiGoster.Text = sayi.ToString();

        }
  
    }
}
