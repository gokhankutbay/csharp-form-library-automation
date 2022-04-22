namespace kutuphane
{
    partial class emanetiade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emanetiade));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.teslimalBtn = new System.Windows.Forms.Button();
            this.cikisBtn = new System.Windows.Forms.Button();
            this.tcaraBox = new System.Windows.Forms.TextBox();
            this.barkodnoaraBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(951, 396);
            this.dataGridView1.TabIndex = 0;
            // 
            // teslimalBtn
            // 
            this.teslimalBtn.Location = new System.Drawing.Point(796, 459);
            this.teslimalBtn.Name = "teslimalBtn";
            this.teslimalBtn.Size = new System.Drawing.Size(75, 23);
            this.teslimalBtn.TabIndex = 1;
            this.teslimalBtn.Text = "Teslim Al";
            this.teslimalBtn.UseVisualStyleBackColor = true;
            this.teslimalBtn.Click += new System.EventHandler(this.teslimalBtn_Click);
            // 
            // cikisBtn
            // 
            this.cikisBtn.Location = new System.Drawing.Point(888, 459);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(75, 23);
            this.cikisBtn.TabIndex = 2;
            this.cikisBtn.Text = "Çıkış";
            this.cikisBtn.UseVisualStyleBackColor = true;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // tcaraBox
            // 
            this.tcaraBox.Location = new System.Drawing.Point(355, 22);
            this.tcaraBox.Name = "tcaraBox";
            this.tcaraBox.Size = new System.Drawing.Size(100, 20);
            this.tcaraBox.TabIndex = 3;
            this.tcaraBox.TextChanged += new System.EventHandler(this.tcaraBox_TextChanged);
            // 
            // barkodnoaraBox
            // 
            this.barkodnoaraBox.Location = new System.Drawing.Point(616, 22);
            this.barkodnoaraBox.Name = "barkodnoaraBox";
            this.barkodnoaraBox.Size = new System.Drawing.Size(100, 20);
            this.barkodnoaraBox.TabIndex = 4;
            this.barkodnoaraBox.TextChanged += new System.EventHandler(this.barkodnoaraBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TC\'ye göre ara:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Barkod No\'ya göre ara:";
            // 
            // emanetiade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(975, 517);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barkodnoaraBox);
            this.Controls.Add(this.tcaraBox);
            this.Controls.Add(this.cikisBtn);
            this.Controls.Add(this.teslimalBtn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "emanetiade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet İade | İmtal Kütüphanesi";
            this.Load += new System.EventHandler(this.emanetiade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button teslimalBtn;
        private System.Windows.Forms.Button cikisBtn;
        private System.Windows.Forms.TextBox tcaraBox;
        private System.Windows.Forms.TextBox barkodnoaraBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}