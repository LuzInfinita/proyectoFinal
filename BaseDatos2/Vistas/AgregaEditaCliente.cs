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
    public partial class AgregaEditaCliente : Form
    {
        private Modelos.Cliente unCliente;
        public AgregaEditaCliente(Modelos.Cliente _cliente)
        {
            InitializeComponent();

            unCliente = _cliente;

            CargaDatos();
        }

        public void CargaDatos()
        {
            txtIDCliente.Text = unCliente.IDCliente.ToString();
            txtNombre.Text = unCliente.Nombre;
            txtApellido.Text = unCliente.Apellido;
            txtSalario.Text = unCliente.Salario.ToString();
            chkActivo.Checked = unCliente.Activo;
            txtNumeroHijos.Text = unCliente.NumeroHijos.ToString();
        }

        private void botCancelar_Click(object sender, EventArgs e)
        {
            unCliente.IDCliente = 0;
            this.Close();
        }

        private void botGuardar_Click(object sender, EventArgs e)
        {
            unCliente.Nombre = txtNombre.Text;
            unCliente.Apellido = txtApellido.Text;
            unCliente.Salario = Double.Parse(txtSalario.Text);
            unCliente.Activo = chkActivo.Checked;
            unCliente.NumeroHijos = Int32.Parse(txtNumeroHijos.Text);

            DBConexion miConn = new DBConexion();
            int activoX = 0;
            if (chkActivo.Checked)
                activoX = 1;
            
            // Guarda en la Base de datos
            if (unCliente.IDCliente == 0) // Nuevo va a Insertar
            {
                String consulta =
                    "INSERT INTO [dbo].[Cliente] ([Nombre],[Apellido],[Activo]"
                    + ",[Salario],[NumeroHijos]) "
                    + " VALUES (@Nombre, @Apellido, @Activo, @Salario, @NumeroHijos)";
                SqlParameter[] parametros = new SqlParameter[5];
                parametros[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                parametros[0].Size = 50;
                parametros[0].Value = unCliente.Nombre;
                parametros[1] = new SqlParameter("@Apellido", SqlDbType.VarChar);
                parametros[1].Size = 50;
                parametros[1].Value = unCliente.Apellido;
                parametros[2] = new SqlParameter("@Activo", SqlDbType.Bit);
                parametros[2].Value = activoX;
                parametros[3] = new SqlParameter("@Salario", SqlDbType.Money);
                parametros[3].Value = unCliente.Salario;
                parametros[4] = new SqlParameter("@NumeroHijos", SqlDbType.Int);
                parametros[4].Value = unCliente.NumeroHijos;

                // DataTable xTabla = miConn.ejecutaSelect(consulta, new SqlParameter[0]);
                if (miConn.ejecutaInsert(consulta, parametros))
                {
                    unCliente.IDCliente = 468;
                    MessageBox.Show("Insertó con éxito. Se cerrará la ventana.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No insertó registros");
                }

                // Termina Guardar Base de datos
            }
            else //Actualizar
            {
                String consulta =
                    "UPDATE [dbo].[Cliente] " +
                    " SET [Nombre] = '" + txtNombre.Text + "'" +
                        ",[Apellido] = '" + txtApellido.Text + "'" +
                        ",[Activo] = " + activoX +
                        ",[Salario] = " + txtSalario.Text +
                        ",[NumeroHijos] = " + txtNumeroHijos.Text + "" +
                    "WHERE IDCliente = " + unCliente.IDCliente;

                if (miConn.ejecutaUpdate(consulta, new SqlParameter[0]))
                {
                    MessageBox.Show("Actualizó con éxito. Se cerrará la ventana.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No actualizó registros");
                }
            }
        }
    }
}
