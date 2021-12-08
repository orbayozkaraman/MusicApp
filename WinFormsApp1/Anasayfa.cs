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
    public partial class Anasayfa : Form
    {
        SqlConnection connection;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;
        SqlCommand command;
        int Id;
        public Anasayfa(int kullanici_id)
        {
            InitializeComponent();
            this.Id = kullanici_id;
            Top10Goster.Visible = false;
            geridon.Visible = false;
            pop_liste.Visible = false;
            jazz_liste.Visible = false;
            klasik_liste.Visible = false;
            pop_ekle.Visible = false;
            jazz_ekle.Visible = false;
            klasik_ekle.Visible = false;
            topluJazzEkle.Visible = false;
            topluPopEkle.Visible = false;
            topluKlasikEkle.Visible = false;
        }

       



        private void Anasayfa_Load(object sender, EventArgs e)
        {
            kullanici_getir();
            top10();
            muzik_getir();
            album_getir();
            pop_getir();
            klasik_getir();
            jazz_getir();
            ulketop10();
            
        }
        void kullanici_getir()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT Id, Kullanıcı_Ad FROM kullanici", connection);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            kullanici_liste.DataSource = tablo;
            connection.Close();
        }
        void top10()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            dataAdapter = new SqlDataAdapter("Select TOP 10 muzik.Id ," +
                " muzik.muzik_ad," +
                " Sanatci.sanatci_ad," +
                " Kategori.Kategori_ad," +
                " muzik.dinlenme from muzik " +
                "inner join Kategori on Kategori.Id = muzik.kategori_id " +
                "inner join Sanatci on sanatci.Id = muzik.sanatci_id " +
                "ORDER BY muzik.dinlenme DESC", connection);

            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            ilk10.DataSource = tablo;
            connection.Close();
        }
        void muzik_getir()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            dataAdapter = new SqlDataAdapter("select * from muzik ", connection);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            muzikler.DataSource = tablo;
            connection.Close();
        }
        void album_getir()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            dataAdapter = new SqlDataAdapter("select * from album ", connection);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            albumler.DataSource = tablo;
            connection.Close();
        }
        void pop_getir()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            dataAdapter = new SqlDataAdapter("select * from calma_liste " +
                "inner join muzik on muzik.Id = calma_liste.muzik_id " +
                "inner join Kategori on Kategori.Id = muzik.kategori_id " +
                "inner join kullanici on calma_liste.kullanici_id = kullanici.Id where Kategori.Id=1 and kullanici.Id="+this.Id, connection);//+
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            pop_liste.DataSource = tablo;
            connection.Close();
        }
        void jazz_getir()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            dataAdapter = new SqlDataAdapter("select * from calma_liste " +
               "inner join muzik on muzik.Id = calma_liste.muzik_id " +
               "inner join Kategori on Kategori.Id = muzik.kategori_id " +
               "inner join kullanici on calma_liste.kullanici_id = kullanici.Id where Kategori.Id=2 and kullanici.Id=" + this.Id, connection);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            jazz_liste.DataSource = tablo;
            connection.Close();
        }
        void klasik_getir()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            dataAdapter = new SqlDataAdapter("select * from calma_liste " +
                "inner join muzik on muzik.Id = calma_liste.muzik_id " +
                "inner join Kategori on Kategori.Id = muzik.kategori_id " +
                "inner join kullanici on calma_liste.kullanici_id = kullanici.Id where Kategori.Id=3 and kullanici.Id=" + this.Id, connection);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            klasik_liste.DataSource = tablo;
            connection.Close();
        }
        void ulketop10()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            dataAdapter = new SqlDataAdapter("Select TOP 10 Sanatci.sanatci_ulke ," +
                " muzik.muzik_ad," +
                " Sanatci.sanatci_ad," +
                " Kategori.Kategori_ad," +
                " muzik.dinlenme from muzik " +
                "inner join Kategori on Kategori.Id = muzik.kategori_id " +
                "inner join Sanatci on sanatci.Id = muzik.sanatci_id " +
                "ORDER BY muzik.dinlenme DESC", connection);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            ilk10_ulke.DataSource = tablo;
            connection.Close();
        }

        private void cal_Click(object sender, EventArgs e)
        {
            pop_liste.Visible = true;
            jazz_liste.Visible = true;
            klasik_liste.Visible = true;
            pop_ekle.Visible = true;
            jazz_ekle.Visible = true;
            klasik_ekle.Visible = true;
            topluJazzEkle.Visible = true;
            topluPopEkle.Visible = true;
            topluKlasikEkle.Visible = true;
            string queryString = "SELECT * FROM calma_liste WHERE kullanici_id = @kullanici_id AND muzik_id=@muzik_id";
            command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@kullanici_id", this.Id);
            command.Parameters.AddWithValue("@muzik_id", muzikler.CurrentRow.Cells[0].Value);
            connection.Open();
            command.ExecuteNonQuery();
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                connection.Close();
                MessageBox.Show("Müzik zaten playlistinizde mevcut.");
            }
            else
            {
                connection.Close();
                string queryString1 = "INSERT INTO calma_liste(kullanici_id,muzik_id) VALUES(@kullanici_id,@muzik_id)";
                command = new SqlCommand(queryString1, connection);
                command.Parameters.AddWithValue("@kullanici_id", this.Id);
                command.Parameters.AddWithValue("@muzik_id", muzikler.CurrentRow.Cells[0].Value);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                pop_getir();
                jazz_getir();
                klasik_getir();
            }
           


        }

        private void button13_Click(object sender, EventArgs e)
        {
            pop_liste.Visible = true;
            jazz_liste.Visible = true;
            klasik_liste.Visible = true;
            pop_ekle.Visible = true;
            jazz_ekle.Visible = true;
            klasik_ekle.Visible = true;
            topluJazzEkle.Visible = true;
            topluPopEkle.Visible = true;
            topluKlasikEkle.Visible = true;
            string queryString = "UPDATE muzik SET dinlenme = dinlenme + 1 WHERE Id=@Id";
            command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@Id", muzikler.CurrentRow.Cells[0].Value);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            muzik_getir();
            ulketop10();
            top10();
        }

        private void takipet_Click(object sender, EventArgs e)
        {
            int id = (int)kullanici_liste.CurrentRow.Cells[0].Value;
            string queryString = "SELECT * FROM pre_kullanici WHERE Kullanici_id = @Kullanici_id";
            command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@Kullanici_id", id);
            connection.Open();
            command.ExecuteNonQuery();
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                connection.Close();
                string queryString1 = "INSERT INTO takipci(takipci_id,takip_edilen) VALUES(@takipci_id,@takip_edilen)";
                command = new SqlCommand(queryString1, connection);
                command.Parameters.AddWithValue("@takipci_id", this.Id);
                command.Parameters.AddWithValue("@takip_edilen", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Takip Başarılı.");

            }
            else
            {
                connection.Close();
                MessageBox.Show("Kullanıcı Premium Değil.(Takip Edilemez)");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pop_liste.Visible = true;
            jazz_liste.Visible = true;
            klasik_liste.Visible = true;
            pop_ekle.Visible = true;
            jazz_ekle.Visible = true;
            klasik_ekle.Visible = true;
            topluJazzEkle.Visible = true;
            topluPopEkle.Visible = true;
            topluKlasikEkle.Visible = true;
            int id = (int)kullanici_liste.CurrentRow.Cells[0].Value;
            string queryString = "SELECT * FROM takipci WHERE takipci_id = @takipci_id AND takip_edilen = @takip_edilen";
            command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@takipci_id", this.Id);
            command.Parameters.AddWithValue("@takip_edilen", id);
            connection.Open();
            command.ExecuteNonQuery();
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                connection.Close();
                connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                connection.Open();
                dataAdapter = new SqlDataAdapter("Select muzik.Id as Id , muzik.muzik_ad  ," +
                    " Sanatci.sanatci_ad ," +
                    " Kategori.Kategori_ad from calma_liste " +
                    "inner join muzik on muzik.Id = calma_liste.muzik_id " +
                    "inner join Kategori on Kategori.Id = muzik.kategori_id " +
                    "inner join kullanici on calma_liste.kullanici_id = kullanici.Id " +
                    "inner join Sanatci on Sanatci.Id = muzik.sanatci_id " +
                    "WHERE Kategori.Id = 1 AND kullanici.Id=" + id, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                pop_liste.DataSource = table;
                connection.Close();
                connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                connection.Open();
                dataAdapter = new SqlDataAdapter("Select muzik.Id ,muzik.muzik_ad , Sanatci.sanatci_ad , Kategori.Kategori_ad from calma_liste " +
                    "inner join muzik on muzik.Id = calma_liste.muzik_id " +
                    "inner join Kategori on muzik.kategori_id = Kategori.Id " +
                    "inner join kullanici on calma_liste.kullanici_id = kullanici.Id " +
                    "inner join Sanatci on muzik.sanatci_id = Sanatci.Id " +
                    "WHERE Kategori.Id = 2 AND kullanici.Id=" + id, connection);
                DataTable table1 = new DataTable();
                dataAdapter.Fill(table1);
                jazz_liste.DataSource = table1;
                connection.Close();
                connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                connection.Open();
                dataAdapter = new SqlDataAdapter("Select muzik.Id ,muzik.muzik_ad , Sanatci.sanatci_ad , Kategori.Kategori_ad from calma_liste " +
                    "inner join muzik on muzik.Id = calma_liste.muzik_id " +
                    "inner join Kategori on muzik.kategori_id = Kategori.Id " +
                    "inner join kullanici on calma_liste.kullanici_id = kullanici.Id " +
                    "inner join Sanatci on muzik.sanatci_id = Sanatci.Id " +
                    "WHERE Kategori.Id = 3 AND kullanici.Id=" + id, connection);
                DataTable table2 = new DataTable();
                dataAdapter.Fill(table2);
                klasik_liste.DataSource = table2;
                connection.Close();
            }
            else
            {
                connection.Close();
                MessageBox.Show("Çalma listesini görebilmek için takip etmek zorundasın.");
                connection.Close();
            }
        }

        private void pop_ekle_Click(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM calma_liste WHERE kullanici_id = @id AND muzik_id=@muzik_id";
            command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@id", this.Id);
            command.Parameters.AddWithValue("@muzik_id", pop_liste.CurrentRow.Cells[0].Value);
            connection.Open();
            command.ExecuteNonQuery();
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                connection.Close();
                MessageBox.Show("Zaten çalma listesi mevcut.");
            }
            else
            {
                connection.Close();
                string queryString1 = "INSERT INTO calma_liste(kullanici_id,muzik_id) VALUES(@kullanici_id,@muzik_id)";
                command = new SqlCommand(queryString1, connection);
                command.Parameters.AddWithValue("@kullanici_id", this.Id);
                command.Parameters.AddWithValue("@muzik_id", pop_liste.CurrentRow.Cells[0].Value);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
               
            }
            pop_getir();
            jazz_getir();
            klasik_getir();
        }

        private void topluPopEkle_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow satir in pop_liste.Rows)
                {
                    string queryString = "SELECT * FROM calma_liste WHERE kullanici_id = @id AND muzik_id=@muzik_id";
                    command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@id", this.Id);
                    command.Parameters.AddWithValue("@muzik_id", satir.Cells[0].Value);
                    connection.Open();
                    command.ExecuteNonQuery();
                    dataReader = command.ExecuteReader();
                    if (dataReader.Read())
                    {
                        connection.Close();
                        MessageBox.Show("Zaten çalma listesi mevcut.");
                    }
                    else
                    {
                        connection.Close();
                        string queryString1 = "INSERT INTO calma_liste(kullanici_id,muzik_id) VALUES(@kullanici_id,@muzik_id)";
                        command = new SqlCommand(queryString1, connection);
                        command.Parameters.AddWithValue("@kullanici_id", this.Id);
                        command.Parameters.AddWithValue("@muzik_id", satir.Cells[0].Value);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("fsadf");
            }
            
            pop_getir();
            jazz_getir();
            klasik_getir();
        }

        private void calmaListeGörüntüle_Click(object sender, EventArgs e)
        {
            pop_liste.Visible = true;
            jazz_liste.Visible = true;
            klasik_liste.Visible = true;
            pop_ekle.Visible = true;
            jazz_ekle.Visible = true;
            klasik_ekle.Visible = true;
            topluJazzEkle.Visible = true;
            topluPopEkle.Visible = true;
            topluKlasikEkle.Visible = true;

            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                connection.Open();
                dataAdapter = new SqlDataAdapter("Select muzik.Id , muzik.muzik_ad ," +
                    " Sanatci.sanatci_ad ," +
                    " Kategori.Kategori_ad from calma_liste " +
                    "inner join muzik on muzik.Id = calma_liste.muzik_id " +
                    "inner join Kategori on Kategori.Id = muzik.kategori_id " +
                    "inner join kullanici on calma_liste.kullanici_id = kullanici.Id " +
                    "inner join Sanatci on Sanatci.Id = muzik.sanatci_id " +
                    "WHERE Kategori.Id = 1 AND kullanici.Id=" + this.Id, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                pop_liste.DataSource = table;
                connection.Close();
                connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                connection.Open();
                dataAdapter = new SqlDataAdapter("Select muzik.Id ,muzik.muzik_ad , Sanatci.sanatci_ad , Kategori.Kategori_ad from calma_liste " +
                    "inner join muzik on muzik.Id = calma_liste.muzik_id " +
                    "inner join Kategori on muzik.kategori_id = Kategori.Id " +
                    "inner join kullanici on calma_liste.kullanici_id = kullanici.Id " +
                    "inner join Sanatci on muzik.sanatci_id = Sanatci.Id " +
                    "WHERE Kategori.Id = 2 AND kullanici.Id=" + this.Id, connection);
                DataTable table1 = new DataTable();
                dataAdapter.Fill(table1);
                jazz_liste.DataSource = table1;
                connection.Close();
                connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                connection.Open();
                dataAdapter = new SqlDataAdapter("Select muzik.Id ,muzik.muzik_ad , Sanatci.sanatci_ad , Kategori.Kategori_ad from calma_liste " +
                    "inner join muzik on muzik.Id = calma_liste.muzik_id " +
                    "inner join Kategori on muzik.kategori_id = Kategori.Id " +
                    "inner join kullanici on calma_liste.kullanici_id = kullanici.Id " +
                     "inner join Sanatci on muzik.sanatci_id = Sanatci.Id " +
                    "WHERE Kategori.Id = 3 AND kullanici.Id=" + this.Id, connection);
                DataTable table2 = new DataTable();
                dataAdapter.Fill(table2);
                klasik_liste.DataSource = table2;
                connection.Close();

            }
      
        private void button4_Click(object sender, EventArgs e)
        {
            pop_liste.Visible = true;
            jazz_liste.Visible = true;
            klasik_liste.Visible = true;
            pop_ekle.Visible = true;
            jazz_ekle.Visible = true;
            klasik_ekle.Visible = true;
            topluJazzEkle.Visible = true;
            topluPopEkle.Visible = true;
            topluKlasikEkle.Visible = true;
            Top10Goster.Visible = true;
            geridon.Visible = true;
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            dataAdapter = new SqlDataAdapter("Select TOP 10 muzik.Id ," +
                " muzik.muzik_ad ," +
                " Sanatci.sanatci_ad , " +
                " muzik.dinlenme ," +
                " Kategori.Kategori_ad from muzik " +
                "inner join Kategori on Kategori.Id = muzik.kategori_id " +
                "inner join Sanatci on Sanatci.Id = muzik.sanatci_id " +
                "WHERE Kategori.Id = 1" +
                "ORDER BY muzik.dinlenme DESC", connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            pop_liste.DataSource = table;
            connection.Close();
            //asjkdhfjkashjfdsa
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            dataAdapter = new SqlDataAdapter("Select TOP 10 muzik.Id ," +
                " muzik.muzik_ad ," +
                " Sanatci.sanatci_ad , " +
                " muzik.dinlenme ," +
                " Kategori.Kategori_ad from muzik " +
                "inner join Kategori on muzik.kategori_id = Kategori.Id " +
                "inner join Sanatci on muzik.sanatci_id = Sanatci.Id " +
                "WHERE Kategori.Id = 2" +
                "ORDER BY muzik.dinlenme DESC", connection);
            DataTable table1 = new DataTable();
            dataAdapter.Fill(table1);
            jazz_liste.DataSource = table1;
            connection.Close();
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=deneme1.1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            dataAdapter = new SqlDataAdapter("Select TOP 10 muzik.Id ," +
               " muzik.muzik_ad ," +
                " Sanatci.sanatci_ad , " +
                " muzik.dinlenme ," +
                " Kategori.Kategori_ad from muzik " +
                "inner join Kategori on muzik.kategori_id = Kategori.Id " +
                "inner join Sanatci on muzik.sanatci_id = Sanatci.Id " +
                "WHERE Kategori.Id = 3" +
                "ORDER BY muzik.dinlenme DESC", connection);
            DataTable table2 = new DataTable();
            dataAdapter.Fill(table2);
            klasik_liste.DataSource = table2;
            connection.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM calma_liste WHERE kullanici_id = @id AND muzik_id=@muzik_id";
            command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@id", this.Id);
            command.Parameters.AddWithValue("@muzik_id", jazz_liste.CurrentRow.Cells[0].Value);
            connection.Open();
            command.ExecuteNonQuery();
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                connection.Close();
                MessageBox.Show("Zaten çalma listesi mevcut.");
            }
            else
            {
                connection.Close();
                string queryString1 = "INSERT INTO calma_liste(kullanici_id,muzik_id) VALUES(@kullanici_id,@muzik_id)";
                command = new SqlCommand(queryString1, connection);
                command.Parameters.AddWithValue("@kullanici_id", this.Id);
                command.Parameters.AddWithValue("@muzik_id", jazz_liste.CurrentRow.Cells[0].Value);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                pop_getir();
                jazz_getir();
                klasik_getir();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow satir in jazz_liste.Rows)
                {
                    string queryString = "SELECT * FROM calma_liste WHERE kullanici_id = @id AND muzik_id=@muzik_id";
                    command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@id", this.Id);
                    command.Parameters.AddWithValue("@muzik_id", satir.Cells[0].Value);
                    connection.Open();
                    command.ExecuteNonQuery();
                    dataReader = command.ExecuteReader();
                    if (dataReader.Read())
                    {
                        connection.Close();
                        MessageBox.Show("Zaten çalma listesi mevcut.");
                    }
                    else
                    {
                        connection.Close();
                        string queryString1 = "INSERT INTO calma_liste(kullanici_id,muzik_id) VALUES(@kullanici_id,@muzik_id)";
                        command = new SqlCommand(queryString1, connection);
                        command.Parameters.AddWithValue("@kullanici_id", this.Id);
                        command.Parameters.AddWithValue("@muzik_id", satir.Cells[0].Value);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("fsadf");
            }

            pop_getir();
            jazz_getir();
            klasik_getir();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow satir in klasik_liste.Rows)
                {
                    string queryString = "SELECT * FROM calma_liste WHERE kullanici_id = @id AND muzik_id=@muzik_id";
                    command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@id", this.Id);
                    command.Parameters.AddWithValue("@muzik_id", satir.Cells[0].Value);
                    connection.Open();
                    command.ExecuteNonQuery();
                    dataReader = command.ExecuteReader();
                    if (dataReader.Read())
                    {
                        connection.Close();
                        MessageBox.Show("Zaten çalma listesi mevcut.");
                    }
                    else
                    {
                        connection.Close();
                        string queryString1 = "INSERT INTO calma_liste(kullanici_id,muzik_id) VALUES(@kullanici_id,@muzik_id)";
                        command = new SqlCommand(queryString1, connection);
                        command.Parameters.AddWithValue("@kullanici_id", this.Id);
                        command.Parameters.AddWithValue("@muzik_id", satir.Cells[0].Value);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("fsadf");
            }

            pop_getir();
            jazz_getir();
            klasik_getir();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM calma_liste WHERE kullanici_id = @id AND muzik_id=@muzik_id";
            command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@id", this.Id);
            command.Parameters.AddWithValue("@muzik_id", klasik_liste.CurrentRow.Cells[0].Value);
            connection.Open();
            command.ExecuteNonQuery();
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                connection.Close();
                MessageBox.Show("Zaten çalma listesi mevcut.");
            }
            else
            {
                connection.Close();
                string queryString1 = "INSERT INTO calma_liste(kullanici_id,muzik_id) VALUES(@kullanici_id,@muzik_id)";
                command = new SqlCommand(queryString1, connection);
                command.Parameters.AddWithValue("@kullanici_id", this.Id);
                command.Parameters.AddWithValue("@muzik_id", klasik_liste.CurrentRow.Cells[0].Value);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                pop_getir();
                jazz_getir();
                klasik_getir();
            }
        }

        private void ilk10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Top10Goster_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Top10Goster.Visible = false;
            geridon.Visible = false;
        }

        private void kullanici_liste_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pop_liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
            
        }

        private void pop_liste_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

