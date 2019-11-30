namespace BaseDatos
{
    partial class PrePractica2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botNuevo = new System.Windows.Forms.Button();
            this.botEditar = new System.Windows.Forms.Button();
            this.botGuardar = new System.Windows.Forms.Button();
            this.botCancelar = new System.Windows.Forms.Button();
            this.botEliminar = new System.Windows.Forms.Button();
            this.botMostrarDatos = new System.Windows.Forms.Button();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbEquipo = new System.Windows.Forms.ComboBox();
            this.chkFavorito = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Favorito = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // botNuevo
            // 
            this.botNuevo.Location = new System.Drawing.Point(12, 16);
            this.botNuevo.Name = "botNuevo";
            this.botNuevo.Size = new System.Drawing.Size(75, 23);
            this.botNuevo.TabIndex = 0;
            this.botNuevo.Text = "Nuevo";
            this.botNuevo.UseVisualStyleBackColor = true;
            this.botNuevo.Click += new System.EventHandler(this.botNuevo_Click);
            // 
            // botEditar
            // 
            this.botEditar.Location = new System.Drawing.Point(94, 16);
            this.botEditar.Name = "botEditar";
            this.botEditar.Size = new System.Drawing.Size(75, 23);
            this.botEditar.TabIndex = 1;
            this.botEditar.Text = "Editar";
            this.botEditar.UseVisualStyleBackColor = true;
            this.botEditar.Click += new System.EventHandler(this.botEditar_Click);
            // 
            // botGuardar
            // 
            this.botGuardar.Enabled = false;
            this.botGuardar.Location = new System.Drawing.Point(209, 16);
            this.botGuardar.Name = "botGuardar";
            this.botGuardar.Size = new System.Drawing.Size(75, 23);
            this.botGuardar.TabIndex = 2;
            this.botGuardar.Text = "Guardar";
            this.botGuardar.UseVisualStyleBackColor = true;
            this.botGuardar.Click += new System.EventHandler(this.botGuardar_Click);
            // 
            // botCancelar
            // 
            this.botCancelar.Enabled = false;
            this.botCancelar.Location = new System.Drawing.Point(290, 16);
            this.botCancelar.Name = "botCancelar";
            this.botCancelar.Size = new System.Drawing.Size(75, 23);
            this.botCancelar.TabIndex = 3;
            this.botCancelar.Text = "Cancelar";
            this.botCancelar.UseVisualStyleBackColor = true;
            this.botCancelar.Click += new System.EventHandler(this.botCancelar_Click);
            // 
            // botEliminar
            // 
            this.botEliminar.Location = new System.Drawing.Point(417, 16);
            this.botEliminar.Name = "botEliminar";
            this.botEliminar.Size = new System.Drawing.Size(75, 23);
            this.botEliminar.TabIndex = 4;
            this.botEliminar.Text = "Eliminar";
            this.botEliminar.UseVisualStyleBackColor = true;
            this.botEliminar.Click += new System.EventHandler(this.botEliminar_Click);
            // 
            // botMostrarDatos
            // 
            this.botMostrarDatos.Location = new System.Drawing.Point(498, 16);
            this.botMostrarDatos.Name = "botMostrarDatos";
            this.botMostrarDatos.Size = new System.Drawing.Size(90, 23);
            this.botMostrarDatos.TabIndex = 5;
            this.botMostrarDatos.Text = "MostrarDatos";
            this.botMostrarDatos.UseVisualStyleBackColor = true;
            this.botMostrarDatos.Click += new System.EventHandler(this.botMostrarDatos_Click);
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.AllowUserToAddRows = false;
            this.dgvEquipos.AllowUserToDeleteRows = false;
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEquipo,
            this.Nombre,
            this.Deporte,
            this.Favorito});
            this.dgvEquipos.Location = new System.Drawing.Point(12, 59);
            this.dgvEquipos.MultiSelect = false;
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.ReadOnly = true;
            this.dgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipos.Size = new System.Drawing.Size(576, 215);
            this.dgvEquipos.TabIndex = 6;
            this.dgvEquipos.SelectionChanged += new System.EventHandler(this.dgvEquipos_SelectionChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(82, 303);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // cbEquipo
            // 
            this.cbEquipo.Enabled = false;
            this.cbEquipo.FormattingEnabled = true;
            this.cbEquipo.Items.AddRange(new object[] {
            "Béisbol",
            "Básquetbol",
            "Fútbol Americano",
            "Fútbol",
            "Rugby"});
            this.cbEquipo.Location = new System.Drawing.Point(324, 302);
            this.cbEquipo.Name = "cbEquipo";
            this.cbEquipo.Size = new System.Drawing.Size(121, 21);
            this.cbEquipo.TabIndex = 8;
            // 
            // chkFavorito
            // 
            this.chkFavorito.AutoSize = true;
            this.chkFavorito.Enabled = false;
            this.chkFavorito.Location = new System.Drawing.Point(498, 304);
            this.chkFavorito.Name = "chkFavorito";
            this.chkFavorito.Size = new System.Drawing.Size(70, 17);
            this.chkFavorito.TabIndex = 9;
            this.chkFavorito.Text = "Favorito?";
            this.chkFavorito.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Deporte:";
            // 
            // IDEquipo
            // 
            this.IDEquipo.HeaderText = "IDEquipo";
            this.IDEquipo.Name = "IDEquipo";
            this.IDEquipo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.HeaderText = "Nombre Equipo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 96;
            // 
            // Deporte
            // 
            this.Deporte.HeaderText = "Deporte";
            this.Deporte.Name = "Deporte";
            this.Deporte.ReadOnly = true;
            // 
            // Favorito
            // 
            this.Favorito.HeaderText = "Favorito?";
            this.Favorito.Name = "Favorito";
            this.Favorito.ReadOnly = true;
            // 
            // PrePractica2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 345);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkFavorito);
            this.Controls.Add(this.cbEquipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.botMostrarDatos);
            this.Controls.Add(this.botEliminar);
            this.Controls.Add(this.botCancelar);
            this.Controls.Add(this.botGuardar);
            this.Controls.Add(this.botEditar);
            this.Controls.Add(this.botNuevo);
            this.Name = "PrePractica2";
            this.Text = "PrePractica2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botNuevo;
        private System.Windows.Forms.Button botEditar;
        private System.Windows.Forms.Button botGuardar;
        private System.Windows.Forms.Button botCancelar;
        private System.Windows.Forms.Button botEliminar;
        private System.Windows.Forms.Button botMostrarDatos;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbEquipo;
        private System.Windows.Forms.CheckBox chkFavorito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deporte;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Favorito;
    }
}