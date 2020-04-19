using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgisayarhastanesiperformans
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void durumbutonu_Click(object sender, EventArgs e)
        {
            this.Hide();
            durum ss = new durum();
            ss.Show();
        }

        private void kisiselbilgibuton_Click(object sender, EventArgs e)
        {
            this.Hide();
            kisiselbilgiler ss = new kisiselbilgiler();
            ss.Show();
        }

        private void iletisimbuton_Click(object sender, EventArgs e)
        {
            this.Hide();
            iletisim ss = new iletisim();
            ss.Show();
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void g1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }
    }
}
