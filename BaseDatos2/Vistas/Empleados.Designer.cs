namespace BaseDatos2
{
    partial class Empleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.IDEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asdfasdf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sadfsadf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botNuevo = new System.Windows.Forms.ToolStripButton();
            this.botEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.botEliminar = new System.Windows.Forms.ToolStripButton();
            this.botCerrar = new System.Windows.Forms.ToolStripButton();
            this.botObtiene = new System.Windows.Forms.ToolStripButton();
            this.txtNumeroEmpleado = new System.Windows.Forms.ToolStripTextBox();
            this.botActualizar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEmpleado,
            this.Nombre,
            this.Apellidos,
            this.Activo,
            this.Salario,
            this.FechaIngreso,
            this.asdfasdf,
            this.sadfsadf});
            this.dgvEmpleados.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 38);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(684, 265);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // IDEmpleado
            // 
            this.IDEmpleado.HeaderText = "IDEmpleado";
            this.IDEmpleado.Name = "IDEmpleado";
            this.IDEmpleado.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            // 
            // Salario
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Salario.DefaultCellStyle = dataGridViewCellStyle2;
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "Fecha Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            // 
            // asdfasdf
            // 
            this.asdfasdf.HeaderText = "asfdsadf";
            this.asdfasdf.Name = "asdfasdf";
            this.asdfasdf.ReadOnly = true;
            // 
            // sadfsadf
            // 
            this.sadfsadf.HeaderText = "Column1sdafasdfa";
            this.sadfsadf.Name = "sadfsadf";
            this.sadfsadf.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botNuevo,
            this.botEditar,
            this.toolStripSeparator2,
            this.botEliminar,
            this.botCerrar,
            this.botObtiene,
            this.txtNumeroEmpleado,
            this.botActualizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(708, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // botNuevo
            // 
            this.botNuevo.Image = ((System.Drawing.Image)(resources.GetObject("botNuevo.Image")));
            this.botNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botNuevo.Name = "botNuevo";
            this.botNuevo.Size = new System.Drawing.Size(62, 22);
            this.botNuevo.Text = "Nuevo";
            this.botNuevo.Click += new System.EventHandler(this.botNuevo_Click);
            // 
            // botEditar
            // 
            this.botEditar.Image = ((System.Drawing.Image)(resources.GetObject("botEditar.Image")));
            this.botEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botEditar.Name = "botEditar";
            this.botEditar.Size = new System.Drawing.Size(57, 22);
            this.botEditar.Text = "Editar";
            this.botEditar.Click += new System.EventHandler(this.botEditar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // botEliminar
            // 
            this.botEliminar.Image = ((System.Drawing.Image)(resources.GetObject("botEliminar.Image")));
            this.botEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botEliminar.Name = "botEliminar";
            this.botEliminar.Size = new System.Drawing.Size(70, 22);
            this.botEliminar.Text = "Eliminar";
            this.botEliminar.Click += new System.EventHandler(this.botEliminar_Click);
            // 
            // botCerrar
            // 
            this.botCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.botCerrar.Image = ((System.Drawing.Image)(resources.GetObject("botCerrar.Image")));
            this.botCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botCerrar.Name = "botCerrar";
            this.botCerrar.Size = new System.Drawing.Size(59, 22);
            this.botCerrar.Text = "Cerrar";
            this.botCerrar.Click += new System.EventHandler(this.botCerrar_Click);
            // 
            // botObtiene
            // 
            this.botObtiene.Image = ((System.Drawing.Image)(resources.GetObject("botObtiene.Image")));
            this.botObtiene.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botObtiene.Name = "botObtiene";
            this.botObtiene.Size = new System.Drawing.Size(130, 22);
            this.botObtiene.Text = "Obtiene Empleados";
            this.botObtiene.Click += new System.EventHandler(this.botObtiene_Click);
            // 
            // txtNumeroEmpleado
            // 
            this.txtNumeroEmpleado.Name = "txtNumeroEmpleado";
            this.txtNumeroEmpleado.Size = new System.Drawing.Size(100, 25);
            // 
            // botActualizar
            // 
            this.botActualizar.Image = ((System.Drawing.Image)(resources.GetObject("botActualizar.Image")));
            this.botActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botActualizar.Name = "botActualizar";
            this.botActualizar.Size = new System.Drawing.Size(79, 22);
            this.botActualizar.Text = "Actualizar";
            this.botActualizar.Click += new System.EventHandler(this.botActualizar_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 315);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botNuevo;
        private System.Windows.Forms.ToolStripButton botEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton botEliminar;
        private System.Windows.Forms.ToolStripButton botCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn asdfasdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn sadfsadf;
        private System.Windows.Forms.ToolStripButton botObtiene;
        private System.Windows.Forms.ToolStripTextBox txtNumeroEmpleado;
        private System.Windows.Forms.ToolStripButton botActualizar;
    }
}