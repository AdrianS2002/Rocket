using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racheta_Schiop_Adrian
{
    public partial class Generic : Form
    {
        public Generic()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.ShowDialog();
        }

        private void btn_iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
