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
    public partial class frmReservas : Form
    {
        public frmReservas()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, Color.White);
            //lblIDCliente.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
