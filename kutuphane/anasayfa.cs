using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void sayfa2_Load(object sender, EventArgs e)
        {

        }

        private void uyeekleBtn_Click(object sender, EventArgs e)
        {
            uyeekle uyekle = new uyeekle();
            uyekle.Show(); 
        }

        private void uyelistBtn_Click(object sender, EventArgs e)
        {
            uyelist uyelist = new uyelist();
            uyelist.Show();
        }

        private void kitapekleBtn_Click(object sender, EventArgs e)
        {
            kitapekle kitapekle = new kitapekle();
            kitapekle.Show();
        }

        private void kitaplistBtn_Click(object sender, EventArgs e)
        {
            kitaplist kitaplist = new kitaplist();
            kitaplist.Show();
        }

        private void emanetkitapverBtn_Click(object sender, EventArgs e)
        {
            emanetkitap emanetkitap = new emanetkitap();
            emanetkitap.Show();
        }

        private void emanetkitaplisteleBtn_Click(object sender, EventArgs e)
        {
            emanetlist emanetlist = new emanetlist();
            emanetlist.Show();
        }

        private void emanetkitapiadeBtn_Click(object sender, EventArgs e)
        {
            emanetiade emanetiade = new emanetiade();
            emanetiade.Show();
        }

        private void siralamaBtn_Click(object sender, EventArgs e)
        {
            siralama siralama = new siralama();
            siralama.Show();
        }

        private void hazirlayanlarBtn_Click(object sender, EventArgs e)
        {
            emegigecenler emegigecenler = new emegigecenler();
            emegigecenler.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
