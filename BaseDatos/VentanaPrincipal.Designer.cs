namespace BaseDatos
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.IDPerro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPelaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pVIDataSet = new BaseDatos.PVIDataSet();
            this.carrerasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrerasTableAdapter = new BaseDatos.PVIDataSetTableAdapters.CarrerasTableAdapter();
            this.botAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtTipoPelaje = new System.Windows.Forms.TextBox();
            this.cbRaza = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.botEditar = new System.Windows.Forms.Button();
            this.botMostrarDatos = new System.Windows.Forms.Button();
            this.botNuevo = new System.Windows.Forms.Button();
            this.botEliminar = new System.Windows.Forms.Button();
            this.botCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pVIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPerro,
            this.Nombre,
            this.Raza,
            this.Color,
            this.TipoPelaje});
            this.dgvDatos.Location = new System.Drawing.Point(28, 51);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(603, 248);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDatos_MouseClick);
            // 
            // IDPerro
            // 
            this.IDPerro.HeaderText = "IDPerro";
            this.IDPerro.Name = "IDPerro";
            this.IDPerro.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Raza
            // 
            this.Raza.HeaderText = "Raza";
            this.Raza.Name = "Raza";
            this.Raza.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // TipoPelaje
            // 
            this.TipoPelaje.HeaderText = "Tipo Pelaje";
            this.TipoPelaje.Name = "TipoPelaje";
            this.TipoPelaje.ReadOnly = true;
            // 
            // pVIDataSet
            // 
            this.pVIDataSet.DataSetName = "PVIDataSet";
            this.pVIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrerasBindingSource
            // 
            this.carrerasBindingSource.DataMember = "Carreras";
            this.carrerasBindingSource.DataSource = this.pVIDataSet;
            // 
            // carrerasTableAdapter
            // 
            this.carrerasTableAdapter.ClearBeforeFill = true;
            // 
            // botAgregar
            // 
            this.botAgregar.Enabled = false;
            this.botAgregar.Location = new System.Drawing.Point(242, 12);
            this.botAgregar.Name = "botAgregar";
            this.botAgregar.Size = new System.Drawing.Size(75, 23);
            this.botAgregar.TabIndex = 6;
            this.botAgregar.Text = "Guardar";
            this.botAgregar.UseVisualStyleBackColor = true;
            this.botAgregar.Click += new System.EventHandler(this.botAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(123, 320);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtColor
            // 
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(123, 354);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 4;
            // 
            // txtTipoPelaje
            // 
            this.txtTipoPelaje.Enabled = false;
            this.txtTipoPelaje.Location = new System.Drawing.Point(323, 353);
            this.txtTipoPelaje.Name = "txtTipoPelaje";
            this.txtTipoPelaje.Size = new System.Drawing.Size(100, 20);
            this.txtTipoPelaje.TabIndex = 5;
            // 
            // cbRaza
            // 
            this.cbRaza.Enabled = false;
            this.cbRaza.FormattingEnabled = true;
            this.cbRaza.Items.AddRange(new object[] {
            "Boxer",
            "Chihuahua",
            "Dálmata",
            "Maltés",
            "Pitbull",
            "San Bernardo"});
            this.cbRaza.Location = new System.Drawing.Point(323, 317);
            this.cbRaza.Name = "cbRaza";
            this.cbRaza.Size = new System.Drawing.Size(100, 21);
            this.cbRaza.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Raza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo Pelaje:";
            // 
            // botEditar
            // 
            this.botEditar.Location = new System.Drawing.Point(108, 12);
            this.botEditar.Name = "botEditar";
            this.botEditar.Size = new System.Drawing.Size(75, 23);
            this.botEditar.TabIndex = 10;
            this.botEditar.Text = "Editar";
            this.botEditar.UseVisualStyleBackColor = true;
            this.botEditar.Click += new System.EventHandler(this.botEditar_Click);
            // 
            // botMostrarDatos
            // 
            this.botMostrarDatos.Location = new System.Drawing.Point(516, 12);
            this.botMostrarDatos.Name = "botMostrarDatos";
            this.botMostrarDatos.Size = new System.Drawing.Size(75, 23);
            this.botMostrarDatos.TabIndex = 11;
            this.botMostrarDatos.Text = "Mostrar Datos";
            this.botMostrarDatos.UseVisualStyleBackColor = true;
            this.botMostrarDatos.Click += new System.EventHandler(this.botMostrarDatos_Click);
            // 
            // botNuevo
            // 
            this.botNuevo.Location = new System.Drawing.Point(12, 12);
            this.botNuevo.Name = "botNuevo";
            this.botNuevo.Size = new System.Drawing.Size(75, 23);
            this.botNuevo.TabIndex = 12;
            this.botNuevo.Text = "Nuevo";
            this.botNuevo.UseVisualStyleBackColor = true;
            this.botNuevo.Click += new System.EventHandler(this.botNuevo_Click);
            // 
            // botEliminar
            // 
            this.botEliminar.Location = new System.Drawing.Point(421, 12);
            this.botEliminar.Name = "botEliminar";
            this.botEliminar.Size = new System.Drawing.Size(75, 23);
            this.botEliminar.TabIndex = 13;
            this.botEliminar.Text = "Eliminar";
            this.botEliminar.UseVisualStyleBackColor = true;
            this.botEliminar.Click += new System.EventHandler(this.botEliminar_Click);
            // 
            // botCancelar
            // 
            this.botCancelar.Enabled = false;
            this.botCancelar.Location = new System.Drawing.Point(323, 12);
            this.botCancelar.Name = "botCancelar";
            this.botCancelar.Size = new System.Drawing.Size(75, 23);
            this.botCancelar.TabIndex = 14;
            this.botCancelar.Text = "Cancelar";
            this.botCancelar.UseVisualStyleBackColor = true;
            this.botCancelar.Click += new System.EventHandler(this.botCancelar_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 386);
            this.Controls.Add(this.botCancelar);
            this.Controls.Add(this.botEliminar);
            this.Controls.Add(this.botNuevo);
            this.Controls.Add(this.botMostrarDatos);
            this.Controls.Add(this.botEditar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRaza);
            this.Controls.Add(this.txtTipoPelaje);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.botAgregar);
            this.Controls.Add(this.dgvDatos);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pVIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private PVIDataSet pVIDataSet;
        private System.Windows.Forms.BindingSource carrerasBindingSource;
        private PVIDataSetTableAdapters.CarrerasTableAdapter carrerasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPerro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPelaje;
        private System.Windows.Forms.Button botAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtTipoPelaje;
        private System.Windows.Forms.ComboBox cbRaza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botEditar;
        private System.Windows.Forms.Button botMostrarDatos;
        private System.Windows.Forms.Button botNuevo;
        private System.Windows.Forms.Button botEliminar;
        private System.Windows.Forms.Button botCancelar;
    }
}

