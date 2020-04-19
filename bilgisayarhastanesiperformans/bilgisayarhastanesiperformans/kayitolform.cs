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
    public partial class kayitolform : Form
    {
        public kayitolform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-38MI85D\\SQLEXPRESS;Initial Catalog=bilgisayar_hastanesi;Integrated Security=True");
        private void kayıtformtamam_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string x = "INSERT INTO giristablo(ıd,kullanıcı_adı,sifre,tc,tel,mail,kısa_adres) VALUES('" + Idtext.Text + "','" + kayıtformadsoyad.Text + "','" + kayıtformsifre.Text + "','" + kayıtformtc.Text + "','" + kayıtformtel.Text + "','" + kayıtformmail.Text + "','" + kayıtformkadres.Text + "')";
            SqlDataAdapter a = new SqlDataAdapter(x, baglanti);
            a.SelectCommand.ExecuteNonQuery();
            baglanti.Close();
            this.Hide();
            kayitolform c = new kayitolform();
            c.ShowDialog();
        }

        private void kayitolform_Load(object sender, EventArgs e)
        {
            int a;
            string cnstr = "Data Source=DESKTOP-38MI85D\\SQLEXPRESS;Initial Catalog=bilgisayar_hastanesi;Integrated Security=True";
            SqlConnection con = new SqlConnection(cnstr);
            con.Open();
            string query = "select Max(Cast(ıd as Int)) from giristablo";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    Idtext.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;

                    Idtext.Text = a.ToString();
                }
            }
    }
    }
}
