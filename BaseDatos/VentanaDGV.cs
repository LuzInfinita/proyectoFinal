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
    public partial class VentanaDGV : Form
    { 
        private bool esNuevo; // Declaro Variable de Clase
        // private bool EsNuevo { get; set; } // Declaro Propiedad
        private int vIDPelicula;
    
        public VentanaDGV()
        {
            InitializeComponent();

            esNuevo = true; // Inicializo
            vIDPelicula = 1;
        }

        private void HabilitaDesHabilita (bool opcion)
        {
            txtNombre.Enabled = opcion;
            txtAño.Enabled = opcion;
            txtDuracion.Enabled = opcion;
            cbGenero.Enabled = opcion;
            chkDisponible.Enabled = opcion;
            botGuardar.Enabled = opcion;
            botCancelar.Enabled = opcion;

            botNuevo.Enabled = !opcion;
            botEditar.Enabled = !opcion;
            botEliminar.Enabled = !opcion;
            botMostrarDatos.Enabled = !opcion;
            dgvPeliculas.Enabled = !opcion;
        }

        private void botNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            HabilitaDesHabilita(true);
        }

        private void botEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            HabilitaDesHabilita(true);
        }

        private void botGuardar_Click(object sender, EventArgs e)
        {
            // Agregar registro
            if( esNuevo == true) // if( esNuevo )
            {
                dgvPeliculas.Rows.Add(new Object[] {
                    vIDPelicula
                    , txtNombre.Text
                    , txtAño.Text
                    , cbGenero.SelectedItem
                    , txtDuracion.Text
                    , chkDisponible.Checked
                });

                vIDPelicula++;
            }
            // Modificar registro
            else
            {
                // 1. Que exista un renglón seleccionado
                if (dgvPeliculas.SelectedRows.Count == 1)
                {
                    // 2. Obtener el IDPelicula para pasarlo cómo 
                    // parámetro (cuando trabajemos con Base de datos)
                    String ID_Peliculas = dgvPeliculas.SelectedRows[0].Cells["IDPelicula"].Value.ToString();
                    // 3. Obtener de los campos de texto o combos los valores
                    //      y asignarlos a las columnas del registro seleccionado
                    dgvPeliculas.SelectedRows[0].Cells["Nombre"].Value = txtNombre.Text;
                    dgvPeliculas.SelectedRows[0].Cells["Año"].Value = txtAño.Text;
                    dgvPeliculas.SelectedRows[0].Cells["Duracion"].Value = txtDuracion.Text;
                    dgvPeliculas.SelectedRows[0].Cells["Genero"].Value = cbGenero.SelectedItem;
                    dgvPeliculas.SelectedRows[0].Cells["Disponible"].Value = chkDisponible.Checked;

                }


            }

            HabilitaDesHabilita(false);
        }

        private void botCancelar_Click(object sender, EventArgs e)
        {
            HabilitaDesHabilita(false);
        }

        private void botEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPeliculas.SelectedRows.Count == 1)
            {
                dgvPeliculas.Rows.RemoveAt(dgvPeliculas.SelectedRows[0].Index);
            } else if(dgvPeliculas.SelectedRows.Count > 1)
            {
                foreach(DataGridViewRow row in dgvPeliculas.SelectedRows)
                {
                    dgvPeliculas.Rows.RemoveAt(row.Index);
                }
            } else
            {
                MessageBox.Show("Nada seleccionado :(");
            }
        }

        private void botMostrarDatos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dgvPeliculas.SelectedRows[0].Cells["Nombre"].Value.ToString());
        }
    }
}
