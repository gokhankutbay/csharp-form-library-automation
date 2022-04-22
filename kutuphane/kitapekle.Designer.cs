namespace kutuphane
{
    partial class kitapekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapekle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.iptalBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.barkodnoBox = new System.Windows.Forms.TextBox();
            this.kitapadiBox = new System.Windows.Forms.TextBox();
            this.yazarBox = new System.Windows.Forms.TextBox();
            this.sayfasayisiBox = new System.Windows.Forms.TextBox();
            this.rafnoBox = new System.Windows.Forms.TextBox();
            this.aciklamaBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yazarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sayfa Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Raf No:";
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(127, 311);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(75, 23);
            this.ekleBtn.TabIndex = 8;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // iptalBtn
            // 
            this.iptalBtn.Location = new System.Drawing.Point(254, 311);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(75, 23);
            this.iptalBtn.TabIndex = 9;
            this.iptalBtn.Text = "İptal";
            this.iptalBtn.UseVisualStyleBackColor = true;
            this.iptalBtn.Click += new System.EventHandler(this.iptalBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Barkod No:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // barkodnoBox
            // 
            this.barkodnoBox.Location = new System.Drawing.Point(127, 44);
            this.barkodnoBox.Name = "barkodnoBox";
            this.barkodnoBox.Size = new System.Drawing.Size(202, 20);
            this.barkodnoBox.TabIndex = 12;
            // 
            // kitapadiBox
            // 
            this.kitapadiBox.Location = new System.Drawing.Point(127, 84);
            this.kitapadiBox.Name = "kitapadiBox";
            this.kitapadiBox.Size = new System.Drawing.Size(202, 20);
            this.kitapadiBox.TabIndex = 13;
            // 
            // yazarBox
            // 
            this.yazarBox.Location = new System.Drawing.Point(127, 124);
            this.yazarBox.Name = "yazarBox";
            this.yazarBox.Size = new System.Drawing.Size(202, 20);
            this.yazarBox.TabIndex = 14;
            // 
            // sayfasayisiBox
            // 
            this.sayfasayisiBox.Location = new System.Drawing.Point(127, 164);
            this.sayfasayisiBox.Name = "sayfasayisiBox";
            this.sayfasayisiBox.Size = new System.Drawing.Size(202, 20);
            this.sayfasayisiBox.TabIndex = 15;
            // 
            // rafnoBox
            // 
            this.rafnoBox.Location = new System.Drawing.Point(127, 204);
            this.rafnoBox.Name = "rafnoBox";
            this.rafnoBox.Size = new System.Drawing.Size(202, 20);
            this.rafnoBox.TabIndex = 16;
            // 
            // aciklamaBox
            // 
            this.aciklamaBox.Location = new System.Drawing.Point(127, 244);
            this.aciklamaBox.Multiline = true;
            this.aciklamaBox.Name = "aciklamaBox";
            this.aciklamaBox.Size = new System.Drawing.Size(202, 57);
            this.aciklamaBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Açıklama:";
            // 
            // kitapekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(413, 396);
            this.Controls.Add(this.aciklamaBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rafnoBox);
            this.Controls.Add(this.sayfasayisiBox);
            this.Controls.Add(this.yazarBox);
            this.Controls.Add(this.kitapadiBox);
            this.Controls.Add(this.barkodnoBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iptalBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "kitapekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekle | İmtal Kütüphanesi";
            this.Load += new System.EventHandler(this.kitapekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button iptalBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox barkodnoBox;
        private System.Windows.Forms.TextBox kitapadiBox;
        private System.Windows.Forms.TextBox yazarBox;
        private System.Windows.Forms.TextBox sayfasayisiBox;
        private System.Windows.Forms.TextBox rafnoBox;
        private System.Windows.Forms.TextBox aciklamaBox;
        private System.Windows.Forms.Label label6;
    }
}