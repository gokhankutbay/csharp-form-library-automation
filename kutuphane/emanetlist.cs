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
    public partial class emanetlist : Form
    {
        public emanetlist()
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

        private void emanelist_Load(object sender, EventArgs e)
        {
            emanetlistele();
            emanetlisteleBox.SelectedIndex = 0;
        }

        private void emanetlisteleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["emanetkitaplar"].Clear();
            if (emanetlisteleBox.SelectedIndex==0)
            {
                emanetlistele();
            }
            else if (emanetlisteleBox.SelectedIndex==1)
            {
                baglanti.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select * from emanetkitaplar where '" + DateTime.Now.ToShortDateString() + "'>iadetarih", baglanti);
                adtr.Fill(daset, "emanetkitaplar");
                dataGridView1.DataSource = daset.Tables["emanetkitaplar"];
                baglanti.Close();
            }
            else if (emanetlisteleBox.SelectedIndex == 2)
            {
                baglanti.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select * from emanetkitaplar where '" + DateTime.Now.ToShortDateString() + "'<=iadetarih", baglanti);
                adtr.Fill(daset, "emanetkitaplar");
                dataGridView1.DataSource = daset.Tables["emanetkitaplar"];
                baglanti.Close();
            }
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
