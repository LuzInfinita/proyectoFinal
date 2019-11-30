namespace BaseDatos
{
    partial class VentanaDGV
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
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.IDPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.botNuevo = new System.Windows.Forms.Button();
            this.botEditar = new System.Windows.Forms.Button();
            this.botGuardar = new System.Windows.Forms.Button();
            this.botCancelar = new System.Windows.Forms.Button();
            this.botEliminar = new System.Windows.Forms.Button();
            this.botMostrarDatos = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.chkDisponible = new System.Windows.Forms.CheckBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.AllowUserToDeleteRows = false;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPelicula,
            this.Nombre,
            this.Año,
            this.Genero,
            this.Duracion,
            this.Disponible});
            this.dgvPeliculas.Location = new System.Drawing.Point(12, 56);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.ReadOnly = true;
            this.dgvPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeliculas.Size = new System.Drawing.Size(643, 197);
            this.dgvPeliculas.TabIndex = 0;
            // 
            // IDPelicula
            // 
            this.IDPelicula.HeaderText = "IDPelicula";
            this.IDPelicula.Name = "IDPelicula";
            this.IDPelicula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Género";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duración";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            // 
            // Disponible
            // 
            this.Disponible.HeaderText = "Disponible";
            this.Disponible.Name = "Disponible";
            this.Disponible.ReadOnly = true;
            // 
            // botNuevo
            // 
            this.botNuevo.Location = new System.Drawing.Point(13, 8);
            this.botNuevo.Name = "botNuevo";
            this.botNuevo.Size = new System.Drawing.Size(75, 23);
            this.botNuevo.TabIndex = 1;
            this.botNuevo.Text = "Nuevo";
            this.botNuevo.UseVisualStyleBackColor = true;
            this.botNuevo.Click += new System.EventHandler(this.botNuevo_Click);
            // 
            // botEditar
            // 
            this.botEditar.Location = new System.Drawing.Point(94, 8);
            this.botEditar.Name = "botEditar";
            this.botEditar.Size = new System.Drawing.Size(75, 23);
            this.botEditar.TabIndex = 2;
            this.botEditar.Text = "Editar";
            this.botEditar.UseVisualStyleBackColor = true;
            this.botEditar.Click += new System.EventHandler(this.botEditar_Click);
            // 
            // botGuardar
            // 
            this.botGuardar.Enabled = false;
            this.botGuardar.Location = new System.Drawing.Point(220, 8);
            this.botGuardar.Name = "botGuardar";
            this.botGuardar.Size = new System.Drawing.Size(75, 23);
            this.botGuardar.TabIndex = 3;
            this.botGuardar.Text = "Guardar";
            this.botGuardar.UseVisualStyleBackColor = true;
            this.botGuardar.Click += new System.EventHandler(this.botGuardar_Click);
            // 
            // botCancelar
            // 
            this.botCancelar.Enabled = false;
            this.botCancelar.Location = new System.Drawing.Point(301, 8);
            this.botCancelar.Name = "botCancelar";
            this.botCancelar.Size = new System.Drawing.Size(75, 23);
            this.botCancelar.TabIndex = 4;
            this.botCancelar.Text = "Cancelar";
            this.botCancelar.UseVisualStyleBackColor = true;
            this.botCancelar.Click += new System.EventHandler(this.botCancelar_Click);
            // 
            // botEliminar
            // 
            this.botEliminar.Location = new System.Drawing.Point(429, 8);
            this.botEliminar.Name = "botEliminar";
            this.botEliminar.Size = new System.Drawing.Size(75, 23);
            this.botEliminar.TabIndex = 5;
            this.botEliminar.Text = "Eliminar";
            this.botEliminar.UseVisualStyleBackColor = true;
            this.botEliminar.Click += new System.EventHandler(this.botEliminar_Click);
            // 
            // botMostrarDatos
            // 
            this.botMostrarDatos.Location = new System.Drawing.Point(553, 8);
            this.botMostrarDatos.Name = "botMostrarDatos";
            this.botMostrarDatos.Size = new System.Drawing.Size(102, 23);
            this.botMostrarDatos.TabIndex = 6;
            this.botMostrarDatos.Text = "Mostrar Datos";
            this.botMostrarDatos.UseVisualStyleBackColor = true;
            this.botMostrarDatos.Click += new System.EventHandler(this.botMostrarDatos_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(94, 273);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtAño
            // 
            this.txtAño.Enabled = false;
            this.txtAño.Location = new System.Drawing.Point(322, 274);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(54, 20);
            this.txtAño.TabIndex = 8;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Enabled = false;
            this.txtDuracion.Location = new System.Drawing.Point(322, 301);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(54, 20);
            this.txtDuracion.TabIndex = 9;
            // 
            // chkDisponible
            // 
            this.chkDisponible.AutoSize = true;
            this.chkDisponible.Enabled = false;
            this.chkDisponible.Location = new System.Drawing.Point(447, 275);
            this.chkDisponible.Name = "chkDisponible";
            this.chkDisponible.Size = new System.Drawing.Size(87, 17);
            this.chkDisponible.TabIndex = 10;
            this.chkDisponible.Text = "¿Disponible?";
            this.chkDisponible.UseVisualStyleBackColor = true;
            // 
            // cbGenero
            // 
            this.cbGenero.Enabled = false;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Acción",
            "Aventura",
            "Comedia",
            "Drama",
            "Romántica",
            "Terror"});
            this.cbGenero.Location = new System.Drawing.Point(94, 300);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Género:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Año:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Duración:";
            // 
            // VentanaDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 337);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.chkDisponible);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.botMostrarDatos);
            this.Controls.Add(this.botEliminar);
            this.Controls.Add(this.botCancelar);
            this.Controls.Add(this.botGuardar);
            this.Controls.Add(this.botEditar);
            this.Controls.Add(this.botNuevo);
            this.Controls.Add(this.dgvPeliculas);
            this.Name = "VentanaDGV";
            this.Text = "Ventana Practica DGV";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Disponible;
        private System.Windows.Forms.Button botNuevo;
        private System.Windows.Forms.Button botEditar;
        private System.Windows.Forms.Button botGuardar;
        private System.Windows.Forms.Button botCancelar;
        private System.Windows.Forms.Button botEliminar;
        private System.Windows.Forms.Button botMostrarDatos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.CheckBox chkDisponible;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}