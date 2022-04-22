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
    public partial class emanetkitap : Form
    {
        public emanetkitap()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=veritabani.accdb");
        DataSet daset = new DataSet();

        private void tcBox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from uyeler where tc like '" + tcBox.Text + "'", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                adsoyadBox.Text = read["adsoyad"].ToString();
                cinsiyetBox.Text = read["cinsiyet"].ToString();
                epostaBox.Text = read["eposta"].ToString();
                okitapBox.Text = read["okudugu_kitap"].ToString();
            }
            baglanti.Close();
        }

        private void barkodnoBox_TextChanged(object sender, EventArgs e)
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
            }
            baglanti.Close();
        }

        private void kitapverBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into emanetkitaplar (tc,adsoyad,cinsiyet,eposta,okudugu_kitap,barkodno,kitapadi,yazari,sayfasayisi,rafno,verilistarih,iadetarih) values('" + tcBox.Text + "','" + adsoyadBox.Text + "','" + cinsiyetBox.Text + "','" + epostaBox.Text + "','" + okitapBox.Text + "','" + barkodnoBox.Text + "','" + kitapadiBox.Text + "','" + yazarBox.Text + "','" + sayfasayisiBox.Text + "', '" + rafnoBox.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla kitap üyeye verildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            baglanti.Close();

        }

        private void emanetkitap_Load(object sender, EventArgs e)
        {
            
        }

        private void yeniBtn_Click(object sender, EventArgs e)
        {
            tcBox.Clear();
            adsoyadBox.Clear();
            epostaBox.Clear();
            okitapBox.Clear();
            barkodnoBox.Clear();
            kitapadiBox.Clear();
            yazarBox.Clear();
            sayfasayisiBox.Clear();
            rafnoBox.Clear();
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
