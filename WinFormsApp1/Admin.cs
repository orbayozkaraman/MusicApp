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
    public partial class Admin : Form
    {
        SqlConnection connection;
        SqlDataReader dataReader;
        SqlCommand command;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string admin_ad = txtadmin_ad.Text;
            string admin_sifre = txtadmin_sifre.Text;
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "Select * from kullanici inner join Admin on kullanici.Id=Admin.Kullanici_id where Kullanıcı_Ad='" + admin_ad + "' and sifre='" + admin_sifre + "'";       
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                MessageBox.Show("Giriş Başarılı..");
                new admingiris().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hata.");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void txtadmin_ad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
