
namespace WinFormsApp1
{
    partial class Anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.kullanici_liste = new System.Windows.Forms.DataGridView();
            this.takipet = new System.Windows.Forms.Button();
            this.playlistGörüntüle = new System.Windows.Forms.Button();
            this.calmaListeGörüntüle = new System.Windows.Forms.Button();
            this.top10KatagoriGöster = new System.Windows.Forms.Button();
            this.pop_liste = new System.Windows.Forms.DataGridView();
            this.jazz_liste = new System.Windows.Forms.DataGridView();
            this.klasik_liste = new System.Windows.Forms.DataGridView();
            this.pop_ekle = new System.Windows.Forms.Button();
            this.topluPopEkle = new System.Windows.Forms.Button();
            this.jazz_ekle = new System.Windows.Forms.Button();
            this.topluJazzEkle = new System.Windows.Forms.Button();
            this.klasik_ekle = new System.Windows.Forms.Button();
            this.topluKlasikEkle = new System.Windows.Forms.Button();
            this.muzikler = new System.Windows.Forms.DataGridView();
            this.albumler = new System.Windows.Forms.DataGridView();
            this.cal = new System.Windows.Forms.Button();
            this.dinlenme = new System.Windows.Forms.Button();
            this.ilk10 = new System.Windows.Forms.DataGridView();
            this.ilk10_ulke = new System.Windows.Forms.DataGridView();
            this.Top10Goster = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.geridon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kullanici_liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pop_liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jazz_liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klasik_liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muzikler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilk10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilk10_ulke)).BeginInit();
            this.Top10Goster.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullanici_liste
            // 
            this.kullanici_liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kullanici_liste.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.kullanici_liste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kullanici_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kullanici_liste.Location = new System.Drawing.Point(161, 36);
            this.kullanici_liste.Name = "kullanici_liste";
            this.kullanici_liste.RowHeadersWidth = 51;
            this.kullanici_liste.RowTemplate.Height = 29;
            this.kullanici_liste.Size = new System.Drawing.Size(292, 244);
            this.kullanici_liste.TabIndex = 0;
            this.kullanici_liste.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.kullanici_liste_CellEnter);
            // 
            // takipet
            // 
            this.takipet.BackColor = System.Drawing.Color.DodgerBlue;
            this.takipet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.takipet.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.takipet.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.takipet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.takipet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.takipet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.takipet.Font = new System.Drawing.Font("Sitka Banner", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.takipet.ForeColor = System.Drawing.Color.White;
            this.takipet.Location = new System.Drawing.Point(2, 72);
            this.takipet.Name = "takipet";
            this.takipet.Size = new System.Drawing.Size(153, 37);
            this.takipet.TabIndex = 1;
            this.takipet.Text = "Takip Et";
            this.takipet.UseVisualStyleBackColor = false;
            this.takipet.Click += new System.EventHandler(this.takipet_Click);
            // 
            // playlistGörüntüle
            // 
            this.playlistGörüntüle.BackColor = System.Drawing.Color.DodgerBlue;
            this.playlistGörüntüle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playlistGörüntüle.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.playlistGörüntüle.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.playlistGörüntüle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.playlistGörüntüle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.playlistGörüntüle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playlistGörüntüle.Font = new System.Drawing.Font("Sitka Banner", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.playlistGörüntüle.ForeColor = System.Drawing.Color.White;
            this.playlistGörüntüle.Location = new System.Drawing.Point(2, 115);
            this.playlistGörüntüle.Name = "playlistGörüntüle";
            this.playlistGörüntüle.Size = new System.Drawing.Size(153, 37);
            this.playlistGörüntüle.TabIndex = 1;
            this.playlistGörüntüle.Text = "Listesini Göster";
            this.playlistGörüntüle.UseVisualStyleBackColor = false;
            this.playlistGörüntüle.Click += new System.EventHandler(this.button2_Click);
            // 
            // calmaListeGörüntüle
            // 
            this.calmaListeGörüntüle.BackColor = System.Drawing.Color.DodgerBlue;
            this.calmaListeGörüntüle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calmaListeGörüntüle.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.calmaListeGörüntüle.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.calmaListeGörüntüle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.calmaListeGörüntüle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.calmaListeGörüntüle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calmaListeGörüntüle.Font = new System.Drawing.Font("Sitka Banner", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.calmaListeGörüntüle.ForeColor = System.Drawing.Color.White;
            this.calmaListeGörüntüle.Location = new System.Drawing.Point(2, 157);
            this.calmaListeGörüntüle.Name = "calmaListeGörüntüle";
            this.calmaListeGörüntüle.Size = new System.Drawing.Size(153, 37);
            this.calmaListeGörüntüle.TabIndex = 1;
            this.calmaListeGörüntüle.Text = "Listemi Göster";
            this.calmaListeGörüntüle.UseVisualStyleBackColor = false;
            this.calmaListeGörüntüle.Click += new System.EventHandler(this.calmaListeGörüntüle_Click);
            // 
            // top10KatagoriGöster
            // 
            this.top10KatagoriGöster.BackColor = System.Drawing.Color.DodgerBlue;
            this.top10KatagoriGöster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.top10KatagoriGöster.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.top10KatagoriGöster.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.top10KatagoriGöster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.top10KatagoriGöster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.top10KatagoriGöster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.top10KatagoriGöster.Font = new System.Drawing.Font("Sitka Banner", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.top10KatagoriGöster.ForeColor = System.Drawing.Color.White;
            this.top10KatagoriGöster.Location = new System.Drawing.Point(2, 200);
            this.top10KatagoriGöster.Name = "top10KatagoriGöster";
            this.top10KatagoriGöster.Size = new System.Drawing.Size(153, 37);
            this.top10KatagoriGöster.TabIndex = 1;
            this.top10KatagoriGöster.Text = "Top 10";
            this.top10KatagoriGöster.UseVisualStyleBackColor = false;
            this.top10KatagoriGöster.Click += new System.EventHandler(this.button4_Click);
            // 
            // pop_liste
            // 
            this.pop_liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pop_liste.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.pop_liste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pop_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pop_liste.Location = new System.Drawing.Point(12, 346);
            this.pop_liste.Name = "pop_liste";
            this.pop_liste.RowHeadersWidth = 51;
            this.pop_liste.RowTemplate.Height = 29;
            this.pop_liste.Size = new System.Drawing.Size(536, 188);
            this.pop_liste.TabIndex = 2;
            this.pop_liste.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.pop_liste_CellEnter);
            // 
            // jazz_liste
            // 
            this.jazz_liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jazz_liste.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.jazz_liste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jazz_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jazz_liste.Location = new System.Drawing.Point(554, 346);
            this.jazz_liste.Name = "jazz_liste";
            this.jazz_liste.RowHeadersWidth = 51;
            this.jazz_liste.RowTemplate.Height = 29;
            this.jazz_liste.Size = new System.Drawing.Size(559, 188);
            this.jazz_liste.TabIndex = 2;
            // 
            // klasik_liste
            // 
            this.klasik_liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.klasik_liste.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.klasik_liste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.klasik_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klasik_liste.Location = new System.Drawing.Point(1116, 346);
            this.klasik_liste.Name = "klasik_liste";
            this.klasik_liste.RowHeadersWidth = 51;
            this.klasik_liste.RowTemplate.Height = 29;
            this.klasik_liste.Size = new System.Drawing.Size(605, 188);
            this.klasik_liste.TabIndex = 2;
            // 
            // pop_ekle
            // 
            this.pop_ekle.BackColor = System.Drawing.Color.DodgerBlue;
            this.pop_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pop_ekle.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.pop_ekle.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.pop_ekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.pop_ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.pop_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pop_ekle.Font = new System.Drawing.Font("Sitka Banner", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.pop_ekle.ForeColor = System.Drawing.Color.White;
            this.pop_ekle.Location = new System.Drawing.Point(144, 540);
            this.pop_ekle.Name = "pop_ekle";
            this.pop_ekle.Size = new System.Drawing.Size(120, 37);
            this.pop_ekle.TabIndex = 3;
            this.pop_ekle.Text = "Ekle";
            this.pop_ekle.UseVisualStyleBackColor = false;
            this.pop_ekle.Click += new System.EventHandler(this.pop_ekle_Click);
            // 
            // topluPopEkle
            // 
            this.topluPopEkle.BackColor = System.Drawing.Color.DodgerBlue;
            this.topluPopEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topluPopEkle.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.topluPopEkle.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.topluPopEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.topluPopEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.topluPopEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.topluPopEkle.Font = new System.Drawing.Font("Sitka Banner", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.topluPopEkle.ForeColor = System.Drawing.Color.White;
            this.topluPopEkle.Location = new System.Drawing.Point(271, 540);
            this.topluPopEkle.Name = "topluPopEkle";
            this.topluPopEkle.Size = new System.Drawing.Size(120, 37);
            this.topluPopEkle.TabIndex = 3;
            this.topluPopEkle.Text = "Toplu Ekle";
            this.topluPopEkle.UseVisualStyleBackColor = false;
            this.topluPopEkle.Click += new System.EventHandler(this.topluPopEkle_Click);
            // 
            // jazz_ekle
            // 
            this.jazz_ekle.BackColor = System.Drawing.Color.DodgerBlue;
            this.jazz_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jazz_ekle.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.jazz_ekle.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.jazz_ekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.jazz_ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.jazz_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jazz_ekle.Font = new System.Drawing.Font("Sitka Banner", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.jazz_ekle.ForeColor = System.Drawing.Color.White;
            this.jazz_ekle.Location = new System.Drawing.Point(716, 540);
            this.jazz_ekle.Name = "jazz_ekle";
            this.jazz_ekle.Size = new System.Drawing.Size(120, 37);
            this.jazz_ekle.TabIndex = 3;
            this.jazz_ekle.Text = "Ekle";
            this.jazz_ekle.UseVisualStyleBackColor = false;
            this.jazz_ekle.Click += new System.EventHandler(this.button7_Click);
            // 
            // topluJazzEkle
            // 
            this.topluJazzEkle.BackColor = System.Drawing.Color.DodgerBlue;
            this.topluJazzEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topluJazzEkle.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.topluJazzEkle.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.topluJazzEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.topluJazzEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.topluJazzEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.topluJazzEkle.Font = new System.Drawing.Font("Sitka Banner", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.topluJazzEkle.ForeColor = System.Drawing.Color.White;
            this.topluJazzEkle.Location = new System.Drawing.Point(846, 540);
            this.topluJazzEkle.Name = "topluJazzEkle";
            this.topluJazzEkle.Size = new System.Drawing.Size(120, 37);
            this.topluJazzEkle.TabIndex = 3;
            this.topluJazzEkle.Text = "Toplu Ekle";
            this.topluJazzEkle.UseVisualStyleBackColor = false;
            this.topluJazzEkle.Click += new System.EventHandler(this.button8_Click);
            // 
            // klasik_ekle
            // 
            this.klasik_ekle.BackColor = System.Drawing.Color.DodgerBlue;
            this.klasik_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.klasik_ekle.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.klasik_ekle.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.klasik_ekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.klasik_ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.klasik_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.klasik_ekle.Font = new System.Drawing.Font("Sitka Banner", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.klasik_ekle.ForeColor = System.Drawing.Color.White;
            this.klasik_ekle.Location = new System.Drawing.Point(1267, 540);
            this.klasik_ekle.Name = "klasik_ekle";
            this.klasik_ekle.Size = new System.Drawing.Size(120, 37);
            this.klasik_ekle.TabIndex = 3;
            this.klasik_ekle.Text = "Ekle";
            this.klasik_ekle.UseVisualStyleBackColor = false;
            this.klasik_ekle.Click += new System.EventHandler(this.button9_Click);
            // 
            // topluKlasikEkle
            // 
            this.topluKlasikEkle.BackColor = System.Drawing.Color.DodgerBlue;
            this.topluKlasikEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topluKlasikEkle.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.topluKlasikEkle.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.topluKlasikEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.topluKlasikEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.topluKlasikEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.topluKlasikEkle.Font = new System.Drawing.Font("Sitka Banner", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.topluKlasikEkle.ForeColor = System.Drawing.Color.White;
            this.topluKlasikEkle.Location = new System.Drawing.Point(1402, 540);
            this.topluKlasikEkle.Name = "topluKlasikEkle";
            this.topluKlasikEkle.Size = new System.Drawing.Size(120, 37);
            this.topluKlasikEkle.TabIndex = 3;
            this.topluKlasikEkle.Text = "Toplu Ekle";
            this.topluKlasikEkle.UseVisualStyleBackColor = false;
            this.topluKlasikEkle.Click += new System.EventHandler(this.button10_Click);
            // 
            // muzikler
            // 
            this.muzikler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.muzikler.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.muzikler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.muzikler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.muzikler.Location = new System.Drawing.Point(459, 36);
            this.muzikler.Name = "muzikler";
            this.muzikler.RowHeadersWidth = 51;
            this.muzikler.RowTemplate.Height = 29;
            this.muzikler.Size = new System.Drawing.Size(815, 242);
            this.muzikler.TabIndex = 4;
            // 
            // albumler
            // 
            this.albumler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.albumler.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.albumler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.albumler.Location = new System.Drawing.Point(1280, 34);
            this.albumler.Name = "albumler";
            this.albumler.RowHeadersWidth = 51;
            this.albumler.RowTemplate.Height = 29;
            this.albumler.Size = new System.Drawing.Size(455, 244);
            this.albumler.TabIndex = 4;
            // 
            // cal
            // 
            this.cal.BackColor = System.Drawing.Color.DodgerBlue;
            this.cal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cal.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cal.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.cal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.cal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.cal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cal.Font = new System.Drawing.Font("Sitka Banner", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cal.ForeColor = System.Drawing.Color.White;
            this.cal.Location = new System.Drawing.Point(888, 284);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(120, 37);
            this.cal.TabIndex = 5;
            this.cal.Text = "Listeye Ekle";
            this.cal.UseVisualStyleBackColor = false;
            this.cal.Click += new System.EventHandler(this.cal_Click);
            // 
            // dinlenme
            // 
            this.dinlenme.BackColor = System.Drawing.Color.DodgerBlue;
            this.dinlenme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dinlenme.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.dinlenme.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.dinlenme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.dinlenme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.dinlenme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dinlenme.Font = new System.Drawing.Font("Sitka Banner", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dinlenme.ForeColor = System.Drawing.Color.White;
            this.dinlenme.Location = new System.Drawing.Point(733, 284);
            this.dinlenme.Name = "dinlenme";
            this.dinlenme.Size = new System.Drawing.Size(120, 37);
            this.dinlenme.TabIndex = 5;
            this.dinlenme.Text = "Dinle";
            this.dinlenme.UseVisualStyleBackColor = false;
            this.dinlenme.Click += new System.EventHandler(this.button13_Click);
            // 
            // ilk10
            // 
            this.ilk10.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ilk10.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.ilk10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ilk10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ilk10.Location = new System.Drawing.Point(12, 70);
            this.ilk10.Name = "ilk10";
            this.ilk10.RowHeadersWidth = 51;
            this.ilk10.RowTemplate.Height = 29;
            this.ilk10.Size = new System.Drawing.Size(609, 204);
            this.ilk10.TabIndex = 6;
            this.ilk10.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ilk10_CellContentClick);
            // 
            // ilk10_ulke
            // 
            this.ilk10_ulke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ilk10_ulke.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.ilk10_ulke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ilk10_ulke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ilk10_ulke.Location = new System.Drawing.Point(652, 70);
            this.ilk10_ulke.Name = "ilk10_ulke";
            this.ilk10_ulke.RowHeadersWidth = 51;
            this.ilk10_ulke.RowTemplate.Height = 29;
            this.ilk10_ulke.Size = new System.Drawing.Size(622, 204);
            this.ilk10_ulke.TabIndex = 6;
            // 
            // Top10Goster
            // 
            this.Top10Goster.Controls.Add(this.label1);
            this.Top10Goster.Controls.Add(this.ilk10);
            this.Top10Goster.Controls.Add(this.ilk10_ulke);
            this.Top10Goster.Location = new System.Drawing.Point(459, 2);
            this.Top10Goster.Name = "Top10Goster";
            this.Top10Goster.Size = new System.Drawing.Size(1288, 338);
            this.Top10Goster.TabIndex = 7;
            this.Top10Goster.Paint += new System.Windows.Forms.PaintEventHandler(this.Top10Goster_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(514, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "TOP 10 LİSTE";
            // 
            // geridon
            // 
            this.geridon.BackColor = System.Drawing.Color.DodgerBlue;
            this.geridon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geridon.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.geridon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.geridon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.geridon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.geridon.Font = new System.Drawing.Font("Sitka Banner", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.geridon.ForeColor = System.Drawing.Color.White;
            this.geridon.Location = new System.Drawing.Point(2, 243);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(153, 37);
            this.geridon.TabIndex = 8;
            this.geridon.Text = "Geri Dön";
            this.geridon.UseVisualStyleBackColor = false;
            this.geridon.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.MaximumSize = new System.Drawing.Size(141, 70);
            this.label2.MinimumSize = new System.Drawing.Size(141, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 70);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(1731, 0);
            this.label3.MaximumSize = new System.Drawing.Size(16, 16);
            this.label3.MinimumSize = new System.Drawing.Size(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 8;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1747, 591);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.geridon);
            this.Controls.Add(this.Top10Goster);
            this.Controls.Add(this.dinlenme);
            this.Controls.Add(this.cal);
            this.Controls.Add(this.albumler);
            this.Controls.Add(this.muzikler);
            this.Controls.Add(this.topluKlasikEkle);
            this.Controls.Add(this.klasik_ekle);
            this.Controls.Add(this.topluJazzEkle);
            this.Controls.Add(this.jazz_ekle);
            this.Controls.Add(this.topluPopEkle);
            this.Controls.Add(this.pop_ekle);
            this.Controls.Add(this.klasik_liste);
            this.Controls.Add(this.jazz_liste);
            this.Controls.Add(this.pop_liste);
            this.Controls.Add(this.top10KatagoriGöster);
            this.Controls.Add(this.calmaListeGörüntüle);
            this.Controls.Add(this.playlistGörüntüle);
            this.Controls.Add(this.takipet);
            this.Controls.Add(this.kullanici_liste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullanici_liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pop_liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jazz_liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klasik_liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muzikler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilk10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilk10_ulke)).EndInit();
            this.Top10Goster.ResumeLayout(false);
            this.Top10Goster.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kullanici_liste;
        private System.Windows.Forms.Button takipet;
        private System.Windows.Forms.Button playlistGörüntüle;
        private System.Windows.Forms.Button calmaListeGörüntüle;
        private System.Windows.Forms.Button top10KatagoriGöster;
        private System.Windows.Forms.DataGridView pop_liste;
        private System.Windows.Forms.DataGridView jazz_liste;
        private System.Windows.Forms.DataGridView klasik_liste;
        private System.Windows.Forms.Button pop_ekle;
        private System.Windows.Forms.Button topluPopEkle;
        private System.Windows.Forms.Button jazz_ekle;
        private System.Windows.Forms.Button topluJazzEkle;
        private System.Windows.Forms.Button klasik_ekle;
        private System.Windows.Forms.Button topluKlasikEkle;
        private System.Windows.Forms.DataGridView muzikler;
        private System.Windows.Forms.DataGridView albumler;
        private System.Windows.Forms.Button cal;
        private System.Windows.Forms.Button dinlenme;
        private System.Windows.Forms.DataGridView ilk10;
        private System.Windows.Forms.DataGridView ilk10_ulke;
        private System.Windows.Forms.Panel Top10Goster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button geridon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}