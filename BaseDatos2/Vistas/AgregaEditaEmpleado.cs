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
    public partial class AgregaEditaEmpleado : Form
    {
        private Modelos.Empleado elEmpleado;
        public static int viContador;
        public AgregaEditaEmpleado(Modelos.Empleado parametro)
        {
            InitializeComponent();
            elEmpleado = parametro; // Asocio el parámetro con la variable de clase

            MesFechaIngreso.SetDate(DateTime.Now);

            CargaDatos(); // Método que carga datos en los componentes del FORM
        }

        private void CargaDatos()
        {
            txtIDEmpleado.Text = elEmpleado.IDEmpleado.ToString();
            txtNombre.Text = elEmpleado.Nombre;
            txtApellidos.Text = elEmpleado.Apellidos;
            txtSalario.Text = elEmpleado.Salario.ToString();
            chkActivo.Checked = elEmpleado.Activo;
            MesFechaIngreso.SetDate(elEmpleado.FechaIngreso);
        }

        private void botCerrar_Click(object sender, EventArgs e)
        {
            
        }

        private void botCancelar_Click(object sender, EventArgs e)
        {
            elEmpleado.IDEmpleado = 0;
            this.Close();
        }

        private void botGuardar_Click(object sender, EventArgs e)
        {
            elEmpleado.Nombre = txtNombre.Text;
            elEmpleado.Apellidos = txtApellidos.Text;
            elEmpleado.Salario = Double.Parse(txtSalario.Text);
            elEmpleado.Activo = chkActivo.Checked;
            elEmpleado.FechaIngreso = MesFechaIngreso.SelectionRange.Start;

            DBConexion miConn = new DBConexion();
            int activoX = 0;
            if (chkActivo.Checked)
                activoX = 1;

            String fechaX = elEmpleado.FechaIngreso.Year.ToString() + "-"
                            + elEmpleado.FechaIngreso.Month.ToString() + "-"
                            + elEmpleado.FechaIngreso.Day.ToString();
                
            String consulta = "dbo.InsertaActualizaEmpleadoParametros";
            SqlParameter[] parametros = new SqlParameter[9];
            parametros[0] = new SqlParameter("@IDEmpleado", SqlDbType.Int);
            parametros[0].Value = elEmpleado.IDEmpleado;
            parametros[1] = new SqlParameter("@Nombre", SqlDbType.VarChar);
            parametros[1].Size = 50;
            parametros[1].Value = elEmpleado.Nombre;
            parametros[2] = new SqlParameter("@Apellidos", SqlDbType.VarChar);
            parametros[2].Size = 50;
            parametros[2].Value = elEmpleado.Apellidos;
            parametros[3] = new SqlParameter("@Activo", SqlDbType.Bit);
            parametros[3].Value = activoX;
            parametros[4] = new SqlParameter("@Salario", SqlDbType.Money);
            parametros[4].Value = elEmpleado.Salario;
            parametros[5] = new SqlParameter("@FechaIngreso", SqlDbType.DateTime);
            parametros[5].Value = fechaX;
            parametros[6] = new SqlParameter("@IDRegreso", SqlDbType.Int);
            parametros[6].Direction = ParameterDirection.Output;
            parametros[7] = new SqlParameter("@spRegreso", SqlDbType.Bit);
            parametros[7].Direction = ParameterDirection.Output;
            parametros[8] = new SqlParameter("@spMensaje", SqlDbType.VarChar);
            parametros[8].Direction = ParameterDirection.Output;

            int vIDRegreso = 0;
            bool vspRegreso = false;
            String vspMensaje = "";

            miConn.EjecutaStoreProcedureParametros(consulta, parametros, out vIDRegreso, out vspMensaje, out vspRegreso);

            // DataTable xTabla = miConn.ejecutaSelect(consulta, new SqlParameter[0]);
            if (miConn.EjecutaStoreProcedure(consulta, parametros))
            {
                MessageBox.Show("Se ejecutó el Store Procedure. Se cerrará la ventana.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Problemas con el Store Procedure");
            }
        }
    }
}
