using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace bilgisayarhastanesiperformans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        private void girisbutonsf1_Click(object sender, EventArgs e)
        {
            string a = kullaniciaditextbox.Text;
            string b = sifretextbox.Text;
            con = new SqlConnection("Data Source=DESKTOP-38MI85D\\SQLEXPRESS;Initial Catalog=bilgisayar_hastanesi;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM giristablo where kullanıcı_adı='" + kullaniciaditextbox.Text + "' AND sifre='" + sifretextbox.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                giris ss = new giris();
                ss.ShowDialog();
            }
            else
            {
                MessageBox.Show("yanlış giriş.");
            }
            con.Close();

            

        }

        private void kayıtolbutonsf1_Click(object sender, EventArgs e)
        {
            this.Hide();
            kayitolform ss = new kayitolform();
            ss.Show();
        }

        private void sifretextbox_TextChanged(object sender, EventArgs e)
        {
            sifretextbox.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void g1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
