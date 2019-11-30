namespace BaseDatos2.Vistas
{
    partial class AgregaEditaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregaEditaCliente));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botGuardar = new System.Windows.Forms.ToolStripButton();
            this.botCancelar = new System.Windows.Forms.ToolStripButton();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtNumeroHijos = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
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
            this.toolStrip1.Size = new System.Drawing.Size(231, 25);
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
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(104, 45);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.ReadOnly = true;
            this.txtIDCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIDCliente.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(104, 96);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(104, 122);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 4;
            // 
            // txtNumeroHijos
            // 
            this.txtNumeroHijos.Location = new System.Drawing.Point(104, 148);
            this.txtNumeroHijos.Name = "txtNumeroHijos";
            this.txtNumeroHijos.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroHijos.TabIndex = 5;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(104, 174);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(62, 17);
            this.chkActivo.TabIndex = 6;
            this.chkActivo.Text = "Activo?";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IDCliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Salario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Número hijos:";
            // 
            // AgregaEditaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 217);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtNumeroHijos);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AgregaEditaCliente";
            this.Text = "AgregaEditaCliente";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botGuardar;
        private System.Windows.Forms.ToolStripButton botCancelar;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtNumeroHijos;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}