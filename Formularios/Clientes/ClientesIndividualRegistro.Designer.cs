namespace ERP_ventas.Formularios.Clientes
{
    partial class ClientesIndividualRegistro
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
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.rdtFemenino = new System.Windows.Forms.RadioButton();
            this.rdtMasculino = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAMaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAPaterno = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.rdtFemenino);
            this.groupBoxSexo.Controls.Add(this.rdtMasculino);
            this.groupBoxSexo.Location = new System.Drawing.Point(50, 129);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(161, 74);
            this.groupBoxSexo.TabIndex = 10;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "Sexo";
            // 
            // rdtFemenino
            // 
            this.rdtFemenino.AutoSize = true;
            this.rdtFemenino.Location = new System.Drawing.Point(6, 42);
            this.rdtFemenino.Name = "rdtFemenino";
            this.rdtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdtFemenino.TabIndex = 0;
            this.rdtFemenino.Text = "Femenino";
            this.rdtFemenino.UseVisualStyleBackColor = true;
            // 
            // rdtMasculino
            // 
            this.rdtMasculino.AutoSize = true;
            this.rdtMasculino.Checked = true;
            this.rdtMasculino.Location = new System.Drawing.Point(6, 19);
            this.rdtMasculino.Name = "rdtMasculino";
            this.rdtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdtMasculino.TabIndex = 0;
            this.rdtMasculino.TabStop = true;
            this.rdtMasculino.Text = "Masculino";
            this.rdtMasculino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido Materno";
            // 
            // txtAMaterno
            // 
            this.txtAMaterno.Location = new System.Drawing.Point(121, 87);
            this.txtAMaterno.Name = "txtAMaterno";
            this.txtAMaterno.Size = new System.Drawing.Size(129, 20);
            this.txtAMaterno.TabIndex = 4;
            this.txtAMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido Paterno";
            // 
            // txtAPaterno
            // 
            this.txtAPaterno.Location = new System.Drawing.Point(121, 55);
            this.txtAPaterno.Name = "txtAPaterno";
            this.txtAPaterno.Size = new System.Drawing.Size(129, 20);
            this.txtAPaterno.TabIndex = 5;
            this.txtAPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::ERP_ventas.Properties.Resources.save_24px;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(177, 225);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(73, 38);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Tag = "Agregar nuevo registro";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ERP_ventas.Properties.Resources.delete_sign_32px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(18, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 38);
            this.button1.TabIndex = 12;
            this.button1.Tag = "Agregar nuevo registro";
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientesIndividualRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 274);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBoxSexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAMaterno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAPaterno);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Name = "ClientesIndividualRegistro";
            this.Text = "ClientesIndividualRegistro";
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.RadioButton rdtFemenino;
        private System.Windows.Forms.RadioButton rdtMasculino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAMaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
    }
}