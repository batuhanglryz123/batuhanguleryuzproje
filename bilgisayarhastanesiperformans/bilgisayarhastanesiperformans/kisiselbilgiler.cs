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
    public partial class kisiselbilgiler : Form
    {
        public kisiselbilgiler()
        {
            InitializeComponent();
        }
        SqlConnection yasuo = new SqlConnection("Data Source=DESKTOP-38MI85D\\SQLEXPRESS;Initial Catalog=bilgisayar_hastanesi;Integrated Security=True");

        void SIRALA()
        {
            yasuo.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From giristablo ", yasuo);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridkisisel.DataSource = ds.Tables[0];
            yasuo.Close();
        }
        private void kisiselbilgiler_Load(object sender, EventArgs e)
        {

            SIRALA();

        }

        private void kisiselbilgilerdegistir_Click(object sender, EventArgs e)
        {
            yasuo.Open();
            string query = "Update giristablo Set tc='" + kisiseltc.Text + "',kullanıcı_adı='" + kisiseladsoyad.Text + "',sifre='" + kisiselsifre.Text + "',tel='" + kisiseltel.Text + "',mail='" + kisiselmail.Text + "',kısa_adres='" + kisiseladres.Text + "'WHERE ıd='" + kisiselid.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, yasuo);
            SDA.SelectCommand.ExecuteNonQuery();
            yasuo.Close();
            SIRALA();
        }

        private void dataGridkisisel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dayana = dataGridkisisel.SelectedCells[0].RowIndex;
            string numara = dataGridkisisel.Rows[dayana].Cells[0].Value.ToString();
            string numara1 = dataGridkisisel.Rows[dayana].Cells[1].Value.ToString();
            string numara2 = dataGridkisisel.Rows[dayana].Cells[2].Value.ToString();
            string numara3 = dataGridkisisel.Rows[dayana].Cells[3].Value.ToString();
            string numara4 = dataGridkisisel.Rows[dayana].Cells[4].Value.ToString();
            string numara5 = dataGridkisisel.Rows[dayana].Cells[5].Value.ToString();
            string numara6 = dataGridkisisel.Rows[dayana].Cells[6].Value.ToString();

            kisiselid.Text = numara;
            kisiseladsoyad.Text = numara1;
            kisiseltc.Text = numara2;
            kisiseltel.Text = numara3;
            kisiselmail.Text = numara4;
            kisiselsifre.Text = numara5;
            kisiseladres.Text = numara6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yasuo.Open();
            string quary = "delete from giristablo where ıd='" + kisiselid.Text + "'";
            SqlDataAdapter sd = new SqlDataAdapter(quary, yasuo);
            sd.SelectCommand.ExecuteNonQuery();
            yasuo.Close();
            SIRALA();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            giris ss = new giris();
            ss.Show();
        }

        private void kisiseltc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void kisiseltel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
