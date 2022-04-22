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
    public partial class emanetiade : Form
    {
        public emanetiade()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=veritabani.accdb");
        DataSet daset = new DataSet();

        private void emanetlistele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from emanetkitaplar", baglanti);
            adtr.Fill(daset, "emanetkitaplar");
            dataGridView1.DataSource = daset.Tables["emanetkitaplar"];
            baglanti.Close();
        }

        private void emanetiade_Load(object sender, EventArgs e)
        {
            emanetlistele();
        }

        private void tcaraBox_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["emanetkitaplar"].Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from emanetkitaplar where tc like '"+tcaraBox.Text+"%'",baglanti);
            adtr.Fill(daset, "emanetkitaplar");
            baglanti.Close();
            if (tcaraBox.Text=="")
            {
                daset.Tables["emanetkitaplar"].Clear();
                emanetlistele();
            }
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void barkodnoaraBox_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["emanetkitaplar"].Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from emanetkitaplar where barkodno like '" + barkodnoaraBox.Text + "%'", baglanti);
            adtr.Fill(daset, "emanetkitaplar");
            baglanti.Close();
            if (barkodnoaraBox.Text == "")
            {
                daset.Tables["emanetkitaplar"].Clear();
                emanetlistele();
            }
        }

        private void teslimalBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from emanetkitaplar where tc=@tc and barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap iade edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            daset.Tables["emanetkitaplar"].Clear();
            emanetlistele();
        }
    }
}
