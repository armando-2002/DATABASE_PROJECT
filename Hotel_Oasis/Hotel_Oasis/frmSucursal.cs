using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Oasis
{
    public partial class frmSucursal : Form
    {
        public frmSucursal()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, Color.White);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
