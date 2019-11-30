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
    public partial class Proveedores : Form
    {
        private DBConexion miConn; 

        public Proveedores()
        {
            InitializeComponent();
            miConn = new DBConexion();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void botCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizaGrid()
        {
            try
            {
                String consulta = "SELECT [IDProveedor],[RFC] "
                                + " ,[NombreProveedor],[Activo] "
                                + " ,[FechaRegistro] "
                                + "FROM [DS3].[dbo].[Proveedor]";
                DataTable dt = miConn.ejecutaSelect(consulta, new SqlParameter[0]);
                // if (dt.Rows.Count > 0)
                    dgvProveedores.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los proveedores. "
                                + "Mensaje: " + ex.ToString());
            }
        }

        private void botEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProveedores.SelectedRows.Count == 1)
                {
                    String elimina = "DELETE FROM [dbo].[Proveedor] "
                                    + " WHERE IDProveedor = @IDProveedor";
                    int valor = Int32.Parse(dgvProveedores.SelectedRows[0].Cells["IDProveedor"].Value.ToString());
                    SqlParameter[] parametros = new SqlParameter[1];
                    parametros[0] = new SqlParameter("@IDProveedor", SqlDbType.Int);
                    parametros[0].Value = valor;

                    if( miConn.ejecutaElimina(elimina, parametros) )
                    {
                        ActualizaGrid();
                        MessageBox.Show("Registro eliminado.");
                    }
                    else
                    {
                        MessageBox.Show("Error.");
                    }

                } else
                {
                    MessageBox.Show("No ha seleccionado ningún registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar al proveedor. "
                + "Mensaje: " + ex.ToString());
            }
        }

        private void botActualizar_Click(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void botNuevo_Click(object sender, EventArgs e)
        {
            Modelos.Proveedor p = new Modelos.Proveedor();
            Vistas.AgregaEditaProveedor aep = new AgregaEditaProveedor(p);
            aep.ShowDialog();
        }
    }
}
