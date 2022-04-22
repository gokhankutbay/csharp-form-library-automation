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
    public partial class siralama : Form
    {
        public siralama()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=veritabani.accdb");
        DataSet daset = new DataSet();

        private void siralama_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from uyeler order by okudugu_kitap desc", baglanti);
            adtr.Fill(daset, "uyeler");
            dataGridView1.DataSource = daset.Tables["uyeler"];
            baglanti.Close();
            encokokuyanLbl.Text = "";
            enazokuyanLbl.Text = "";
            encokokuyanLbl.Text = daset.Tables["uyeler"].Rows[0]["adsoyad"].ToString() + " = ";
            encokokuyanLbl.Text += daset.Tables["uyeler"].Rows[0]["okudugu_kitap"].ToString() + " kitap okumuş.";
            enazokuyanLbl.Text = daset.Tables["uyeler"].Rows[dataGridView1.Rows.Count - 2]["adsoyad"].ToString() + " = ";
            enazokuyanLbl.Text += daset.Tables["uyeler"].Rows[dataGridView1.Rows.Count - 2]["okudugu_kitap"].ToString() + " kitap okumuş.";
        }
    }
}
