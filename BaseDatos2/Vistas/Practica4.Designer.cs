namespace BaseDatos2.Vistas
{
    partial class Practica4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Practica4));
            this.Servicio = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.btnObtener = new System.Windows.Forms.ToolStripButton();
            this.txtNumerito = new System.Windows.Forms.ToolStripTextBox();
            this.btnActualiza = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.Servicio)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Servicio
            // 
            this.Servicio.AllowUserToAddRows = false;
            this.Servicio.AllowUserToDeleteRows = false;
            this.Servicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Servicio.Location = new System.Drawing.Point(23, 117);
            this.Servicio.Name = "Servicio";
            this.Servicio.ReadOnly = true;
            this.Servicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Servicio.Size = new System.Drawing.Size(616, 277);
            this.Servicio.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnEliminar,
            this.btnCerrar,
            this.btnObtener,
            this.txtNumerito,
            this.btnActualiza});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(667, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 22);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(59, 22);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnObtener
            // 
            this.btnObtener.Image = ((System.Drawing.Image)(resources.GetObject("btnObtener.Image")));
            this.btnObtener.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(70, 22);
            this.btnObtener.Text = "Obtener";
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // txtNumerito
            // 
            this.txtNumerito.Name = "txtNumerito";
            this.txtNumerito.Size = new System.Drawing.Size(100, 25);
            // 
            // btnActualiza
            // 
            this.btnActualiza.Image = ((System.Drawing.Image)(resources.GetObject("btnActualiza.Image")));
            this.btnActualiza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualiza.Name = "btnActualiza";
            this.btnActualiza.Size = new System.Drawing.Size(79, 22);
            this.btnActualiza.Text = "Actualizar";
            this.btnActualiza.Click += new System.EventHandler(this.btnActualiza_Click);
            // 
            // Practica4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 406);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Servicio);
            this.Name = "Practica4";
            this.Text = "Practica4";
            this.Load += new System.EventHandler(this.btnActualiza_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Servicio)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Servicio;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnActualiza;
        private System.Windows.Forms.ToolStripButton btnCerrar;
        private System.Windows.Forms.ToolStripButton btnObtener;
        private System.Windows.Forms.ToolStripTextBox txtNumerito;
    }
}