using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class kayit : Form
    {
       static string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection baglan = new SqlConnection(connection);
        public kayit()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sorgu = "insert into kullanici(Kullanıcı_Ad,Kullanıcı_Mail,sifre,ulke) values(@Kullanıcı_Ad,@Kullanıcı_Mail,@sifre,@ulke)";
                SqlCommand komut = new SqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@Kullanıcı_Ad", txtkullanici_ad.Text);
                komut.Parameters.AddWithValue("@Kullanıcı_Mail", txtkullanici_mail.Text);
                komut.Parameters.AddWithValue("@sifre", txtkullanici_sifre.Text);
                komut.Parameters.AddWithValue("@ulke", txtkullanici_ulke.Text);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Başarılı.");
                new Form1().Show();
                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtkullanici_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kayit_Load(object sender, EventArgs e)
        {

        }
    }
}
