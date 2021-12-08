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
    public partial class admingiris : Form
    {
        SqlConnection connection;
        SqlDataAdapter dataAdapter;
        SqlCommand command;
        private string txtid;
        private string txtid1;
        private string txtid2;
        private string txtid3;
        private object dataGridView1;

        public admingiris()
        {
            InitializeComponent();
        }

        private void admingiris_Load(object sender, EventArgs e)
        {
            muzik_getir();
            album_getir();
            kategori_getir();
            sanatci_getir();
        }
        void muzik_getir()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            dataAdapter = new SqlDataAdapter("select * from muzik ", connection);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            muzik_liste.DataSource = tablo;
            connection.Close();
        }
        void album_getir()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            dataAdapter = new SqlDataAdapter("select * from album ", connection);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            album_liste.DataSource = tablo;
            connection.Close();
        }
        void kategori_getir()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            dataAdapter = new SqlDataAdapter("select * from Kategori ", connection);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            kategori_liste.DataSource = tablo;
            connection.Close();
        }
        void sanatci_getir()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            dataAdapter = new SqlDataAdapter("select * from Sanatci ", connection);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            sanatci_liste.DataSource = tablo;
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
             if (txtalbum_id.Text!="")
            {
                string sorgu = "insert into muzik(sanatci_id,album_id,kategori_id,muzik_ad,muzik_tarih,muzik_süre) values (@sanatci_id,@album_id,@kategori_id,@muzik_ad,@muzik_tarih,@muzik_süre)";
                command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@sanatci_id", Convert.ToInt32(txtsanatci_id.Text));
                command.Parameters.AddWithValue("@album_id", Convert.ToInt32(txtalbum_id.Text));
                command.Parameters.AddWithValue("@kategori_id", Convert.ToInt32(txtkategori_id.Text));
                command.Parameters.AddWithValue("@muzik_ad", txtmuzik_ad.Text);
                command.Parameters.AddWithValue("@muzik_tarih", muzik_tarih.Value);
                command.Parameters.AddWithValue("@muzik_süre", txtmuzik_sure.Text);
            }
            else
            {
                string sorgu = "insert into muzik(sanatci_id,kategori_id,muzik_ad,muzik_tarih,muzik_süre) values (@sanatci_id,@kategori_id,@muzik_ad,@muzik_tarih,@muzik_süre)";
                command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@sanatci_id", Convert.ToInt32(txtsanatci_id.Text));                
                command.Parameters.AddWithValue("@kategori_id", Convert.ToInt32(txtkategori_id.Text));
                command.Parameters.AddWithValue("@muzik_ad", txtmuzik_ad.Text);
                command.Parameters.AddWithValue("@muzik_tarih", muzik_tarih.Value);
                command.Parameters.AddWithValue("@muzik_süre", txtmuzik_sure.Text);
            }
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            muzik_getir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtalbum_id.Text!="")
            {
                string sorgu = "update muzik set sanatci_id = @sanatci_id,album_id=@album_id,kategori_id=@kategori_id,muzik_ad=@muzik_ad,muzik_tarih=@muzik_tarih,muzik_süre=@muzik_süre where Id = @Id";
                command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@Id", Convert.ToInt32(txtid));
                command.Parameters.AddWithValue("@sanatci_id", Convert.ToInt32(txtsanatci_id.Text));
                command.Parameters.AddWithValue("@album_id", Convert.ToInt32(txtalbum_id.Text));
                command.Parameters.AddWithValue("@kategori_id", Convert.ToInt32(txtkategori_id.Text));
                command.Parameters.AddWithValue("@muzik_ad", txtmuzik_ad.Text);
                command.Parameters.AddWithValue("@muzik_tarih", muzik_tarih.Value);
                command.Parameters.AddWithValue("@muzik_süre", txtmuzik_sure.Text);
            }
            else
            {
                string sorgu = "update muzik set sanatci_id = @sanatci_id,kategori_id=@kategori_id,muzik_ad=@muzik_ad,muzik_tarih=@muzik_tarih,muzik_süre=@muzik_süre where Id = @Id";
                command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@Id", Convert.ToInt32(txtid));
                command.Parameters.AddWithValue("@sanatci_id", Convert.ToInt32(txtsanatci_id.Text));   
                command.Parameters.AddWithValue("@kategori_id", Convert.ToInt32(txtkategori_id.Text));
                command.Parameters.AddWithValue("@muzik_ad", txtmuzik_ad.Text);
                command.Parameters.AddWithValue("@muzik_tarih", muzik_tarih.Value);
                command.Parameters.AddWithValue("@muzik_süre", txtmuzik_sure.Text);
            }
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            muzik_getir();
        }

        private void muzik_liste_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid = muzik_liste.CurrentRow.Cells[0].Value.ToString();
            txtsanatci_id.Text = muzik_liste.CurrentRow.Cells[1].Value.ToString();
            txtalbum_id.Text = muzik_liste.CurrentRow.Cells[2].Value.ToString();           
            txtkategori_id.Text = muzik_liste.CurrentRow.Cells[3].Value.ToString();
            txtmuzik_ad.Text = muzik_liste.CurrentRow.Cells[4].Value.ToString();
            muzik_tarih.Text = muzik_liste.CurrentRow.Cells[5].Value.ToString();
            txtmuzik_sure.Text = muzik_liste.CurrentRow.Cells[6].Value.ToString();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from muzik where Id=@Id";
            command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@Id",Convert.ToInt32(txtid));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            muzik_getir();
        }

        private void album_liste_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid1 = album_liste.CurrentRow.Cells[0].Value.ToString();
            txtsanatci_id1.Text = album_liste.CurrentRow.Cells[1].Value.ToString();
            txtkategori_id1.Text = album_liste.CurrentRow.Cells[2].Value.ToString();
            txtmuzik_id1.Text = album_liste.CurrentRow.Cells[3].Value.ToString();
            txtalbum_ad1.Text = album_liste.CurrentRow.Cells[4].Value.ToString();                 
            album_tarih1.Text = album_liste.CurrentRow.Cells[5].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sorgu1 = "insert into album(sanatci_id,kategori_id,muzik_id,album_ad,album_tarih) values (@sanatci_id,@kategori_id,@muzik_id,@album_ad,@album_tarih)";
            command = new SqlCommand(sorgu1, connection);
            command.Parameters.AddWithValue("@sanatci_id", Convert.ToInt32(txtsanatci_id1.Text));
            command.Parameters.AddWithValue("@muzik_id", Convert.ToInt32(txtmuzik_id1.Text));
            command.Parameters.AddWithValue("@kategori_id", Convert.ToInt32(txtkategori_id1.Text));
            command.Parameters.AddWithValue("@album_ad", txtalbum_ad1.Text);
            command.Parameters.AddWithValue("@album_tarih", album_tarih1.Value);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            album_getir();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu1 = "update album set sanatci_id = @sanatci_id,album_ad=@album_ad,kategori_id=@kategori_id,muzik_id=@muzik_id,album_tarih=@album_tarih where Id = @Id";
            command = new SqlCommand(sorgu1, connection);
            command.Parameters.AddWithValue("@Id", Convert.ToInt32(txtid1));
            command.Parameters.AddWithValue("@sanatci_id", Convert.ToInt32(txtsanatci_id1.Text));
            command.Parameters.AddWithValue("@muzik_id", Convert.ToInt32(txtmuzik_id1.Text));
            command.Parameters.AddWithValue("@kategori_id", Convert.ToInt32(txtkategori_id1.Text));
            command.Parameters.AddWithValue("@album_ad", txtalbum_ad1.Text);
            command.Parameters.AddWithValue("@album_tarih", album_tarih1.Value);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            album_getir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu1 = "delete from album where Id=@Id";
            command = new SqlCommand(sorgu1, connection);
            command.Parameters.AddWithValue("@Id", Convert.ToInt32(txtid1));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            album_getir();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into kategori(Kategori_ad) values (@Kategori_ad)";
            command = new SqlCommand(sorgu2, connection);           
            command.Parameters.AddWithValue("@Kategori_ad", txtkategori_ad2.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            kategori_getir();

        }

        private void album_liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update Kategori set Kategori_ad = @Kategori_ad where Id = @Id";
            command = new SqlCommand(sorgu2, connection);
            command.Parameters.AddWithValue("@Id", Convert.ToInt32(txtid2));           
            command.Parameters.AddWithValue("@Kategori_ad", txtkategori_ad2.Text);         
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            kategori_getir();
            
        }

        private void kategori_liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void muzik_liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sorgu2 = "delete from Kategori where Id=@Id";
            command = new SqlCommand(sorgu2, connection);
            command.Parameters.AddWithValue("@Id", Convert.ToInt32(txtid2));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            kategori_getir();
        }

        private void kategori_liste_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid2 = kategori_liste.CurrentRow.Cells[0].Value.ToString();
            txtkategori_ad2.Text = kategori_liste.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          /*txtid3 = sanatci_liste.CurrentRow.Cells[0].Value.ToString();
            txtsanatci_ad3.Text = sanatci_liste.CurrentRow.Cells[1].Value.ToString();*/
        }

        private void sanatci_liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid3 = sanatci_liste.CurrentRow.Cells[0].Value.ToString();
            txtsanatci_ad3.Text = sanatci_liste.CurrentRow.Cells[1].Value.ToString();
            txtsanatci_ulke3.Text = sanatci_liste.CurrentRow.Cells[2].Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string sorgu3 = "insert into Sanatci(sanatci_ad,sanatci_ulke) values (@sanatci_ad,@sanatci_ulke)";
            command = new SqlCommand(sorgu3, connection);
            command.Parameters.AddWithValue("@sanatci_ad", txtsanatci_ad3.Text);
            command.Parameters.AddWithValue("@sanatci_ulke", txtsanatci_ulke3.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            sanatci_getir();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string sorgu3 = "update Sanatci set sanatci_ad = @sanatci_ad,sanatci_ulke=@sanatci_ulke where Id = @Id";
            command = new SqlCommand(sorgu3, connection);
            command.Parameters.AddWithValue("@Id", Convert.ToInt32(txtid3));
            command.Parameters.AddWithValue("@sanatci_ad", txtsanatci_ad3.Text);
            command.Parameters.AddWithValue("@sanatci_ulke", txtsanatci_ulke3.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            sanatci_getir();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string sorgu3 = "delete from Sanatci where Id=@Id";
            command = new SqlCommand(sorgu3, connection);
            command.Parameters.AddWithValue("@Id", Convert.ToInt32(txtid3));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            sanatci_getir();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
