namespace bilgisayarhastanesiperformans
{
    partial class giris
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
            this.durumbutonu = new System.Windows.Forms.Button();
            this.kisiselbilgibuton = new System.Windows.Forms.Button();
            this.iletisimbuton = new System.Windows.Forms.Button();
            this.g1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // durumbutonu
            // 
            this.durumbutonu.Location = new System.Drawing.Point(174, 208);
            this.durumbutonu.Name = "durumbutonu";
            this.durumbutonu.Size = new System.Drawing.Size(75, 23);
            this.durumbutonu.TabIndex = 0;
            this.durumbutonu.Text = "DURUM";
            this.durumbutonu.UseVisualStyleBackColor = true;
            this.durumbutonu.Click += new System.EventHandler(this.durumbutonu_Click);
            // 
            // kisiselbilgibuton
            // 
            this.kisiselbilgibuton.Location = new System.Drawing.Point(343, 208);
            this.kisiselbilgibuton.Name = "kisiselbilgibuton";
            this.kisiselbilgibuton.Size = new System.Drawing.Size(75, 23);
            this.kisiselbilgibuton.TabIndex = 1;
            this.kisiselbilgibuton.Text = "KİSİSEL.B";
            this.kisiselbilgibuton.UseVisualStyleBackColor = true;
            this.kisiselbilgibuton.Click += new System.EventHandler(this.kisiselbilgibuton_Click);
            // 
            // iletisimbuton
            // 
            this.iletisimbuton.Location = new System.Drawing.Point(510, 208);
            this.iletisimbuton.Name = "iletisimbuton";
            this.iletisimbuton.Size = new System.Drawing.Size(75, 23);
            this.iletisimbuton.TabIndex = 2;
            this.iletisimbuton.Text = "İLETİŞİM";
            this.iletisimbuton.UseVisualStyleBackColor = true;
            this.iletisimbuton.Click += new System.EventHandler(this.iletisimbuton_Click);
            // 
            // g1
            // 
            this.g1.Location = new System.Drawing.Point(12, 12);
            this.g1.Name = "g1";
            this.g1.Size = new System.Drawing.Size(75, 23);
            this.g1.TabIndex = 7;
            this.g1.Text = "GERİ DÖN";
            this.g1.UseVisualStyleBackColor = true;
            this.g1.Click += new System.EventHandler(this.g1_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.g1);
            this.Controls.Add(this.iletisimbuton);
            this.Controls.Add(this.kisiselbilgibuton);
            this.Controls.Add(this.durumbutonu);
            this.Name = "giris";
            this.Text = "giris";
            this.Load += new System.EventHandler(this.giris_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button durumbutonu;
        private System.Windows.Forms.Button kisiselbilgibuton;
        private System.Windows.Forms.Button iletisimbuton;
        private System.Windows.Forms.Button g1;
    }
}