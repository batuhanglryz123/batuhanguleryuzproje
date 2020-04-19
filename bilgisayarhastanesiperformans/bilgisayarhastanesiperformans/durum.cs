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
    public partial class durum : Form
    {
        public durum()
        {
            InitializeComponent();
        }
        SqlConnection yasuo = new SqlConnection("Data Source=DESKTOP-38MI85D\\SQLEXPRESS;Initial Catalog=bilgisayar_hastanesi;Integrated Security=True");
        void SIRALA()
        {
            yasuo.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From bilgisayar_durum ", yasuo);
            DataSet ds = new DataSet();
            da.Fill(ds);
            datagriddurum.DataSource = ds.Tables[0];
            yasuo.Close();
        }
        private void durum_Load(object sender, EventArgs e)
        {
            int a;
            string cnstr = "Data Source=DESKTOP-38MI85D\\SQLEXPRESS;Initial Catalog=bilgisayar_hastanesi;Integrated Security=True";
            SqlConnection con = new SqlConnection(cnstr);
            con.Open();
            string query = "select Max(Cast(bilgisayar_id as Int)) from bilgisayar_durum";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    pcid.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;

                    pcid.Text = a.ToString();
                }
                SIRALA();
            }

        }

        private void bilgisayarbuton_Click(object sender, EventArgs e)
        {
            yasuo.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from bilgisayar_durum  Where bilgisayar_id='" + bilgisayariddurum.Text.ToString() + "'", yasuo);
            DataSet ds = new DataSet();
            da.Fill(ds);
            datagriddurum.DataSource = ds.Tables[0];
            yasuo.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            yasuo.Open();
            string x = "INSERT INTO bilgisayar_durum(bilgisayar_id,arızalı_parça,parça_durum,teslim_tarihi) VALUES('" + pcid.Text + "','" + ap.Text + "','" + pd.Text + "','" + dateTimePicker1.Text.ToString() + "')";
            SqlDataAdapter a = new SqlDataAdapter(x, yasuo);
            a.SelectCommand.ExecuteNonQuery();
            yasuo.Close();
            this.Hide();
            durum b = new durum();
            b.ShowDialog();

            SIRALA();
        }

        private void datagriddurum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dayana = datagriddurum.SelectedCells[0].RowIndex;
                string numara = datagriddurum.Rows[dayana].Cells[0].Value.ToString();
            string numara1 = datagriddurum.Rows[dayana].Cells[1].Value.ToString();
            string numara2 = datagriddurum.Rows[dayana].Cells[2].Value.ToString();
            string numara3 = datagriddurum.Rows[dayana].Cells[3].Value.ToString();
            pcid.Text = numara;
            ap.Text = numara1;
            pd.Text = numara2;
            


        }

        private void bilgisayariddurum_TextChanged(object sender, EventArgs e)
        {

        }

        private void durumdegistir_Click(object sender, EventArgs e)
        {
            yasuo.Open();
            string query = "Update bilgisayar_durum Set arızalı_parça='" + ap.Text + "',parça_durum='" + pd.Text + "',teslim_tarihi='" + dateTimePicker1.Text +  "'WHERE bilgisayar_id='" + pcid.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, yasuo);
            SDA.SelectCommand.ExecuteNonQuery();
            yasuo.Close();
            SIRALA();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           giris ss = new giris();
            ss.Show();
        }
    }
}
