using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kutuphane
{
    public partial class uyelist : Form
    {
        public uyelist()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=veritabani.accdb");
        DataSet ds = new DataSet();
        OleDbCommand cmd;
        DataSet daset = new DataSet();

        private void uyelistele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from uyeler", baglanti);
            adtr.Fill(daset, "uyeler");
            dataGridView1.DataSource = daset.Tables["uyeler"];
            baglanti.Close();
        }

        private void uyeekleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update uyeler set adsoyad='" + adsoyadBox.Text + "',yas='" + yasBox.Text + "',cinsiyet='" + cinsiyetBox.Text + "',telefon='" + telefonBox.Text + "',adres='" + adresBox.Text + "',eposta='" + epostaBox.Text + "',okudugu_kitap='" + okitapBox.Text + "' where tc='" + tcBox.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            daset.Tables["uyeler"].Clear();
            uyelistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void tcBox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from uyeler where tc like '" + tcBox.Text + "'", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                adsoyadBox.Text = read["adsoyad"].ToString();
                yasBox.Text = read["yas"].ToString();
                cinsiyetBox.Text = read["cinsiyet"].ToString();
                telefonBox.Text = read["telefon"].ToString();
                adresBox.Text = read["eposta"].ToString();
                epostaBox.Text = read["adres"].ToString();
                okitapBox.Text = read["okudugu_kitap"].ToString();
            }
            baglanti.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tcBox.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }

        private void tcaraBox_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["uyeler"].Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from uyeler where tc like '" + tcaraBox.Text + "%'", baglanti);
            adtr.Fill(daset, "uyeler");
            dataGridView1.DataSource = daset.Tables["uyeler"];
            baglanti.Close();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?","Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog==DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("delete from uyeler where tc=@tc", baglanti);
                komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi gerçekleşti!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                daset.Tables["uyeler"].Clear();
                uyelistele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void uyelist_Load(object sender, EventArgs e)
        {
            uyelistele();
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
