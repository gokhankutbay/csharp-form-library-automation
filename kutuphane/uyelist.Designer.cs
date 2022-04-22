namespace kutuphane
{
    partial class uyelist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyelist));
            this.iptalBtn = new System.Windows.Forms.Button();
            this.uyeekleBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cinsiyetBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.okitapBox = new System.Windows.Forms.TextBox();
            this.adresBox = new System.Windows.Forms.TextBox();
            this.epostaBox = new System.Windows.Forms.TextBox();
            this.telefonBox = new System.Windows.Forms.TextBox();
            this.yasBox = new System.Windows.Forms.TextBox();
            this.adsoyadBox = new System.Windows.Forms.TextBox();
            this.tcBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.tcaraBox = new System.Windows.Forms.TextBox();
            this.silBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iptalBtn
            // 
            this.iptalBtn.Location = new System.Drawing.Point(192, 338);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(62, 23);
            this.iptalBtn.TabIndex = 39;
            this.iptalBtn.Text = "İptal";
            this.iptalBtn.UseVisualStyleBackColor = true;
            this.iptalBtn.Click += new System.EventHandler(this.iptalBtn_Click);
            // 
            // uyeekleBtn
            // 
            this.uyeekleBtn.Location = new System.Drawing.Point(124, 338);
            this.uyeekleBtn.Name = "uyeekleBtn";
            this.uyeekleBtn.Size = new System.Drawing.Size(62, 23);
            this.uyeekleBtn.TabIndex = 38;
            this.uyeekleBtn.Text = "Güncelle";
            this.uyeekleBtn.UseVisualStyleBackColor = true;
            this.uyeekleBtn.Click += new System.EventHandler(this.uyeekleBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Adres:";
            // 
            // cinsiyetBox
            // 
            this.cinsiyetBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinsiyetBox.FormattingEnabled = true;
            this.cinsiyetBox.Items.AddRange(new object[] {
            "Erkek",
            "Kadın",
            "Diğer"});
            this.cinsiyetBox.Location = new System.Drawing.Point(124, 163);
            this.cinsiyetBox.Name = "cinsiyetBox";
            this.cinsiyetBox.Size = new System.Drawing.Size(132, 21);
            this.cinsiyetBox.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Okuduğu Kitap Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "E-Posta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cinsiyet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Yaş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "T.C.:";
            // 
            // okitapBox
            // 
            this.okitapBox.Location = new System.Drawing.Point(124, 301);
            this.okitapBox.Name = "okitapBox";
            this.okitapBox.Size = new System.Drawing.Size(132, 20);
            this.okitapBox.TabIndex = 28;
            // 
            // adresBox
            // 
            this.adresBox.Location = new System.Drawing.Point(124, 233);
            this.adresBox.Name = "adresBox";
            this.adresBox.Size = new System.Drawing.Size(132, 20);
            this.adresBox.TabIndex = 27;
            // 
            // epostaBox
            // 
            this.epostaBox.Location = new System.Drawing.Point(124, 269);
            this.epostaBox.Name = "epostaBox";
            this.epostaBox.Size = new System.Drawing.Size(132, 20);
            this.epostaBox.TabIndex = 26;
            // 
            // telefonBox
            // 
            this.telefonBox.Location = new System.Drawing.Point(124, 198);
            this.telefonBox.Name = "telefonBox";
            this.telefonBox.Size = new System.Drawing.Size(132, 20);
            this.telefonBox.TabIndex = 25;
            // 
            // yasBox
            // 
            this.yasBox.Location = new System.Drawing.Point(124, 128);
            this.yasBox.Name = "yasBox";
            this.yasBox.Size = new System.Drawing.Size(132, 20);
            this.yasBox.TabIndex = 24;
            // 
            // adsoyadBox
            // 
            this.adsoyadBox.Location = new System.Drawing.Point(124, 91);
            this.adsoyadBox.Name = "adsoyadBox";
            this.adsoyadBox.Size = new System.Drawing.Size(132, 20);
            this.adsoyadBox.TabIndex = 23;
            // 
            // tcBox
            // 
            this.tcBox.Location = new System.Drawing.Point(124, 56);
            this.tcBox.Name = "tcBox";
            this.tcBox.Size = new System.Drawing.Size(132, 20);
            this.tcBox.TabIndex = 22;
            this.tcBox.TextChanged += new System.EventHandler(this.tcBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(281, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 305);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "T.C. Ara:";
            // 
            // tcaraBox
            // 
            this.tcaraBox.Location = new System.Drawing.Point(387, 12);
            this.tcaraBox.Name = "tcaraBox";
            this.tcaraBox.Size = new System.Drawing.Size(132, 20);
            this.tcaraBox.TabIndex = 41;
            this.tcaraBox.TextChanged += new System.EventHandler(this.tcaraBox_TextChanged);
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(801, 56);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(37, 23);
            this.silBtn.TabIndex = 43;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // uyelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(846, 419);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tcaraBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.iptalBtn);
            this.Controls.Add(this.uyeekleBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cinsiyetBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okitapBox);
            this.Controls.Add(this.adresBox);
            this.Controls.Add(this.epostaBox);
            this.Controls.Add(this.telefonBox);
            this.Controls.Add(this.yasBox);
            this.Controls.Add(this.adsoyadBox);
            this.Controls.Add(this.tcBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "uyelist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Arama - Listeleme - Güncelleme - Silme | İmtal Kütüphanesi";
            this.Load += new System.EventHandler(this.uyelist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iptalBtn;
        private System.Windows.Forms.Button uyeekleBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cinsiyetBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox okitapBox;
        private System.Windows.Forms.TextBox adresBox;
        private System.Windows.Forms.TextBox epostaBox;
        private System.Windows.Forms.TextBox telefonBox;
        private System.Windows.Forms.TextBox yasBox;
        private System.Windows.Forms.TextBox adsoyadBox;
        private System.Windows.Forms.TextBox tcBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tcaraBox;
        private System.Windows.Forms.Button silBtn;
    }
}