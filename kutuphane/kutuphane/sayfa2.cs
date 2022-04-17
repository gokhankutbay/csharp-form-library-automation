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
    public partial class sayfa2 : Form
    {
        public sayfa2()
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
    }
}
