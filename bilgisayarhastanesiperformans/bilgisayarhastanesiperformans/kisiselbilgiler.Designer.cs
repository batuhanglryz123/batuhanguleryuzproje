namespace bilgisayarhastanesiperformans
{
    partial class kisiselbilgiler
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
            this.kisiselbilgilerdegistir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridkisisel = new System.Windows.Forms.DataGridView();
            this.kisiselsifre = new System.Windows.Forms.TextBox();
            this.kisiselmail = new System.Windows.Forms.TextBox();
            this.kisiseltel = new System.Windows.Forms.TextBox();
            this.kisiseltc = new System.Windows.Forms.TextBox();
            this.kisiseladsoyad = new System.Windows.Forms.TextBox();
            this.kisiselid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.kisiseladres = new System.Windows.Forms.TextBox();
            this.silbutonu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridkisisel)).BeginInit();
            this.SuspendLayout();
            // 
            // kisiselbilgilerdegistir
            // 
            this.kisiselbilgilerdegistir.Location = new System.Drawing.Point(177, 323);
            this.kisiselbilgilerdegistir.Name = "kisiselbilgilerdegistir";
            this.kisiselbilgilerdegistir.Size = new System.Drawing.Size(75, 23);
            this.kisiselbilgilerdegistir.TabIndex = 14;
            this.kisiselbilgilerdegistir.Text = "DEĞİŞTİR";
            this.kisiselbilgilerdegistir.UseVisualStyleBackColor = true;
            this.kisiselbilgilerdegistir.Click += new System.EventHandler(this.kisiselbilgilerdegistir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "KİSİSEL BİLGİLER";
            // 
            // dataGridkisisel
            // 
            this.dataGridkisisel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridkisisel.Location = new System.Drawing.Point(270, 86);
            this.dataGridkisisel.Name = "dataGridkisisel";
            this.dataGridkisisel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridkisisel.Size = new System.Drawing.Size(300, 309);
            this.dataGridkisisel.TabIndex = 16;
            this.dataGridkisisel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridkisisel_CellContentClick);
            this.dataGridkisisel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridkisisel_CellContentClick);
            // 
            // kisiselsifre
            // 
            this.kisiselsifre.Location = new System.Drawing.Point(138, 274);
            this.kisiselsifre.Name = "kisiselsifre";
            this.kisiselsifre.Size = new System.Drawing.Size(100, 20);
            this.kisiselsifre.TabIndex = 17;
            // 
            // kisiselmail
            // 
            this.kisiselmail.Location = new System.Drawing.Point(138, 248);
            this.kisiselmail.Name = "kisiselmail";
            this.kisiselmail.Size = new System.Drawing.Size(100, 20);
            this.kisiselmail.TabIndex = 18;
            // 
            // kisiseltel
            // 
            this.kisiseltel.Location = new System.Drawing.Point(138, 222);
            this.kisiseltel.Name = "kisiseltel";
            this.kisiseltel.Size = new System.Drawing.Size(100, 20);
            this.kisiseltel.TabIndex = 19;
            this.kisiseltel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kisiseltel_KeyPress);
            // 
            // kisiseltc
            // 
            this.kisiseltc.Location = new System.Drawing.Point(138, 196);
            this.kisiseltc.Name = "kisiseltc";
            this.kisiseltc.Size = new System.Drawing.Size(100, 20);
            this.kisiseltc.TabIndex = 20;
            this.kisiseltc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kisiseltc_KeyPress);
            // 
            // kisiseladsoyad
            // 
            this.kisiseladsoyad.Location = new System.Drawing.Point(138, 170);
            this.kisiseladsoyad.Name = "kisiseladsoyad";
            this.kisiseladsoyad.Size = new System.Drawing.Size(100, 20);
            this.kisiseladsoyad.TabIndex = 21;
            // 
            // kisiselid
            // 
            this.kisiselid.Location = new System.Drawing.Point(138, 144);
            this.kisiselid.Name = "kisiselid";
            this.kisiselid.Size = new System.Drawing.Size(100, 20);
            this.kisiselid.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "KISA ADRES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "ŞİFRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "MAİL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "TEL NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "TC.KİMLİK.NO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "ADI-SOYADI";
            // 
            // kisiseladres
            // 
            this.kisiseladres.Location = new System.Drawing.Point(138, 297);
            this.kisiseladres.Name = "kisiseladres";
            this.kisiseladres.Size = new System.Drawing.Size(100, 20);
            this.kisiseladres.TabIndex = 30;
            // 
            // silbutonu
            // 
            this.silbutonu.Location = new System.Drawing.Point(177, 352);
            this.silbutonu.Name = "silbutonu";
            this.silbutonu.Size = new System.Drawing.Size(75, 23);
            this.silbutonu.TabIndex = 31;
            this.silbutonu.Text = "SİL";
            this.silbutonu.UseVisualStyleBackColor = true;
            this.silbutonu.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "GERİ DÖN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // kisiselbilgiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.silbutonu);
            this.Controls.Add(this.kisiseladres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kisiselid);
            this.Controls.Add(this.kisiseladsoyad);
            this.Controls.Add(this.kisiseltc);
            this.Controls.Add(this.kisiseltel);
            this.Controls.Add(this.kisiselmail);
            this.Controls.Add(this.kisiselsifre);
            this.Controls.Add(this.dataGridkisisel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kisiselbilgilerdegistir);
            this.Name = "kisiselbilgiler";
            this.Text = "kisiselbilgiler";
            this.Load += new System.EventHandler(this.kisiselbilgiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridkisisel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kisiselbilgilerdegistir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridkisisel;
        private System.Windows.Forms.TextBox kisiselsifre;
        private System.Windows.Forms.TextBox kisiselmail;
        private System.Windows.Forms.TextBox kisiseltel;
        private System.Windows.Forms.TextBox kisiseltc;
        private System.Windows.Forms.TextBox kisiseladsoyad;
        private System.Windows.Forms.TextBox kisiselid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kisiseladres;
        private System.Windows.Forms.Button silbutonu;
        private System.Windows.Forms.Button button1;
    }
}