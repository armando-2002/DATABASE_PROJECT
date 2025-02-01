using Hotel_Oasis.Config;
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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
            //label1.BackColor = Color.FromArgb(125, Color.White);
            panel1.BackColor = Color.FromArgb(100, Color.White);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            conexion.Conectar();
            //dgvc.DataSource = index();
           // MostrarTodosLosDatos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            //Para cerrr completamente:
            //Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
