using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDatos
{
    public partial class VentanaPrincipal : Form
    {
        private int contadorID; // Declaré
        private bool nuevo; 

        public VentanaPrincipal()
        {
            InitializeComponent();
            contadorID = 1; // Inicialicé
            nuevo = true;
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pVIDataSet.Carreras' Puede moverla o quitarla según sea necesario.
            // this.carrerasTableAdapter.Fill(this.pVIDataSet.Carreras);

        }

        private void limpiaCampoTexto()
        {
            txtNombre.Text = "";
            txtColor.Text = "";
            txtTipoPelaje.Text = "";
            cbRaza.SelectedIndex = 0;
        }

        private void botAgregar_Click(object sender, EventArgs e)
        {
            if (nuevo == true) // Registro nuevo Rows.Add
            {
                // IdPerro, Nombre, Raza, Color, Tipo Pelaje
                dgvDatos.Rows.Add(new Object[]
                                {
                                    contadorID
                                    , txtNombre.Text
                                    , cbRaza.SelectedItem
                                    , txtColor.Text
                                    , txtTipoPelaje.Text
                                });
                // Incrementar el contador en 1
                contadorID++;
            } else // Modifica un registro 
            {
                // 1. Asegurarte de que hay un renglón o registro a Editar
                if( dgvDatos.SelectedRows.Count == 1)
                {
                    // 2. Obtener el IDPerro para enviarlo en un futuro
                    // como parámetro del WHERE a la Base de Datos
                    String vIDPerro = 
                        dgvDatos.SelectedRows[0].Cells["IDPerro"].Value.ToString();

                    // 3. Cambiar los datos del renglón por los componentes de Text y ComboBox                    
                    dgvDatos.SelectedRows[0].Cells["Nombre"].Value = txtNombre.Text;
                    dgvDatos.SelectedRows[0].Cells["Color"].Value = txtColor.Text;
                    dgvDatos.SelectedRows[0].Cells["TipoPelaje"].Value = txtTipoPelaje.Text;
                    dgvDatos.SelectedRows[0].Cells["Raza"].Value = cbRaza.SelectedItem.ToString();

                }

            }

            // Limpia los campos de texto
            limpiaCampoTexto();

            botAgregar.Enabled = false;
            botCancelar.Enabled = false;
            txtColor.Enabled = false;
            txtNombre.Enabled = false;
            txtTipoPelaje.Enabled = false;
            cbRaza.Enabled = false;
            botNuevo.Enabled = true;
            botEditar.Enabled = true;
            botMostrarDatos.Enabled = true;
            botEliminar.Enabled = true;

            
            // Agregar una columna por código al dgvDatos
            // dgvDatos.Columns.Add("Peso", "Peso");
            // dgvDatos.Columns.Add("Tamaño", "Tamaño");
            // dgvDatos.Columns.Add("Pedigree", "Pedigree");
            // dgvDatos.Columns.Add("Edad", "Edad");

            // dgvDatos.Rows.Add();
            // dgvDatos.Rows.Add(4);
            //Object[] renglon = { 1, "Firulais", "Pitbull"
            //                    , "Negro", "Liso"};
            //dgvDatos.Rows.Add(renglon);

            //Object[] renglon2 = { 5, "Macario", "Maltes"
            //                    , "Blanco", "Lacio-Rizado"};
            //dgvDatos.Rows.Add(renglon2);

            //dgvDatos.Rows.Add(new Object[] { 8, "Chato"
            //                    , "Dálmata", "Blanco", "Liso" });

        }

        private void botMostrarDatos_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 1)
            {
                // Texto, Título, Botones, Icono
                MessageBox.Show(
                    "IDPerro: " + dgvDatos.SelectedRows[0].Cells["IDPerro"].Value.ToString()
                    + "\nNombre: " + dgvDatos.SelectedRows[0].Cells["Nombre"].Value.ToString()
                    + "\nRaza: " + dgvDatos.SelectedRows[0].Cells["Raza"].Value.ToString()
                    + "\nColor: " + dgvDatos.SelectedRows[0].Cells["Color"].Value.ToString()
                    + "\nTipoPelaje: " + dgvDatos.SelectedRows[0].Cells["TipoPelaje"].Value.ToString()
                , "Datos Perro"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information
                        );
            }
        }

        private void dgvDatos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if(dgvDatos.SelectedRows.Count > 0)
                {
                    txtNombre.Text = dgvDatos.SelectedRows[0].Cells["Nombre"].Value.ToString();
                    txtColor.Text = dgvDatos.SelectedRows[0].Cells["Color"].Value.ToString();
                    txtTipoPelaje.Text = dgvDatos.SelectedRows[0].Cells["TipoPelaje"].Value.ToString();
                    cbRaza.SelectedItem = dgvDatos.SelectedRows[0].Cells["Raza"].Value;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error");
            }
        }
        
        private void botCancelar_Click(object sender, EventArgs e)
        {
            botAgregar.Enabled = false;
            botCancelar.Enabled = false;
            txtColor.Enabled = false;
            txtNombre.Enabled = false;
            txtTipoPelaje.Enabled = false;
            cbRaza.Enabled = false;
            botNuevo.Enabled = true;
            botEditar.Enabled = true;
            botMostrarDatos.Enabled = true;
            botEliminar.Enabled = true;
        }

        private void botNuevo_Click(object sender, EventArgs e)
        {
            botAgregar.Enabled = true;
            botCancelar.Enabled = true;
            txtColor.Enabled = true;
            txtNombre.Enabled = true;
            txtTipoPelaje.Enabled = true;
            cbRaza.Enabled = true;
            botNuevo.Enabled = false;
            botEditar.Enabled = false;
            botMostrarDatos.Enabled = false;
            botEliminar.Enabled = false;

            nuevo = true;
        }

        private void botEditar_Click(object sender, EventArgs e)
        {
            // Habilitar o deshabilitar lo necesario
            botAgregar.Enabled = true;
            botCancelar.Enabled = true;
            txtColor.Enabled = true;
            txtNombre.Enabled = true;
            txtTipoPelaje.Enabled = true;
            cbRaza.Enabled = true;
            botNuevo.Enabled = false;
            botEditar.Enabled = false;
            botMostrarDatos.Enabled = false;
            botEliminar.Enabled = false;
            
            // Variable auxiliar que indica que estoy modificando
            // un registro, no estoy creando un nuevo renglón
            nuevo = false;
        }

        private void botEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                dgvDatos.Rows.RemoveAt(dgvDatos.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Necesitas seleccionador un registro");
            }
        }
    }
}
