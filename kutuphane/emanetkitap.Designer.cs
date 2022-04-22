namespace kutuphane
{
    partial class emanetkitap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emanetkitap));
            this.cinsiyetBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.okitapBox = new System.Windows.Forms.TextBox();
            this.epostaBox = new System.Windows.Forms.TextBox();
            this.adsoyadBox = new System.Windows.Forms.TextBox();
            this.tcBox = new System.Windows.Forms.TextBox();
            this.rafnoBox = new System.Windows.Forms.TextBox();
            this.sayfasayisiBox = new System.Windows.Forms.TextBox();
            this.yazarBox = new System.Windows.Forms.TextBox();
            this.kitapadiBox = new System.Windows.Forms.TextBox();
            this.barkodnoBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.yeniBtn = new System.Windows.Forms.Button();
            this.kitapverBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cikisBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cinsiyetBox
            // 
            this.cinsiyetBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinsiyetBox.Enabled = false;
            this.cinsiyetBox.FormattingEnabled = true;
            this.cinsiyetBox.Items.AddRange(new object[] {
            "Kadın",
            "Erkek",
            "Diğer"});
            this.cinsiyetBox.Location = new System.Drawing.Point(151, 107);
            this.cinsiyetBox.Name = "cinsiyetBox";
            this.cinsiyetBox.Size = new System.Drawing.Size(132, 21);
            this.cinsiyetBox.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(34, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Okuduğu Kitap Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(98, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "E-Posta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.OrangeRed;
            this.label11.Location = new System.Drawing.Point(99, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Cinsiyet:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.OrangeRed;
            this.label13.Location = new System.Drawing.Point(90, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Ad Soyad:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(116, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "T.C.:";
            // 
            // okitapBox
            // 
            this.okitapBox.Enabled = false;
            this.okitapBox.Location = new System.Drawing.Point(151, 187);
            this.okitapBox.Name = "okitapBox";
            this.okitapBox.Size = new System.Drawing.Size(132, 20);
            this.okitapBox.TabIndex = 37;
            // 
            // epostaBox
            // 
            this.epostaBox.Enabled = false;
            this.epostaBox.Location = new System.Drawing.Point(152, 147);
            this.epostaBox.Name = "epostaBox";
            this.epostaBox.Size = new System.Drawing.Size(132, 20);
            this.epostaBox.TabIndex = 36;
            // 
            // adsoyadBox
            // 
            this.adsoyadBox.Enabled = false;
            this.adsoyadBox.Location = new System.Drawing.Point(152, 67);
            this.adsoyadBox.Name = "adsoyadBox";
            this.adsoyadBox.Size = new System.Drawing.Size(132, 20);
            this.adsoyadBox.TabIndex = 32;
            // 
            // tcBox
            // 
            this.tcBox.Location = new System.Drawing.Point(152, 27);
            this.tcBox.Name = "tcBox";
            this.tcBox.Size = new System.Drawing.Size(132, 20);
            this.tcBox.TabIndex = 31;
            this.tcBox.TextChanged += new System.EventHandler(this.tcBox_TextChanged);
            // 
            // rafnoBox
            // 
            this.rafnoBox.Enabled = false;
            this.rafnoBox.Location = new System.Drawing.Point(512, 187);
            this.rafnoBox.Name = "rafnoBox";
            this.rafnoBox.Size = new System.Drawing.Size(202, 20);
            this.rafnoBox.TabIndex = 56;
            // 
            // sayfasayisiBox
            // 
            this.sayfasayisiBox.Enabled = false;
            this.sayfasayisiBox.Location = new System.Drawing.Point(512, 147);
            this.sayfasayisiBox.Name = "sayfasayisiBox";
            this.sayfasayisiBox.Size = new System.Drawing.Size(202, 20);
            this.sayfasayisiBox.TabIndex = 55;
            // 
            // yazarBox
            // 
            this.yazarBox.Enabled = false;
            this.yazarBox.Location = new System.Drawing.Point(512, 107);
            this.yazarBox.Name = "yazarBox";
            this.yazarBox.Size = new System.Drawing.Size(202, 20);
            this.yazarBox.TabIndex = 54;
            // 
            // kitapadiBox
            // 
            this.kitapadiBox.Enabled = false;
            this.kitapadiBox.Location = new System.Drawing.Point(512, 67);
            this.kitapadiBox.Name = "kitapadiBox";
            this.kitapadiBox.Size = new System.Drawing.Size(202, 20);
            this.kitapadiBox.TabIndex = 53;
            // 
            // barkodnoBox
            // 
            this.barkodnoBox.Location = new System.Drawing.Point(512, 27);
            this.barkodnoBox.Name = "barkodnoBox";
            this.barkodnoBox.Size = new System.Drawing.Size(202, 20);
            this.barkodnoBox.TabIndex = 52;
            this.barkodnoBox.TextChanged += new System.EventHandler(this.barkodnoBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Barkod No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(462, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Raf No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(439, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Sayfa Sayısı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(467, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Yazarı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(454, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Kitap Adı:";
            // 
            // yeniBtn
            // 
            this.yeniBtn.Location = new System.Drawing.Point(808, 67);
            this.yeniBtn.Name = "yeniBtn";
            this.yeniBtn.Size = new System.Drawing.Size(75, 23);
            this.yeniBtn.TabIndex = 59;
            this.yeniBtn.Text = "Yeni";
            this.yeniBtn.UseVisualStyleBackColor = true;
            this.yeniBtn.Click += new System.EventHandler(this.yeniBtn_Click);
            // 
            // kitapverBtn
            // 
            this.kitapverBtn.Location = new System.Drawing.Point(808, 30);
            this.kitapverBtn.Name = "kitapverBtn";
            this.kitapverBtn.Size = new System.Drawing.Size(75, 23);
            this.kitapverBtn.TabIndex = 60;
            this.kitapverBtn.Text = "Kitap Ver";
            this.kitapverBtn.UseVisualStyleBackColor = true;
            this.kitapverBtn.Click += new System.EventHandler(this.kitapverBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Veriliş Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "İade Tarihi:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(514, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 63;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(514, 268);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 64;
            // 
            // cikisBtn
            // 
            this.cikisBtn.Location = new System.Drawing.Point(808, 100);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(75, 23);
            this.cikisBtn.TabIndex = 66;
            this.cikisBtn.Text = "İptal";
            this.cikisBtn.UseVisualStyleBackColor = true;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // emanetkitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(925, 313);
            this.Controls.Add(this.cikisBtn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kitapverBtn);
            this.Controls.Add(this.yeniBtn);
            this.Controls.Add(this.rafnoBox);
            this.Controls.Add(this.sayfasayisiBox);
            this.Controls.Add(this.yazarBox);
            this.Controls.Add(this.kitapadiBox);
            this.Controls.Add(this.barkodnoBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cinsiyetBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.okitapBox);
            this.Controls.Add(this.epostaBox);
            this.Controls.Add(this.adsoyadBox);
            this.Controls.Add(this.tcBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "emanetkitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Kitap Ver | İmtal Kütüphanesi";
            this.Load += new System.EventHandler(this.emanetkitap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cinsiyetBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox okitapBox;
        private System.Windows.Forms.TextBox epostaBox;
        private System.Windows.Forms.TextBox adsoyadBox;
        private System.Windows.Forms.TextBox tcBox;
        private System.Windows.Forms.TextBox rafnoBox;
        private System.Windows.Forms.TextBox sayfasayisiBox;
        private System.Windows.Forms.TextBox yazarBox;
        private System.Windows.Forms.TextBox kitapadiBox;
        private System.Windows.Forms.TextBox barkodnoBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button yeniBtn;
        private System.Windows.Forms.Button kitapverBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button cikisBtn;
    }
}