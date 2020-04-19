namespace bilgisayarhastanesiperformans
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.girisbutonsf1 = new System.Windows.Forms.Button();
            this.kayıtolbutonsf1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sifretextbox = new System.Windows.Forms.TextBox();
            this.kullaniciaditextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // girisbutonsf1
            // 
            this.girisbutonsf1.Location = new System.Drawing.Point(414, 236);
            this.girisbutonsf1.Name = "girisbutonsf1";
            this.girisbutonsf1.Size = new System.Drawing.Size(75, 23);
            this.girisbutonsf1.TabIndex = 0;
            this.girisbutonsf1.Text = "GİRİŞ";
            this.girisbutonsf1.UseVisualStyleBackColor = true;
            this.girisbutonsf1.Click += new System.EventHandler(this.girisbutonsf1_Click);
            // 
            // kayıtolbutonsf1
            // 
            this.kayıtolbutonsf1.Location = new System.Drawing.Point(495, 236);
            this.kayıtolbutonsf1.Name = "kayıtolbutonsf1";
            this.kayıtolbutonsf1.Size = new System.Drawing.Size(75, 23);
            this.kayıtolbutonsf1.TabIndex = 1;
            this.kayıtolbutonsf1.Text = "KAYIT OL";
            this.kayıtolbutonsf1.UseVisualStyleBackColor = true;
            this.kayıtolbutonsf1.Click += new System.EventHandler(this.kayıtolbutonsf1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "KULLANICI ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ŞİFRE";
            // 
            // sifretextbox
            // 
            this.sifretextbox.Location = new System.Drawing.Point(329, 195);
            this.sifretextbox.Name = "sifretextbox";
            this.sifretextbox.Size = new System.Drawing.Size(100, 20);
            this.sifretextbox.TabIndex = 4;
            this.sifretextbox.TextChanged += new System.EventHandler(this.sifretextbox_TextChanged);
            // 
            // kullaniciaditextbox
            // 
            this.kullaniciaditextbox.Location = new System.Drawing.Point(329, 149);
            this.kullaniciaditextbox.Name = "kullaniciaditextbox";
            this.kullaniciaditextbox.Size = new System.Drawing.Size(100, 20);
            this.kullaniciaditextbox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kullaniciaditextbox);
            this.Controls.Add(this.sifretextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kayıtolbutonsf1);
            this.Controls.Add(this.girisbutonsf1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisbutonsf1;
        private System.Windows.Forms.Button kayıtolbutonsf1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifretextbox;
        private System.Windows.Forms.TextBox kullaniciaditextbox;
    }
}

