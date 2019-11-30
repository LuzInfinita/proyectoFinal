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
    public partial class AgregaEditaPracticas4 : Form
    {
        private Modelos.Practicas4 laPractica4;
        public static int viContador;
        public AgregaEditaPracticas4(Modelos.Practicas4 parametros)
        {
            InitializeComponent();
            this.laPractica4 = parametros;

            CargaDatos();
        }

        private void AgregaEditaPracticas4_Load(object sender, EventArgs e)
        {

        }

        private void CargaDatos()
        {
            /*  textBoxID.Text = laPractica4.IDEmpleado.ToString();
              textBoxNombre.Text = laPractica4.Nombre;
              textBoxExistencia.Text = laPractica4.Apellidos;
              textBoxPrecio.Text = laPractica4.Salario.ToString();
              checkBoxActivo.Checked = laPractica4.Activo;
              MesFechaIngreso.SetDate(laPractica4.FechaIngreso); */

            textBoxIDServicio.Text = laPractica4.IDServicios.ToString();
            textBoxIDEmpleado.Text = laPractica4.IDEmpleado.ToString();
            textBoxNombreServicio.Text = laPractica4.NombreServicio;
            checkBoxActivo.Checked = laPractica4.Activo;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            laPractica4.IDServicios = 0;
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            /* elEmpleado.Nombre = txtNombre.Text;
             elEmpleado.Apellidos = txtApellidos.Text;
             elEmpleado.Salario = Double.Parse(txtSalario.Text);
             elEmpleado.Activo = chkActivo.Checked;
             elEmpleado.FechaIngreso = MesFechaIngreso.SelectionRange.Start; */

            //laPractica4.IDServicios = Int32.Parse(textBoxIDServicio.Text);
            laPractica4.IDEmpleado = Int32.Parse(textBoxIDEmpleado.Text);
            laPractica4.NombreServicio = textBoxNombreServicio.Text;
            laPractica4.Activo = checkBoxActivo.Checked;

            DBConexion miConn = new DBConexion();
            int activoX = 0;
            if (checkBoxActivo.Checked)
                activoX = 1;

            String consulta = "dbo.InsertaActualizaServicio";
          
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("@IDServicio", SqlDbType.Int);
            parametros[0].Value = laPractica4.IDServicios;
            parametros[1] = new SqlParameter("@IDEmpleado", SqlDbType.Int);
            parametros[1].Value = laPractica4.IDEmpleado;
            parametros[2] = new SqlParameter("@NombreServicio", SqlDbType.VarChar);
            parametros[2].Size = 100;
            parametros[2].Value = laPractica4.NombreServicio;
            parametros[3] = new SqlParameter("@Activo", SqlDbType.Bit);
            parametros[3].Value = activoX;
            

            // DataTable xTabla = miConn.ejecutaSelect(consulta, new SqlParameter[0]);
            if (miConn.EjecutaStoreProcedure(consulta, parametros)) //aqui esta el store procedure <--
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
