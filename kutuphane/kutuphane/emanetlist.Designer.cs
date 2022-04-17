namespace kutuphane
{
    partial class emanetlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emanetlist));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emanetlisteleBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cikisBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(964, 402);
            this.dataGridView1.TabIndex = 66;
            // 
            // emanetlisteleBox
            // 
            this.emanetlisteleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emanetlisteleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emanetlisteleBox.FormattingEnabled = true;
            this.emanetlisteleBox.Items.AddRange(new object[] {
            "Tüm Kitaplar",
            "Geciken Kitaplar",
            "Gecikmeyen Kitaplar"});
            this.emanetlisteleBox.Location = new System.Drawing.Point(424, 27);
            this.emanetlisteleBox.Name = "emanetlisteleBox";
            this.emanetlisteleBox.Size = new System.Drawing.Size(193, 21);
            this.emanetlisteleBox.TabIndex = 67;
            this.emanetlisteleBox.SelectedIndexChanged += new System.EventHandler(this.emanetlisteleBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Filtrele:";
            // 
            // cikisBtn
            // 
            this.cikisBtn.Location = new System.Drawing.Point(904, 472);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(72, 26);
            this.cikisBtn.TabIndex = 69;
            this.cikisBtn.Text = "Çıkış";
            this.cikisBtn.UseVisualStyleBackColor = true;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // emanetlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(988, 510);
            this.Controls.Add(this.cikisBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emanetlisteleBox);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "emanetlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Kitap Listele | Kütüphane";
            this.Load += new System.EventHandler(this.emanelist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox emanetlisteleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cikisBtn;
    }
}