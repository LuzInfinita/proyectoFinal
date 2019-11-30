namespace BaseDatos2.Vistas
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botNuevo = new System.Windows.Forms.ToolStripButton();
            this.botEditar = new System.Windows.Forms.ToolStripButton();
            this.botEliminar = new System.Windows.Forms.ToolStripButton();
            this.botActualizar = new System.Windows.Forms.ToolStripButton();
            this.botCerrar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 45);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(703, 314);
            this.dgvProductos.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botNuevo,
            this.botEditar,
            this.botEliminar,
            this.botActualizar,
            this.botCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(727, 25);
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
            // 
            // botEditar
            // 
            this.botEditar.Image = ((System.Drawing.Image)(resources.GetObject("botEditar.Image")));
            this.botEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botEditar.Name = "botEditar";
            this.botEditar.Size = new System.Drawing.Size(57, 22);
            this.botEditar.Text = "Editar";
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
            // botActualizar
            // 
            this.botActualizar.Image = ((System.Drawing.Image)(resources.GetObject("botActualizar.Image")));
            this.botActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botActualizar.Name = "botActualizar";
            this.botActualizar.Size = new System.Drawing.Size(79, 22);
            this.botActualizar.Text = "Actualizar";
            this.botActualizar.Click += new System.EventHandler(this.botActualizar_Click);
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
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 387);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvProductos);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botNuevo;
        private System.Windows.Forms.ToolStripButton botEditar;
        private System.Windows.Forms.ToolStripButton botEliminar;
        private System.Windows.Forms.ToolStripButton botActualizar;
        private System.Windows.Forms.ToolStripButton botCerrar;
    }
}