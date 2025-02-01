using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Oasis
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125,Color.White);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEmpleados em= new frmEmpleados();
            em.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmClientes cli= new frmClientes();
            cli.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmHabitacion hab=  new frmHabitacion();
            hab.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmReservas re= new frmReservas();
            re.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmServicio ser= new frmServicio();
            ser.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmServiciosAdicionales serad= new frmServiciosAdicionales();
            serad.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmSucursal su= new frmSucursal();  
             su.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Para cerrr completamente:
            Application.Exit();
        }
    }
}
