namespace BaseDatos2.Vistas
{
    partial class AgregaEditaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregaEditaEmpleado));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botGuardar = new System.Windows.Forms.ToolStripButton();
            this.botCancelar = new System.Windows.Forms.ToolStripButton();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.MesFechaIngreso = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botGuardar,
            this.botCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(387, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // botGuardar
            // 
            this.botGuardar.Image = ((System.Drawing.Image)(resources.GetObject("botGuardar.Image")));
            this.botGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botGuardar.Name = "botGuardar";
            this.botGuardar.Size = new System.Drawing.Size(69, 22);
            this.botGuardar.Text = "Guardar";
            this.botGuardar.Click += new System.EventHandler(this.botGuardar_Click);
            // 
            // botCancelar
            // 
            this.botCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botCancelar.Image")));
            this.botCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botCancelar.Name = "botCancelar";
            this.botCancelar.Size = new System.Drawing.Size(73, 22);
            this.botCancelar.Text = "Cancelar";
            this.botCancelar.Click += new System.EventHandler(this.botCancelar_Click);
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Location = new System.Drawing.Point(100, 38);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.ReadOnly = true;
            this.txtIDEmpleado.Size = new System.Drawing.Size(169, 20);
            this.txtIDEmpleado.TabIndex = 1;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(100, 90);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(169, 20);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(100, 116);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(169, 20);
            this.txtSalario.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(100, 154);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(62, 17);
            this.chkActivo.TabIndex = 5;
            this.chkActivo.Text = "Activo?";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // MesFechaIngreso
            // 
            this.MesFechaIngreso.Location = new System.Drawing.Point(100, 183);
            this.MesFechaIngreso.Name = "MesFechaIngreso";
            this.MesFechaIngreso.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IDEmpleado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Salario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha Ingreso:";
            // 
            // AgregaEditaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 349);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MesFechaIngreso);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtIDEmpleado);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AgregaEditaEmpleado";
            this.Text = "AgregaEditaEmpleado";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botGuardar;
        private System.Windows.Forms.ToolStripButton botCancelar;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.MonthCalendar MesFechaIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}