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
    public partial class Practica4 : Form
    {
        public Practica4()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Modelos.Practicas4 p = new Modelos.Practicas4();
            Vistas.AgregaEditaPracticas4 kkk = new AgregaEditaPracticas4(p);
            kkk.ShowDialog();

            if (p.IDServicios != 0)
            {
                actualiza();
            }
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            actualiza();
        }

        private void actualiza()
        {
            try
            {
                DBConexion miConn = new DBConexion();
                String consulta = "SELECT * FROM DS3.dbo.vistaservicio"; 
                DataTable xTabla = miConn.ejecutaSelect(consulta, new SqlParameter[0]);

                Servicio.Columns.Clear();
                Servicio.DataSource = xTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los empleados desde la Base de Datos."
                            + " Error: " + ex.ToString());
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Servicio.SelectedRows.Count == 1)
            {
                DataGridViewRow renglon = Servicio.SelectedRows[0];

               Modelos.Practicas4 empEdita = new Modelos.Practicas4();
               
                empEdita.IDServicios = Int32.Parse(renglon.Cells["IDServicio"].Value.ToString());
                empEdita.IDEmpleado = Int32.Parse(renglon.Cells["IDEmpleado"].Value.ToString());
                empEdita.NombreServicio = renglon.Cells["NombreServicio"].Value.ToString();
                empEdita.Activo = Boolean.Parse(renglon.Cells["ActivoServicio"].Value.ToString());


                Vistas.AgregaEditaPracticas4 edita = new Vistas.AgregaEditaPracticas4(empEdita);
                edita.ShowDialog();
                if (empEdita.IDEmpleado != 0) 
                {
                    actualiza();
                    
                }
            }
            else
            {
                MessageBox.Show("No hay registro seleccionado en el Grid");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult seleccion = MessageBox.Show("Seguro desea eliminar el registro"
                                                     , "¿Eliminar?"
                                                     , MessageBoxButtons.YesNo);
            if (seleccion == DialogResult.Yes)
            {
                try
                {

                    int registroElimina = Int32.Parse(Servicio.SelectedRows[0].Cells["IDServicio"].Value.ToString());
                    DBConexion miConn = new DBConexion();

                    String elimina = "DELETE FROM [dbo].[Servicio] WHERE IDServicio = @IDServicio";
                    SqlParameter[] misParametros = new SqlParameter[1];
                    misParametros[0] = new SqlParameter("@IDServicio", SqlDbType.Int);
                    misParametros[0].Value = registroElimina;

                    if (miConn.ejecutaElimina(elimina, misParametros))
                    {
                        actualiza();
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar. Mensaje: " + ex.ToString());
                }
            }
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            try
            {
                DBConexion miConn = new DBConexion();
                String consulta = "SELECT * FROM DS3.dbo.vistaservicio WHERE IDServicio = @IDServicio";

                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter("@IDServicio", SqlDbType.Int);
                parametros[0].Value = Int32.Parse(txtNumerito.Text);

                DataTable xTabla = miConn.ejecutaSelect(consulta, parametros);
                // dgvEmpleados.Rows.Clear();
                Servicio.Columns.Clear();
                Servicio.DataSource = xTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los empleados desde la Base de Datos."
                            + " Error: " + ex.ToString());
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
