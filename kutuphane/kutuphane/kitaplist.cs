using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class kitaplist : Form
    {
        public kitaplist()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=veritabani.accdb");
        DataSet ds = new DataSet();
        OleDbCommand cmd;
        DataSet daset = new DataSet();

        private void kitaplistele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from kitap", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update kitap set kitapadi='" + kitapadiBox.Text + "',yazari='" + yazarBox.Text + "',sayfasayisi='" + sayfasayisiBox.Text + "',rafno='" + rafnoBox.Text + "',aciklama='" + aciklamaBox.Text + "' where barkodno='" + barkodnoBox.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            daset.Tables["kitap"].Clear();
            kitaplistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kitabı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("delete from kitap where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi gerçekleşti!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                daset.Tables["kitap"].Clear();
                kitaplistele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            barkodnoBox.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
        }

        private void kitaparaBox_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["kitap"].Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from kitap where kitapadi like '%" + kitaparaBox.Text + "%'", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }

        private void kitaplist_Load(object sender, EventArgs e)
        {
            kitaplistele();
        }

        private void kitapnoBox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from kitap where barkodno like '" + barkodnoBox.Text + "'", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                barkodnoBox.Text = read["barkodno"].ToString();
                kitapadiBox.Text = read["kitapadi"].ToString();
                yazarBox.Text = read["yazari"].ToString();
                sayfasayisiBox.Text = read["sayfasayisi"].ToString();
                rafnoBox.Text = read["rafno"].ToString();
                aciklamaBox.Text = read["aciklama"].ToString();
            }
            baglanti.Close();
        }
    }
}
