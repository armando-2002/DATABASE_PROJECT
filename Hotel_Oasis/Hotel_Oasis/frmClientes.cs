using Hotel_Oasis.Config;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Oasis
{
    public partial class frmClientes : Form
    {
        private bool mostrarClientesDatos = false;
        private bool mostrarClientesDescuento = false;
        public frmClientes()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, Color.White);
           // lblIDCliente.Text = "";
            txtId.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            conexion.Conectar();
            //dgvc.DataSource = index();
            MostrarTodosLosDatos();
            // Inicialmente, deshabilitar la selección de filas
            //dgvc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvc.MultiSelect = false; // Solo permitir seleccionar una fila
            //dgvc.Enabled = false;  // Asegurarse de que el DataGridView esté habilitado
        }

        //mostar los datos
        public DataTable index(string tabla)
        {

            //conexion.Conectar();
            //DataTable datatable = new DataTable();
            //string sql = "SELECT * FROM Clientes";
            //SqlCommand cmd = new SqlCommand(sql, conexion.Conectar());

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            //sqlDataAdapter.Fill(datatable);

            //return datatable;
            conexion.Conectar();
            DataTable datatable = new DataTable();
            string sql = "";
            if (string.IsNullOrEmpty(tabla))
            {
                throw new ArgumentException("El nombre de la tabla no puede estar vacio", nameof(tabla));
            }
            switch (tabla)
            {
                case "Clientes_completo":
                    sql = "SELECT C.id_cliente, C.nombre, C.apellido, C.telefono, C.correo, D.cliente_frecuente " +
                          "FROM Cliente_Datos C " +
                          "LEFT JOIN Cliente_Descuento D ON C.id_cliente = D.id_cliente";
                    break;

                case "Cliente_Datos":
                    sql = "SELECT id_cliente, nombre, apellido, telefono, correo FROM Cliente_Datos";
                    break;

                case "Cliente_Descuento":
                    sql = "SELECT id_cliente, cliente_frecuente FROM Cliente_Descuento";
                    break;

                default:
                    throw new ArgumentException($"Tabla'{tabla}'no valida",nameof(tabla));
            }

            SqlCommand cmd = new SqlCommand(sql, conexion.Conectar());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(datatable);

            return datatable;

        }
        //Insertar datos
        private void button3_Click(object sender, EventArgs e)
        {

            //bool esFrecuente = chkFrecuente.Checked;  // Obtén el valor del CheckBox

            //// Verificar si algún campo está vacío
            //if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            //    string.IsNullOrWhiteSpace(txtApellido.Text) ||
            //    string.IsNullOrWhiteSpace(txtCorreo.Text) ||
            //    string.IsNullOrWhiteSpace(txtTelefono.Text)) //||
            //    //string.IsNullOrEmpty(txtId.Text))
            //{
            //    MessageBox.Show("Por favor, completa todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;  // Salir de la función si algún campo está vacío
            //}

            //try
            //{
            //    conexion.Conectar();

            //    // Modificar el SQL para no insertar el campo id_cliente (lo maneja la base de datos)
            //    string SQL_Insert = "INSERT INTO Clientes (nombre, apellido, correo, telefono, cliente_frecuente) " +
            //                        "VALUES (@nombre, @apellido, @correo, @telefono, @cliente_frecuente)";
            //    SqlCommand cmd1 = new SqlCommand(SQL_Insert, conexion.Conectar());
            //    //cmd1.Parameters.AddWithValue("@id_cliente")
            //    cmd1.Parameters.AddWithValue("@nombre", txtNombre.Text);
            //    cmd1.Parameters.AddWithValue("@apellido", txtApellido.Text);
            //    cmd1.Parameters.AddWithValue("@correo", txtCorreo.Text);
            //    cmd1.Parameters.AddWithValue("@telefono", txtTelefono.Text);
            //    cmd1.Parameters.AddWithValue("@cliente_frecuente", esFrecuente);

            //    // Ejecutar el INSERT
            //    cmd1.ExecuteNonQuery();
            //    MessageBox.Show("Datos correctamente ingresados");

            //    // Recargar el DataGridView
            //    dgvc.DataSource = index("Clientes_completo");
            //}
            //catch (SqlException ex)
            //{
            //    // Si ocurre una excepción, mostrar el mensaje de error
            //    MessageBox.Show($"Error al registrar el cliente. Intenta nuevamente:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //bool esFrecuente = chkFrecuente.Checked;  // Obtén el valor del CheckBox

            //// Verificar si algún campo está vacío
            //if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            //    string.IsNullOrWhiteSpace(txtApellido.Text) ||
            //    string.IsNullOrWhiteSpace(txtCorreo.Text) ||
            //    string.IsNullOrWhiteSpace(txtTelefono.Text))
            //{
            //    MessageBox.Show("Por favor, completa todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;  // Salir de la función si algún campo está vacío
            //}

            //try
            //{
            //    conexion.Conectar();

            //    // Insertar en la tabla Cliente_Datos
            //    string SQL_InsertDatos = "INSERT INTO Cliente_Datos (nombre, apellido, correo, telefono) " +
            //                             "VALUES (@nombre, @apellido, @correo, @telefono)";
            //    SqlCommand cmd1 = new SqlCommand(SQL_InsertDatos, conexion.Conectar());
            //    cmd1.Parameters.AddWithValue("@nombre", txtNombre.Text);
            //    cmd1.Parameters.AddWithValue("@apellido", txtApellido.Text);
            //    cmd1.Parameters.AddWithValue("@correo", txtCorreo.Text);
            //    cmd1.Parameters.AddWithValue("@telefono", txtTelefono.Text);

            //    // Ejecutar el INSERT en Cliente_Datos
            //    cmd1.ExecuteNonQuery();

            //    // Insertar en la tabla Cliente_Descuento con cliente_frecuente
            //    string SQL_InsertDescuento = "INSERT INTO Cliente_Descuento (id_cliente, cliente_frecuente) " +
            //                                "VALUES ((SELECT TOP 1 id_cliente FROM Cliente_Datos ORDER BY id_cliente DESC), @cliente_frecuente)";
            //    SqlCommand cmd2 = new SqlCommand(SQL_InsertDescuento, conexion.Conectar());
            //    cmd2.Parameters.AddWithValue("@cliente_frecuente", esFrecuente);

            //    // Ejecutar el INSERT en Cliente_Descuento
            //    cmd2.ExecuteNonQuery();

            //    // Confirmar la transacción
            //    // transaction.Commit();

            //    MessageBox.Show("Datos correctamente ingresados");

            //    // Recargar el DataGridView
            //    dgvc.DataSource = index("Clientes_completo");
            //}

            //catch (Exception ex)
            //{
            //    // Si algo falla, revertir la transacción
            //    // transaction.Rollback();
            //    MessageBox.Show($"Error al registrar el cliente. Intenta nuevamente.:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            try
            {
                conexion.Conectar();

                // Insertar en la tabla Cliente_Datos (sin especificar id_cliente, ya que es generado automáticamente)
                string SQL_InsertDatos = "INSERT INTO Cliente_Datos (nombre, apellido, correo, telefono) " +
                                         "VALUES (@nombre, @apellido, @correo, @telefono)";
                SqlCommand cmd1 = new SqlCommand(SQL_InsertDatos, conexion.Conectar());
                cmd1.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd1.Parameters.AddWithValue("@apellido", txtApellido.Text);
                cmd1.Parameters.AddWithValue("@correo", txtCorreo.Text);
                cmd1.Parameters.AddWithValue("@telefono", txtTelefono.Text);

                // Ejecutar el INSERT en Cliente_Datos
                cmd1.ExecuteNonQuery();

                // Obtener el último id_cliente insertado (usando SCOPE_IDENTITY())
                string SQL_SelectId = "SELECT SCOPE_IDENTITY()";
                SqlCommand cmdId = new SqlCommand(SQL_SelectId, conexion.Conectar());
                int idCliente = Convert.ToInt32(cmdId.ExecuteScalar());

                // Insertar en la tabla Cliente_Descuento con cliente_frecuente
                string SQL_InsertDescuento = "INSERT INTO Cliente_Descuento (id_cliente, cliente_frecuente) " +
                                            "VALUES (@id_cliente, @cliente_frecuente)";
                SqlCommand cmd2 = new SqlCommand(SQL_InsertDescuento, conexion.Conectar());
                cmd2.Parameters.AddWithValue("@id_cliente", idCliente);
                cmd2.Parameters.AddWithValue("@cliente_frecuente", chkFrecuente.Checked);

                // Ejecutar el INSERT en Cliente_Descuento
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Datos correctamente ingresados");

                // Recargar el DataGridView
                dgvc.DataSource = index("Clientes_completo");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al registrar el cliente. Intenta nuevamente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        // Evento de selección de fila

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtNombre.Text) || 
            //    string.IsNullOrWhiteSpace(txtApellido.Text)||
            //    string.IsNullOrWhiteSpace(txtCorreo.Text)||
            //    string.
            //if (int.TryParse(lblIDCliente.Text, out int idCliente))
            if (int.TryParse(txtId.Text, out int idCliente))
            {
                try
                {
                    conexion.Conectar();

                    // Actualizar los datos en la base de datos
                    string SQL_Update = "UPDATE Clientes SET nombre=@nombre, apellido=@apellido, correo=@correo, telefono=@telefono, cliente_frecuente=@cliente_frecuente WHERE id_cliente=@id_cliente";
                    SqlCommand cmd2 = new SqlCommand(SQL_Update, conexion.Conectar());

                    // Asignar los valores de los campos de texto a los parámetros de la consulta
                    cmd2.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd2.Parameters.AddWithValue("@apellido", txtApellido.Text);
                    cmd2.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    cmd2.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmd2.Parameters.AddWithValue("@cliente_frecuente", chkFrecuente.Checked);
                    cmd2.Parameters.AddWithValue("@id_cliente", idCliente);  // Usar el ID del cliente

                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Datos actualizados correctamente");

                    // Actualizar el DataGridView para reflejar los cambios
                    dgvc.DataSource = index("Clientes_completo");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al actualizar el cliente,intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para actualizar.","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int idCliente))
            {
                // Mostrar una confirmación antes de eliminar
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?",
                                                      "Confirmación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Conectar a la base de datos
                        conexion.Conectar();

                        // Crear la consulta SQL de eliminación
                        string SQL_Delete = "DELETE FROM Clientes WHERE id_cliente=@id_cliente";
                        SqlCommand cmd = new SqlCommand(SQL_Delete, conexion.Conectar());
                        cmd.Parameters.AddWithValue("@id_cliente", idCliente);

                        // Ejecutar la consulta de eliminación
                        cmd.ExecuteNonQuery();

                        // Mostrar un mensaje de éxito
                        MessageBox.Show("Cliente eliminado correctamente.");

                        // Actualizar el DataGridView después de la eliminación
                        dgvc.DataSource = index("Clientes_completo");

                        // Limpiar los campos de texto
                        txtNombre.Clear();
                        txtApellido.Clear();
                        txtCorreo.Clear();
                        txtTelefono.Clear();
                        chkFrecuente.Checked = false;
                        // lblIDCliente.Text = ""; // Limpiar el ID del cliente
                        txtId.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el cliente,intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
            else
            {
                // Si no hay un cliente seleccionado
                MessageBox.Show("Por favor, selecciona un cliente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Evento para rellenar los campos de texto con los datos seleccionados


        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dgvc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvc.DataSource == index("Cliente_Datos") || dgvc.DataSource == index("Cliente_Descuento"))
            //{
            //    dgvc.ClearSelection();
            //    MessageBox.Show("No puedes seleeccionar filas en esta tabla");
            //}
            //else
            //{
            //    if (e.RowIndex >= 0)
            //    {
            //        DataGridViewRow row = dgvc.Rows[e.RowIndex];
            //        //Rellenar los campos de texto con los datos seleccionados
            //        txtNombre.Text = row.Cells["nombre"].Value.ToString();
            //        txtApellido.Text = row.Cells["apellido"].Value.ToString();
            //        txtCorreo.Text = row.Cells["correo"].Value.ToString();
            //        txtTelefono.Text = row.Cells["telefono"].Value.ToString();
            //        chkFrecuente.Checked = Convert.ToBoolean(row.Cells["cliente_frecuente"].Value);
            //    }
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = dgvc.Rows[e.RowIndex];
            //    var clienteFrecuenteValue = row.Cells["cliente_frecuente"].Value;
            //    if (clienteFrecuenteValue != DBNull.Value)
            //    {
            //        chkFrecuente.Checked = Convert.ToBoolean(clienteFrecuenteValue);
            //    }
            //    else
            //    {
            //        chkFrecuente.Checked = false;
            //    }

            //    if (int.TryParse(row.Cells["id_cliente"].Value.ToString(), out int id))
            //    {
            //        // lblIDCliente.Text = id.ToString();
            //        txtId.Text = id.ToString();
            //    }
            //    else
            //    {
            //        //MessageBox.Show("El id del cliente no es valido");
            //        MessageBox.Show("La fila seleccionada no contiene información válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return; // Salir del método
            //    }

            //    // Rellenar los campos de texto con los datos seleccionados
            //    txtNombre.Text = row.Cells["nombre"].Value.ToString();
            //    txtApellido.Text = row.Cells["apellido"].Value.ToString();
            //    txtCorreo.Text = row.Cells["correo"].Value.ToString();
            //    txtTelefono.Text = row.Cells["telefono"].Value.ToString();
            //   // chkFrecuente.Checked = Convert.ToBoolean(row.Cells["cliente_frecuente"].Value);

            //}
            // Solo habilitar selección sin pasar los datos a los TextBox
            if (mostrarClientesDatos || mostrarClientesDescuento)
            {
                return; // No se hace nada cuando se están mostrando datos de clientes o descuentos
            }
            else
            {
                // Si no se está mostrando datos especiales, pasa los datos al formulario
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvc.Rows[e.RowIndex];
                    var clienteFrecuenteValue = row.Cells["cliente_frecuente"].Value;
                    if (clienteFrecuenteValue != DBNull.Value)
                    {
                        chkFrecuente.Checked = Convert.ToBoolean(clienteFrecuenteValue);
                    }
                    else
                    {
                        chkFrecuente.Checked = false;
                    }

                    if (int.TryParse(row.Cells["id_cliente"].Value.ToString(), out int id))
                    {
                        txtId.Text = id.ToString();
                    }

                    txtNombre.Text = row.Cells["nombre"].Value.ToString();
                    txtApellido.Text = row.Cells["apellido"].Value.ToString();
                    txtCorreo.Text = row.Cells["correo"].Value.ToString();
                    txtTelefono.Text = row.Cells["telefono"].Value.ToString();
                }
            }
            //}
        }

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chkFrecuente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            clear();
        }
  

        private void MostrarTodosLosDatos()
        {
            //dgvc.DataSource = index();
            dgvc.DataSource =index ("Clientes_completo");
        }
        private void MostrarClientesDatos()
        {
            //dgvc.DataSource = index();
            dgvc.DataSource = index("Cliente_Datos");
        }
        private void MostrarClientesDescuento()
        {
            //dgvc.DataSource = index();
            dgvc.DataSource =index("Cliente_Descuento");
        }

        private void btnClientesDatos_Click(object sender, EventArgs e)
        {
            dgvc.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dgvc.ClearSelection();
            dgvc.Enabled = true;
           // dgvc.SelectionMode=DataGridViewSelectionMode.CellSelect;
            mostrarClientesDatos = true;
            mostrarClientesDescuento = false;
            MostrarClientesDatos();
            //index("Cliente_Datos");
            clear();

        }

        private void btnClientesDes_Click(object sender, EventArgs e)
        {

            dgvc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvc.ClearSelection();
            dgvc.Enabled = true;
            // dgvc.SelectionMode=DataGridViewSelectionMode.CellSelect;
            mostrarClientesDatos = false;
            mostrarClientesDescuento = true;
            //MostrarClientesDatos();
            //index("Cliente_Descuento");
            MostrarClientesDescuento();
            clear();
        }

        private void clear()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            //lblIDCliente.Text = "";
            txtId.Text = "";
            //chkFrecuente.Checked
            chkFrecuente.Checked = false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}