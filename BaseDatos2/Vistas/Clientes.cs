using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDatos2.Vistas
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ActualizaGridCliente()
        {
            try
            {
                DBConexion miConn = new DBConexion();
                String consulta = "SELECT * FROM DS3.dbo.Cliente";
                DataTable xTabla = miConn.ejecutaSelect(consulta, new SqlParameter[0]);
                dgvClientes.Columns.Clear();
                if(xTabla.Rows.Count > 0)
                    dgvClientes.DataSource = xTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los empleados desde la Base de Datos."
                            + " Error: " + ex.ToString());
            }
        }

        private void botCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botNuevo_Click(object sender, EventArgs e)
        {
            Modelos.Cliente _cliente = new Modelos.Cliente();
            Vistas.AgregaEditaCliente ventanaCliente
                = new Vistas.AgregaEditaCliente(_cliente);
            ventanaCliente.ShowDialog();

            if (_cliente.IDCliente != 0)
            {
                ActualizaGridCliente();
            }
        }

        private void botEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1)
            {
                DataGridViewRow renglon = dgvClientes.SelectedRows[0];

                Modelos.Cliente cliente = new Modelos.Cliente();
                cliente.IDCliente = Int32.Parse(renglon.Cells["IDCliente"].Value.ToString());
                cliente.Nombre = renglon.Cells["Nombre"].Value.ToString();
                cliente.Apellido = renglon.Cells["Apellido"].Value.ToString();
                cliente.Salario = Double.Parse(renglon.Cells["Salario"].Value.ToString());
                cliente.Activo = Boolean.Parse(renglon.Cells["Activo"].Value.ToString());
                cliente.NumeroHijos = Int32.Parse(renglon.Cells["NumeroHijos"].Value.ToString());

                Vistas.AgregaEditaCliente edita
                                = new Vistas.AgregaEditaCliente(cliente);
                edita.ShowDialog();

                if (cliente.IDCliente != 0) // Edito
                {
                    ActualizaGridCliente();
                }
            }
            else
            {
                MessageBox.Show("No hay registro seleccionado en el Grid");
            }
        }

        private void botEliminar_Click(object sender, EventArgs e)
        {
            // Mensaje de si está seguro de eliminar el regsitro
            DialogResult seleccion = MessageBox.Show("Seguro desea eliminar el registro"
                                                     , "¿Eliminar?"
                                                     , MessageBoxButtons.YesNo);
            if (seleccion == DialogResult.Yes) // Eliminar en la Base de Datos
            {
                try
                {
                    // Borrar del dgvClientes
                    // dgvClientes.Rows.Remove(dgvClientes.SelectedRows[0]);
                    int registroElimina
                        = Int32.Parse(dgvClientes.SelectedRows[0].Cells["IDCliente"].Value.ToString());
                    DBConexion miConn = new DBConexion();
                    // String elimina = "DELETE FROM [dbo].[Empleado] WHERE IDEmpleado = " + registroElimina;
                    String elimina = "DELETE FROM [dbo].[Cliente] WHERE IDCliente = @IDCliente";
                    SqlParameter[] misParametros = new SqlParameter[1];
                    misParametros[0] = new SqlParameter("@IDCliente", SqlDbType.Int);
                    misParametros[0].Value = registroElimina;
                    
                    if (miConn.ejecutaElimina(elimina, misParametros))
                    {
                        ActualizaGridCliente();
                    }
                    else // No se pudo eliminar
                    {
                        MessageBox.Show("No se pudo eliminar ningún registro");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar. Mensaje: " + ex.ToString());
                }
            }
        }

        private void botActualizar_Click(object sender, EventArgs e)
        {
            ActualizaGridCliente();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            ActualizaGridCliente();
        }
    }
}
