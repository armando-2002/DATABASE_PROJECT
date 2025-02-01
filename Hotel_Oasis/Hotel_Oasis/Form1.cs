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
    public partial class Form1 : Form
    {
        // Definición de usuario y contraseña válidos
        private readonly string usuarioValido = "admin";
        private readonly string contrasenaValida = "admin";
        private int intentosFallidos = 0;
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.White);
            txtContraseña.PasswordChar = '*';

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Obtener los valores de usuario y contraseña
            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;

            //Validar usuario y contraseña
            ////if (ValidarUsuario(usuario, contrasena))
           //// {
                //Si las credenciales son correctas, abrir la siguiente ventana
                MessageBox.Show("Bienvenido a la aplicacion del Hotel Oasis");
                frmMenu nuevaVentana = new frmMenu();
                nuevaVentana.Show();
                this.Hide();  // Oculta la ventana de login
           ////// }
            ////else
            ////{
                // Si las credenciales no son correctas, mostrar mensaje de error
              /////  intentosFallidos++;

                //Si se exceden los 3 intentos fallidos, mostrar mensaje y cerrar la aplicación
                // if (intentosFallidos >= 3)
                /// {
                // MessageBox.Show("Ha excedido el número de intentos permitidos. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Application.Exit();  // Cierra la aplicación
                // }
                // else
                //{
                //Si los intentos fallidos son menores de 3, mostrar mensaje y permitir intentar de nuevo
                // MessageBox.Show($"Usuario o contraseña incorrectos. Intentos restantes: {3 - intentosFallidos}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //}
                // Crear una nueva instancia de Form2
                /////frmMenu nuevaVentana = new frmMenu();

                //// Mostrar la nueva ventana
                nuevaVentana.Show();
            }
        ///}

        private void btnContraseña_MouseUp(object sender, MouseEventArgs e)
        {
            txtContraseña.PasswordChar = '*'; // Oculta la contraseña
        
        }

        private void btnContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            txtContraseña.PasswordChar = '\0'; // Muestra la contraseña
        }
        //private bool ValidarUsuario(string usuario, string contrasena)
        //{
        //    // Validar si el usuario y la contraseña coinciden con los valores definidos
        //    return usuario == usuarioValido && contrasena == contrasenaValida;
        //}
    }
}
