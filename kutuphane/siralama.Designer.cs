﻿namespace kutuphane
{
    partial class siralama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siralama));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.encokokuyanLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.enazokuyanLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(964, 402);
            this.dataGridView1.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "En Çok Kitap Okuyan Üye:";
            // 
            // encokokuyanLbl
            // 
            this.encokokuyanLbl.AutoSize = true;
            this.encokokuyanLbl.Location = new System.Drawing.Point(537, 21);
            this.encokokuyanLbl.Name = "encokokuyanLbl";
            this.encokokuyanLbl.Size = new System.Drawing.Size(35, 13);
            this.encokokuyanLbl.TabIndex = 69;
            this.encokokuyanLbl.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "En Az Kitap Okuyan Üye:";
            // 
            // enazokuyanLbl
            // 
            this.enazokuyanLbl.AutoSize = true;
            this.enazokuyanLbl.Location = new System.Drawing.Point(537, 48);
            this.enazokuyanLbl.Name = "enazokuyanLbl";
            this.enazokuyanLbl.Size = new System.Drawing.Size(35, 13);
            this.enazokuyanLbl.TabIndex = 71;
            this.enazokuyanLbl.Text = "label4";
            // 
            // siralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1099, 518);
            this.Controls.Add(this.enazokuyanLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encokokuyanLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "siralama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sıralama | İmtal Kütüphanesi";
            this.Load += new System.EventHandler(this.siralama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label encokokuyanLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label enazokuyanLbl;

    }
}