using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDatos2
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados ventanaEmpleado = new Empleados();
            ventanaEmpleado.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.Clientes ventanaCliente = new Vistas.Clientes();
            ventanaCliente.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.Proveedores x = new Vistas.Proveedores();
            x.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.Productos _productos = new Vistas.Productos();
            _productos.ShowDialog();
        }

        private void vistaVentaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void practica4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.Practica4 nuevaVentanita = new Vistas.Practica4();
            nuevaVentanita.ShowDialog();
        }
    }
}
