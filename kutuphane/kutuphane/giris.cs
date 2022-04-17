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
    public partial class giris : Form
    {
        public giris()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbCommand cmd;
        OleDbDataReader girisyap;

        private void girisButton_Click(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=veritabani.accdb");
            cmd = new OleDbCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT * FROM admin where kuladi='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";
            girisyap = cmd.ExecuteReader();
            if (girisyap.Read())
            {
                this.Hide();
                sayfa2 sayfa2 = new sayfa2();
                sayfa2.Show();
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı Alanı Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox2.Clear();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Şifre Alanı Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Yanlış Bilgiler!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
