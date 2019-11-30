namespace BaseDatos2.Vistas
{
    partial class AgregaEditaPracticas4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregaEditaPracticas4));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIDServicio = new System.Windows.Forms.TextBox();
            this.textBoxNombreServicio = new System.Windows.Forms.TextBox();
            this.textBoxIDEmpleado = new System.Windows.Forms.TextBox();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Servicios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del Servicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Activo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID Empleado:";
            // 
            // textBoxIDServicio
            // 
            this.textBoxIDServicio.Location = new System.Drawing.Point(85, 48);
            this.textBoxIDServicio.Name = "textBoxIDServicio";
            this.textBoxIDServicio.ReadOnly = true;
            this.textBoxIDServicio.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDServicio.TabIndex = 6;
            // 
            // textBoxNombreServicio
            // 
            this.textBoxNombreServicio.Location = new System.Drawing.Point(123, 100);
            this.textBoxNombreServicio.Name = "textBoxNombreServicio";
            this.textBoxNombreServicio.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreServicio.TabIndex = 8;
            // 
            // textBoxIDEmpleado
            // 
            this.textBoxIDEmpleado.Location = new System.Drawing.Point(85, 74);
            this.textBoxIDEmpleado.Name = "textBoxIDEmpleado";
            this.textBoxIDEmpleado.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDEmpleado.TabIndex = 9;
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.Location = new System.Drawing.Point(64, 133);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(15, 14);
            this.checkBoxActivo.TabIndex = 10;
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // AgregaEditaPracticas4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.checkBoxActivo);
            this.Controls.Add(this.textBoxIDEmpleado);
            this.Controls.Add(this.textBoxNombreServicio);
            this.Controls.Add(this.textBoxIDServicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AgregaEditaPracticas4";
            this.Text = "AgregaEditaPracticas4";
            this.Load += new System.EventHandler(this.AgregaEditaPracticas4_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIDServicio;
        private System.Windows.Forms.TextBox textBoxNombreServicio;
        private System.Windows.Forms.TextBox textBoxIDEmpleado;
        private System.Windows.Forms.CheckBox checkBoxActivo;
    }
}