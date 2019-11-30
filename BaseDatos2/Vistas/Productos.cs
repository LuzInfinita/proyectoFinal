using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaseDatos2.Vistas
{
    public partial class Productos : Form
    {
        private DBConexion miConn = new DBConexion();

        public Productos()
        {
            InitializeComponent();
        }

        private void ActualizaGrid()
        {
            
            String consulta = "SELECT * FROM DS3.dbo.vwVentaProducto";
            DataTable dt = miConn.ejecutaSelect(consulta, new SqlParameter[0]);

            if (dt.Rows.Count > 0)
            {
                dgvProductos.DataSource = dt;
                if (dgvProductos.Columns["IDVentaProducto"] != null)
                    dgvProductos.Columns["IDVentaProducto"].Visible = false;

                if (dgvProductos.Columns["IDVenta"] != null)
                    dgvProductos.Columns["IDVenta"].Visible = false;

                dgvProductos.Columns["IDEmpleado"].Visible = false;
                dgvProductos.Columns["IDCliente"].Visible = false;
            } else
            {
                MessageBox.Show("No regresó información");
            }
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void botActualizar_Click(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void botCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.SelectedRows.Count == 1)
                {
                    int eliminaRegistro = Int32.Parse(
                        dgvProductos.SelectedRows[0].Cells["IDProducto"].Value.ToString());
                    String elimina = "DELETE FROM DS3.dbo.Producto "
                                    + " WHERE IDProducto = @IDProducto";

                    SqlParameter[] parametros = new SqlParameter[1];
                    parametros[0] = new SqlParameter("@IDProducto", SqlDbType.Int);
                    parametros[0].Value = eliminaRegistro;
                    if( miConn.ejecutaElimina(elimina, parametros) )
                    {
                        MessageBox.Show("Registro eliminado.");
                        ActualizaGrid();
                    } else
                    {
                        MessageBox.Show("Erro al eliminar un registro", "Error"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                } else
                {
                    MessageBox.Show("Debe seleccionar un registro");
                }
            }
            catch (Exception ex )
            {
                
            }

        }
    }
}
