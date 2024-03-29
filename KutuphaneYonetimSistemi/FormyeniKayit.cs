﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemi
{
    public partial class FormyeniKayit : Form
    {
        public FormyeniKayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server=LAPTOP-1UFMMF5R;Database=DbKutuphane;Trusted_Connection=True;TrustServerCertificate=True;");

        Form1 formGiris;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sifre = textBoxyeniSifre.Text;


                if (Regex.IsMatch(sifre, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"))
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO TableKutuphaneYoneticileri (kullaniciAdi,sifre) VALUES (@P1,@P2)", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxyeniKullanici.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", textBoxyeniSifre.Text);

                    sqlCommand.ExecuteNonQuery();

                    label3.Text = "kullanıcı eklendi!";
                }
                else
                {
                    MessageBox.Show("Şifre, en az bir büyük harf, bir küçük harf ve bir rakam içermelidir. Minimum uzunluk 8 karakter olmalıdır.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt işlemi sırasında bir sorun oluştu!", ex.Message);
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

        private void FormyeniKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
