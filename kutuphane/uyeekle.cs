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
    public partial class uyeekle : Form
    {
        public uyeekle()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        OleDbConnection baglanti;
        OleDbCommand cmd;
        OleDbDataReader giris;

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void uyeekle_Load(object sender, EventArgs e)
        {

        }

        private void uyeekleBtn_Click(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=veritabani.accdb");
            OleDbCommand cmd = new OleDbCommand();
            if (tcBox.Text != "" && adsoyadBox.Text != "" && yasBox.Text != "" && cinsiyetBox.Text != "")
            {
                cmd.Connection = baglanti;
                cmd.CommandText = "insert into uyeler(tc,adsoyad,yas,cinsiyet,telefon,adres,eposta,okudugu_kitap) values ('" + tcBox.Text + "','" + adsoyadBox.Text + "','" + yasBox.Text + "','" + cinsiyetBox.Text + "','" + telefonBox.Text + "','" + adresBox.Text + "','" + epostaBox.Text + "','" + okitapBox.Text + "')";
                baglanti.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt tamamdır!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tcBox.Clear();
                adsoyadBox.Clear();
                yasBox.Clear();
                telefonBox.Clear();
                epostaBox.Clear();
                adresBox.Clear();
                okitapBox.Clear();

                //this.Hide();
                //sayfa2 sayfa2 = new sayfa2();
                //sayfa2.Show(); 
            }
            else if (tcBox.Text == "" && adsoyadBox.Text == "" && yasBox.Text == "" && telefonBox.Text == "" && epostaBox.Text == "" && adresBox.Text == "" && okitapBox.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tcBox.Text == "")
            {
                MessageBox.Show("T.C. Alanı Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcBox.Clear();
                adsoyadBox.Clear();
                yasBox.Clear();
                telefonBox.Clear();
                epostaBox.Clear();
                adresBox.Clear();
                okitapBox.Clear();
            }
            else if (adsoyadBox.Text == "")
            {
                MessageBox.Show("Ad Soyad Alanı Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcBox.Clear();
                adsoyadBox.Clear();
                yasBox.Clear();
                telefonBox.Clear();
                epostaBox.Clear();
                adresBox.Clear();
                okitapBox.Clear();
            }
            else if (yasBox.Text == "")
            {
                MessageBox.Show("Yaş Alanı Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcBox.Clear();
                tcBox.Clear();
                adsoyadBox.Clear();
                yasBox.Clear();
                telefonBox.Clear();
                epostaBox.Clear();
                adresBox.Clear();
                okitapBox.Clear();
            }
            else if (telefonBox.Text == "")
            {
                MessageBox.Show("Telefon Alanı Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcBox.Clear();
                adsoyadBox.Clear();
                yasBox.Clear();
                telefonBox.Clear();
                epostaBox.Clear();
                adresBox.Clear();
                okitapBox.Clear();
            }
            else if (epostaBox.Text == "")
            {
                MessageBox.Show("Adres Alanı Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcBox.Clear();
                adsoyadBox.Clear();
                yasBox.Clear();
                telefonBox.Clear();
                epostaBox.Clear();
                adresBox.Clear();
                okitapBox.Clear();
            }
            else if (adresBox.Text == "")
            {
                MessageBox.Show("E-Posta Alanı Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcBox.Clear();
                adsoyadBox.Clear();
                yasBox.Clear();
                telefonBox.Clear();
                epostaBox.Clear();
                adresBox.Clear();
                okitapBox.Clear();
            }
            else if (okitapBox.Text == "")
            {
                MessageBox.Show("Okuduğu Kitap Alanı Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcBox.Clear();
                adsoyadBox.Clear();
                yasBox.Clear();
                telefonBox.Clear();
                epostaBox.Clear();
                adresBox.Clear();
                okitapBox.Clear();
            }
        }
    }
}
