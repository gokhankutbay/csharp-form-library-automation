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
    public partial class kitapekle : Form
    {
        public kitapekle()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=veritabani.accdb");

        private void kitapekle_Load(object sender, EventArgs e)
        {

        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            if (kitapadiBox.Text!="" && yazarBox.Text!="" && sayfasayisiBox.Text!="" && rafnoBox.Text!="")
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into kitap(barkodno,kitapadi,yazari,sayfasayisi,rafno,aciklama,tarih) values('" + barkodnoBox.Text + "','" + kitapadiBox.Text + "','" + yazarBox.Text + "','" + sayfasayisiBox.Text + "','" + rafnoBox.Text + "','" + aciklamaBox.Text + "','" + DateTime.Now.ToShortDateString()+"')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                barkodnoBox.Clear();
                kitapadiBox.Clear();
                yazarBox.Clear();
                sayfasayisiBox.Clear();
                rafnoBox.Clear();
                aciklamaBox.Clear();
                baglanti.Close();
            }
            else if (barkodnoBox.Text == "" && kitapadiBox.Text=="" && yazarBox.Text == "" && sayfasayisiBox.Text == "" && rafnoBox.Text == "")
            {
                MessageBox.Show("Lütfen bilgileri doldurunuz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                barkodnoBox.Clear();
                kitapadiBox.Clear();
                yazarBox.Clear();
                sayfasayisiBox.Clear();
                rafnoBox.Clear();
                aciklamaBox.Clear();
                baglanti.Close();
            }
            else if (barkodnoBox.Text == "")
            {
                MessageBox.Show("Barkod no boş bırakılamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                barkodnoBox.Clear();
                kitapadiBox.Clear();
                yazarBox.Clear();
                sayfasayisiBox.Clear();
                rafnoBox.Clear();
                aciklamaBox.Clear();
                baglanti.Close();
            }
            else if(kitapadiBox.Text=="")
            {
                MessageBox.Show("Kitap adı boş bırakılamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                barkodnoBox.Clear();
                kitapadiBox.Clear();
                yazarBox.Clear();
                sayfasayisiBox.Clear();
                rafnoBox.Clear();
                aciklamaBox.Clear();
                baglanti.Close();
            }
            else if (yazarBox.Text == "")
            {
                MessageBox.Show("Kitap yazarı boş bırakılamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                barkodnoBox.Clear();
                kitapadiBox.Clear();
                yazarBox.Clear();
                sayfasayisiBox.Clear();
                rafnoBox.Clear();
                aciklamaBox.Clear();
                baglanti.Close();
            }
            else if (sayfasayisiBox.Text == "")
            {
                MessageBox.Show("Sayfa sayısı boş bırakılamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                barkodnoBox.Clear();
                kitapadiBox.Clear();
                yazarBox.Clear();
                sayfasayisiBox.Clear();
                rafnoBox.Clear();
                aciklamaBox.Clear();
                baglanti.Close();
            }
            else if (rafnoBox.Text == "")
            {
                MessageBox.Show("Raf no boş bırakılamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                barkodnoBox.Clear();
                kitapadiBox.Clear();
                yazarBox.Clear();
                sayfasayisiBox.Clear();
                rafnoBox.Clear();
                aciklamaBox.Clear();
                baglanti.Close();
            }
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void barkodnoBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
