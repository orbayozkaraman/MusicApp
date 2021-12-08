using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection connection; 
        SqlDataReader dataReader; 
        SqlCommand command;
        int kullanici_id;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string kullanici_ad = txtkullanıcı_ad.Text;
                string kullanici_sifre = txtkullanici_sifre.Text;
                connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                command = new SqlCommand();
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from kullanici where Kullanıcı_Ad='" + kullanici_ad + "' and sifre='" + kullanici_sifre + "'";//giriş yapanılan veriyi database ile kıyaslayıp bulmaya çalışıyor. 
                kullanici_id = (int)command.ExecuteScalar();//ilk veriyi çekiyor
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    MessageBox.Show("Giriş Başarılı..");
                    new Anasayfa(kullanici_id).Show();                   
                    this.Hide();
                   
                  
                }
                else
                {
                    MessageBox.Show("Hata.");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("hataaaaaa");
                
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new kayit().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Admin().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
