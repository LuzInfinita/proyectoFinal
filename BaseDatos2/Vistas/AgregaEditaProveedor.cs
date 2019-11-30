using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDatos2.Vistas
{
    public partial class AgregaEditaProveedor : Form
    {
        Modelos.Proveedor p;
        public AgregaEditaProveedor(Modelos.Proveedor _p)
        {
            InitializeComponent();

            this.p = _p;

            CargaDatos();
        }

        private void CargaDatos()
        {
            txtID.Text = p.IDProveedor.ToString();
            txtRFC.Text = p.RFC;
            txtNombre.Text = p.NombreProveedor;
            txtFechaRegistro.Text = p.FechaRegistro.ToString();
        }

        private void botCancelar_Click(object sender, EventArgs e)
        {
            p.IDProveedor = 0;
            this.Close();
        }

        private void botGuardar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
