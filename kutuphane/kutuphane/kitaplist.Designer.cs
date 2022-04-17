namespace kutuphane
{
    partial class kitaplist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitaplist));
            this.iptalBtn = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rafnoBox = new System.Windows.Forms.TextBox();
            this.sayfasayisiBox = new System.Windows.Forms.TextBox();
            this.yazarBox = new System.Windows.Forms.TextBox();
            this.kitapadiBox = new System.Windows.Forms.TextBox();
            this.barkodnoBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.silBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.kitaparaBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.aciklamaBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iptalBtn
            // 
            this.iptalBtn.Location = new System.Drawing.Point(184, 366);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(75, 23);
            this.iptalBtn.TabIndex = 35;
            this.iptalBtn.Text = "İptal";
            this.iptalBtn.UseVisualStyleBackColor = true;
            this.iptalBtn.Click += new System.EventHandler(this.iptalBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(98, 366);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(75, 23);
            this.guncelleBtn.TabIndex = 34;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Raf no:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Sayfa Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Yazarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Kitap Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Barkod No:";
            // 
            // rafnoBox
            // 
            this.rafnoBox.Location = new System.Drawing.Point(98, 246);
            this.rafnoBox.Name = "rafnoBox";
            this.rafnoBox.Size = new System.Drawing.Size(161, 20);
            this.rafnoBox.TabIndex = 25;
            // 
            // sayfasayisiBox
            // 
            this.sayfasayisiBox.Location = new System.Drawing.Point(98, 203);
            this.sayfasayisiBox.Name = "sayfasayisiBox";
            this.sayfasayisiBox.Size = new System.Drawing.Size(161, 20);
            this.sayfasayisiBox.TabIndex = 24;
            // 
            // yazarBox
            // 
            this.yazarBox.Location = new System.Drawing.Point(98, 160);
            this.yazarBox.Name = "yazarBox";
            this.yazarBox.Size = new System.Drawing.Size(161, 20);
            this.yazarBox.TabIndex = 23;
            // 
            // kitapadiBox
            // 
            this.kitapadiBox.Location = new System.Drawing.Point(98, 117);
            this.kitapadiBox.Name = "kitapadiBox";
            this.kitapadiBox.Size = new System.Drawing.Size(161, 20);
            this.kitapadiBox.TabIndex = 22;
            // 
            // barkodnoBox
            // 
            this.barkodnoBox.Location = new System.Drawing.Point(98, 74);
            this.barkodnoBox.Name = "barkodnoBox";
            this.barkodnoBox.Size = new System.Drawing.Size(161, 20);
            this.barkodnoBox.TabIndex = 21;
            this.barkodnoBox.TextChanged += new System.EventHandler(this.kitapnoBox_TextChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(283, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 283);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(777, 366);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(156, 23);
            this.silBtn.TabIndex = 38;
            this.silBtn.Text = "Sil ";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Kitap Ara:";
            // 
            // kitaparaBox
            // 
            this.kitaparaBox.Location = new System.Drawing.Point(444, 25);
            this.kitaparaBox.Name = "kitaparaBox";
            this.kitaparaBox.Size = new System.Drawing.Size(132, 20);
            this.kitaparaBox.TabIndex = 43;
            this.kitaparaBox.TextChanged += new System.EventHandler(this.kitaparaBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Açıklama:";
            // 
            // aciklamaBox
            // 
            this.aciklamaBox.Location = new System.Drawing.Point(98, 282);
            this.aciklamaBox.Multiline = true;
            this.aciklamaBox.Name = "aciklamaBox";
            this.aciklamaBox.Size = new System.Drawing.Size(161, 78);
            this.aciklamaBox.TabIndex = 45;
            // 
            // kitaplist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(961, 403);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aciklamaBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.kitaparaBox);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.iptalBtn);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rafnoBox);
            this.Controls.Add(this.sayfasayisiBox);
            this.Controls.Add(this.yazarBox);
            this.Controls.Add(this.kitapadiBox);
            this.Controls.Add(this.barkodnoBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "kitaplist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Arama - Listeleme - Güncelleme - Silme | Kütüphane";
            this.Load += new System.EventHandler(this.kitaplist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button iptalBtn;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rafnoBox;
        private System.Windows.Forms.TextBox sayfasayisiBox;
        private System.Windows.Forms.TextBox yazarBox;
        private System.Windows.Forms.TextBox kitapadiBox;
        private System.Windows.Forms.TextBox barkodnoBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox kitaparaBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox aciklamaBox;
    }
}