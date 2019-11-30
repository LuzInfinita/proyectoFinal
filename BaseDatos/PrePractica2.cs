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
    public partial class PrePractica2 : Form
    {
        private string viIDPerro;
        private bool vbNuevo;
        private int viContadorID;
        public PrePractica2()
        {
            InitializeComponent();

            viIDPerro = "";
            vbNuevo = true;
            viContadorID = 1;
        }

        private void HabilitaDeshabilita(bool opcion)
        {
            botNuevo.Enabled = opcion;
            botEditar.Enabled = opcion;
            botEliminar.Enabled = opcion;
            botMostrarDatos.Enabled = opcion;
            dgvEquipos.Enabled = opcion;

            txtNombre.Enabled = !opcion;
            cbEquipo.Enabled = !opcion;
            chkFavorito.Enabled = !opcion;
            botGuardar.Enabled = !opcion;
            botCancelar.Enabled = !opcion;
        }

        private void botNuevo_Click(object sender, EventArgs e)
        {
            vbNuevo = true;
            HabilitaDeshabilita(false);
        }

        private void botEditar_Click(object sender, EventArgs e)
        {
            vbNuevo = false;
            HabilitaDeshabilita(false);
        }

        private void botMostrarDatos_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count == 1)
            {
                MessageBox.Show("IDEquipo: "
                        + dgvEquipos.SelectedRows[0].Cells["IDEquipo"].Value.ToString()
                        + "\nNombre: "
                        + dgvEquipos.SelectedRows[0].Cells["Nombre"].Value.ToString()
                        + "\nDeporte: "
                        + dgvEquipos.SelectedRows[0].Cells["Deporte"].Value.ToString()
                        + "\nFavorito: "
                        + dgvEquipos.SelectedRows[0].Cells["Favorito"].Value.ToString()
                    );
            }
        }

        private void botEliminar_Click(object sender, EventArgs e)
        {
            if(dgvEquipos.SelectedRows.Count == 1)
            {
                dgvEquipos.Rows.RemoveAt(dgvEquipos.SelectedRows[0].Index);
                // dgvEquipos.Rows.Remove(dgvEquipos.SelectedRows[0]);
            } else
            {
                MessageBox.Show("Debe seleccionar un equipo para poderlo eliminar");
            }
        }

        private void botCancelar_Click(object sender, EventArgs e)
        {
            HabilitaDeshabilita(true);
        }

        private void botGuardar_Click(object sender, EventArgs e)
        {
            if ( vbNuevo == true) // Nuevo registro
            {
                dgvEquipos.Rows.Add(
                    new Object[] {
                        viContadorID
                        , txtNombre.Text
                        ,cbEquipo.SelectedItem.ToString()
                        ,chkFavorito.Checked
                    }
                );
                viContadorID++;
            }
            else // Editar registro
            {
                if(dgvEquipos.SelectedRows.Count == 1)
                {
                    dgvEquipos.SelectedRows[0].Cells["Nombre"].Value = txtNombre.Text;
                    dgvEquipos.SelectedRows[0].Cells["Deporte"].Value = cbEquipo.SelectedItem.ToString();
                    dgvEquipos.SelectedRows[0].Cells["Favorito"].Value = chkFavorito.Checked.ToString();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un equipo para poderlo editar");
                }
            }

            HabilitaDeshabilita(true);

        }

        private void dgvEquipos_SelectionChanged(object sender, EventArgs e)
        {
            txtNombre.Text = dgvEquipos.SelectedRows[0].Cells["Nombre"].Value.ToString();
            cbEquipo.SelectedItem = dgvEquipos.SelectedRows[0].Cells["Deporte"].Value.ToString();
            chkFavorito.Checked = Boolean.Parse(dgvEquipos.SelectedRows[0].Cells["Favorito"].Value.ToString());
        }
    }
}
