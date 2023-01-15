using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class StokArama : Form
    {
        public StokArama()
        {
            InitializeComponent();
        }

        private void StokArama_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StokEkle fr2 = new StokEkle();
            fr2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StokSil fr3 = new StokSil();
            fr3.ShowDialog();
        }
    }
}
