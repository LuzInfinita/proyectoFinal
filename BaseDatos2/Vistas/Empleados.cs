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

namespace BaseDatos2
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void botCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizaGridEmpleados()
        {
            try
            {
                DBConexion miConn = new DBConexion();
                String consulta = "SELECT * FROM DS3.dbo.Empleado";
                DataTable xTabla = miConn.ejecutaSelect(consulta, new SqlParameter[0]);
                // dgvEmpleados.Rows.Clear();
                dgvEmpleados.Columns.Clear();
                dgvEmpleados.DataSource = xTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los empleados desde la Base de Datos."
                            + " Error: " + ex.ToString());
            }

            //DBConexion miConn = new DBConexion();
            //System.Data.SqlClient.SqlParameter[] parametros = new System.Data.SqlClient.SqlParameter[0];
            //miConn.ejecutaSelect("SELECT * FROM dbo.Empleado", parametros);
        }

        private void botNuevo_Click(object sender, EventArgs e)
        {
            Modelos.Empleado nuevoEmpleado = new Modelos.Empleado();
            Vistas.AgregaEditaEmpleado ventanaNuevoEmpleado
                = new Vistas.AgregaEditaEmpleado(nuevoEmpleado);
            ventanaNuevoEmpleado.ShowDialog();

            if (nuevoEmpleado.IDEmpleado != 0) {
                ActualizaGridEmpleados();
                //dgvEmpleados.Rows.Add(
                //    nuevoEmpleado.IDEmpleado
                //    , nuevoEmpleado.Nombre
                //    , nuevoEmpleado.Apellidos
                //    , nuevoEmpleado.Activo
                //    , nuevoEmpleado.Salario
                //    , nuevoEmpleado.FechaIngreso
                //    );

            }
        }

        private void botEditar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 1)
            {
                DataGridViewRow renglon = dgvEmpleados.SelectedRows[0];

                Modelos.Empleado empEdita = new Modelos.Empleado();
                empEdita.IDEmpleado = Int32.Parse(renglon.Cells["IDEmpleado"].Value.ToString());
                empEdita.Nombre = renglon.Cells["Nombre"].Value.ToString();
                empEdita.Apellidos = renglon.Cells["Apellidos"].Value.ToString();
                empEdita.Salario = Double.Parse(renglon.Cells["Salario"].Value.ToString());
                empEdita.Activo = Boolean.Parse(renglon.Cells["Activo"].Value.ToString());
                empEdita.FechaIngreso = DateTime.Parse(renglon.Cells["FechaIngreso"].Value.ToString());

                Vistas.AgregaEditaEmpleado edita
                                = new Vistas.AgregaEditaEmpleado(empEdita);
                edita.ShowDialog();
                if (empEdita.IDEmpleado != 0) // Edito
                {
                    ActualizaGridEmpleados();
                    //renglon.Cells["Nombre"].Value = empEdita.Nombre;
                    //renglon.Cells["Apellidos"].Value = empEdita.Apellidos;
                    //renglon.Cells["Activo"].Value = empEdita.Activo;
                    //renglon.Cells["Salario"].Value = empEdita.Salario;
                    //renglon.Cells["FechaIngreso"].Value = empEdita.FechaIngreso;
                }
            } else
            {
                MessageBox.Show("No hay registro seleccionado en el Grid");
            }
        }

        private void botEliminar_Click(object sender, EventArgs e)
        {
            // Mensaje de si está seguro de eliminar el regsitro
            DialogResult seleccion = MessageBox.Show("Seguro desea eliminar el registro"
                                                     , "¿Eliminar?"
                                                     ,MessageBoxButtons.YesNo);
            if(seleccion == DialogResult.Yes) // Eliminar en la Base de Datos
            {
                try
                {
                    // Borrar del dgvEmpleados
                    // dgvEmpleados.Rows.Remove(dgvEmpleados.SelectedRows[0]);
                    int registroElimina
                        = Int32.Parse(dgvEmpleados.SelectedRows[0].Cells["IDEmpleado"].Value.ToString());
                    DBConexion miConn = new DBConexion();
                    // String elimina = "DELETE FROM [dbo].[Empleado] WHERE IDEmpleado = " + registroElimina;
                    String elimina = "DELETE FROM [dbo].[Empleado] WHERE IDEmpleado = @IDEmpleado";
                    SqlParameter[] misParametros = new SqlParameter[1];
                    misParametros[0] = new SqlParameter("@IDEmpleado", SqlDbType.Int);
                    misParametros[0].Value = registroElimina;

                    if (miConn.ejecutaElimina(elimina, misParametros))
                    {
                        ActualizaGridEmpleados();
                    }
                    else // No se pudo eliminar
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar. Mensaje: " + ex.ToString());
                }
            }          
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            ActualizaGridEmpleados(); // Llama el método que actualiza todo el dgvEmpleados
        }

        private void botObtiene_Click(object sender, EventArgs e)
        {
            try
            {
                DBConexion miConn = new DBConexion();
                String consulta
                    = "SELECT * FROM DS3.dbo.Empleado WHERE IDEmpleado = @IDEmpleado";

                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter("@IDEmpleado", SqlDbType.Int);
                parametros[0].Value = Int32.Parse(txtNumeroEmpleado.Text);

                DataTable xTabla = miConn.ejecutaSelect(consulta, parametros);
                // dgvEmpleados.Rows.Clear();
                dgvEmpleados.Columns.Clear();
                dgvEmpleados.DataSource = xTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los empleados desde la Base de Datos."
                            + " Error: " + ex.ToString());
            }
        }

        private void botActualizar_Click(object sender, EventArgs e)
        {
            ActualizaGridEmpleados();
        }

        private void botAgregaActualiza_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DBConexion miConn = new DBConexion();

            //    //@IDEmpleado int
            //    //@Nombre varchar(50)
            //    //@Apellidos varchar(50)
            //    //@Activo bit
            //    //@Salario money
            //    //@FechaIngreso datetime
            //    SqlParameter[] x = new SqlParameter[6];
            //    x[0] = new SqlParameter("@IDEmpleado", SqlDbType.Int);
            //    x[0].Value =

            //    empEdita.IDEmpleado = Int32.Parse(renglon.Cells["IDEmpleado"].Value.ToString());
            //    empEdita.Nombre = renglon.Cells["Nombre"].Value.ToString();
            //    empEdita.Apellidos = renglon.Cells["Apellidos"].Value.ToString();
            //    empEdita.Salario = Double.Parse(renglon.Cells["Salario"].Value.ToString());
            //    empEdita.Activo = Boolean.Parse(renglon.Cells["Activo"].Value.ToString());
            //    empEdita.FechaIngreso = DateTime.Parse(renglon.Cells["FechaIngreso"].Value.ToString());


            //    miConn.EjecutaStoreProcedure("dbo.InsertaActualizaEmpleado");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al Agregar o Actualizar los empleados desde la Base de Datos."
            //                + " Error: " + ex.ToString());
            //}


        }
    }
}
