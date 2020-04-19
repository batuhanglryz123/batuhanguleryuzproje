namespace bilgisayarhastanesiperformans
{
    partial class durum
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
            this.label1 = new System.Windows.Forms.Label();
            this.bilgisayariddurum = new System.Windows.Forms.TextBox();
            this.datagriddurum = new System.Windows.Forms.DataGridView();
            this.bilgisayarbuton = new System.Windows.Forms.Button();
            this.pcid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pd = new System.Windows.Forms.TextBox();
            this.ap = new System.Windows.Forms.TextBox();
            this.ekle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.durumdegistir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagriddurum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İD ARA";
            // 
            // bilgisayariddurum
            // 
            this.bilgisayariddurum.Location = new System.Drawing.Point(397, 42);
            this.bilgisayariddurum.Name = "bilgisayariddurum";
            this.bilgisayariddurum.Size = new System.Drawing.Size(100, 20);
            this.bilgisayariddurum.TabIndex = 1;
            this.bilgisayariddurum.TextChanged += new System.EventHandler(this.bilgisayariddurum_TextChanged);
            // 
            // datagriddurum
            // 
            this.datagriddurum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagriddurum.Location = new System.Drawing.Point(307, 68);
            this.datagriddurum.Name = "datagriddurum";
            this.datagriddurum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagriddurum.Size = new System.Drawing.Size(332, 332);
            this.datagriddurum.TabIndex = 2;
            this.datagriddurum.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagriddurum_CellClick);
            // 
            // bilgisayarbuton
            // 
            this.bilgisayarbuton.Location = new System.Drawing.Point(523, 40);
            this.bilgisayarbuton.Name = "bilgisayarbuton";
            this.bilgisayarbuton.Size = new System.Drawing.Size(75, 23);
            this.bilgisayarbuton.TabIndex = 3;
            this.bilgisayarbuton.Text = "GÖSTER";
            this.bilgisayarbuton.UseVisualStyleBackColor = true;
            this.bilgisayarbuton.Click += new System.EventHandler(this.bilgisayarbuton_Click);
            // 
            // pcid
            // 
            this.pcid.Location = new System.Drawing.Point(170, 100);
            this.pcid.Name = "pcid";
            this.pcid.Size = new System.Drawing.Size(100, 20);
            this.pcid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bilgisayar_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "teslim tarih";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "parça durum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "arızalı parça";
            // 
            // pd
            // 
            this.pd.Location = new System.Drawing.Point(170, 152);
            this.pd.Name = "pd";
            this.pd.Size = new System.Drawing.Size(100, 20);
            this.pd.TabIndex = 10;
            // 
            // ap
            // 
            this.ap.Location = new System.Drawing.Point(170, 126);
            this.ap.Name = "ap";
            this.ap.Size = new System.Drawing.Size(100, 20);
            this.ap.TabIndex = 11;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(195, 217);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 23);
            this.ekle.TabIndex = 12;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // durumdegistir
            // 
            this.durumdegistir.Location = new System.Drawing.Point(114, 217);
            this.durumdegistir.Name = "durumdegistir";
            this.durumdegistir.Size = new System.Drawing.Size(75, 23);
            this.durumdegistir.TabIndex = 14;
            this.durumdegistir.Text = "DEĞİŞTİR";
            this.durumdegistir.UseVisualStyleBackColor = true;
            this.durumdegistir.Click += new System.EventHandler(this.durumdegistir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "GERİ DÖN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // durum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.durumdegistir);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.ap);
            this.Controls.Add(this.pd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcid);
            this.Controls.Add(this.bilgisayarbuton);
            this.Controls.Add(this.datagriddurum);
            this.Controls.Add(this.bilgisayariddurum);
            this.Controls.Add(this.label1);
            this.Name = "durum";
            this.Text = "durum";
            this.Load += new System.EventHandler(this.durum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagriddurum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bilgisayariddurum;
        private System.Windows.Forms.DataGridView datagriddurum;
        private System.Windows.Forms.Button bilgisayarbuton;
        private System.Windows.Forms.TextBox pcid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pd;
        private System.Windows.Forms.TextBox ap;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button durumdegistir;
        private System.Windows.Forms.Button button1;
    }
}