namespace ERP_ventas.Formularios.Clientes
{
    partial class ClienteTiendaRegistro
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
            this.NumCredito = new System.Windows.Forms.NumericUpDown();
            this.MtxtEmail = new System.Windows.Forms.MaskedTextBox();
            this.MtxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.MtxtRFC = new System.Windows.Forms.MaskedTextBox();
            this.MtxtCodigoPostal = new System.Windows.Forms.MaskedTextBox();
            this.MtxtContacto = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MtxtNombre = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.comboBoxCiudad = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MtxtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumCredito)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumCredito
            // 
            this.NumCredito.Location = new System.Drawing.Point(183, 203);
            this.NumCredito.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumCredito.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCredito.Name = "NumCredito";
            this.NumCredito.Size = new System.Drawing.Size(121, 26);
            this.NumCredito.TabIndex = 51;
            this.NumCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumCredito.ThousandsSeparator = true;
            this.NumCredito.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MtxtEmail
            // 
            this.MtxtEmail.Location = new System.Drawing.Point(183, 167);
            this.MtxtEmail.Name = "MtxtEmail";
            this.MtxtEmail.Size = new System.Drawing.Size(162, 26);
            this.MtxtEmail.TabIndex = 47;
            this.MtxtEmail.Leave += new System.EventHandler(this.MtxtEmail_Leave);
            // 
            // MtxtTelefono
            // 
            this.MtxtTelefono.Location = new System.Drawing.Point(183, 128);
            this.MtxtTelefono.Mask = "000-000-0000";
            this.MtxtTelefono.Name = "MtxtTelefono";
            this.MtxtTelefono.Size = new System.Drawing.Size(121, 26);
            this.MtxtTelefono.TabIndex = 46;
            // 
            // MtxtRFC
            // 
            this.MtxtRFC.Location = new System.Drawing.Point(183, 96);
            this.MtxtRFC.Mask = "LLL000000LLL";
            this.MtxtRFC.Name = "MtxtRFC";
            this.MtxtRFC.Size = new System.Drawing.Size(121, 26);
            this.MtxtRFC.TabIndex = 45;
            this.MtxtRFC.Leave += new System.EventHandler(this.MtxtRFC_Leave);
            // 
            // MtxtCodigoPostal
            // 
            this.MtxtCodigoPostal.Location = new System.Drawing.Point(235, 40);
            this.MtxtCodigoPostal.Mask = "00000";
            this.MtxtCodigoPostal.Name = "MtxtCodigoPostal";
            this.MtxtCodigoPostal.Size = new System.Drawing.Size(57, 26);
            this.MtxtCodigoPostal.TabIndex = 44;
            // 
            // MtxtContacto
            // 
            this.MtxtContacto.Location = new System.Drawing.Point(183, 61);
            this.MtxtContacto.Name = "MtxtContacto";
            this.MtxtContacto.Size = new System.Drawing.Size(162, 26);
            this.MtxtContacto.TabIndex = 42;
            this.MtxtContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MtxtContacto_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 24);
            this.label14.TabIndex = 41;
            this.label14.Text = "Ciudad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 24);
            this.label12.TabIndex = 39;
            this.label12.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 24);
            this.label11.TabIndex = 38;
            this.label11.Text = "Telefono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 24);
            this.label10.TabIndex = 37;
            this.label10.Text = "RFC:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "Codigo Postal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Contacto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nombre:";
            // 
            // MtxtNombre
            // 
            this.MtxtNombre.Location = new System.Drawing.Point(183, 29);
            this.MtxtNombre.Name = "MtxtNombre";
            this.MtxtNombre.Size = new System.Drawing.Size(162, 26);
            this.MtxtNombre.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 74);
            this.panel1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Cliente Tienda";
            // 
            // modificarBtn
            // 
            this.modificarBtn.Image = global::ERP_ventas.Properties.Resources.save_24px;
            this.modificarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarBtn.Location = new System.Drawing.Point(612, 343);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(94, 39);
            this.modificarBtn.TabIndex = 54;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modificarBtn.UseVisualStyleBackColor = true;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Image = global::ERP_ventas.Properties.Resources.save_24px;
            this.btnAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCliente.Location = new System.Drawing.Point(612, 343);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(94, 39);
            this.btnAgregarCliente.TabIndex = 52;
            this.btnAgregarCliente.Text = "Guardar";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // comboBoxCiudad
            // 
            this.comboBoxCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCiudad.FormattingEnabled = true;
            this.comboBoxCiudad.Location = new System.Drawing.Point(135, 178);
            this.comboBoxCiudad.Name = "comboBoxCiudad";
            this.comboBoxCiudad.Size = new System.Drawing.Size(157, 28);
            this.comboBoxCiudad.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MtxtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MtxtContacto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MtxtEmail);
            this.groupBox1.Controls.Add(this.MtxtTelefono);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.NumCredito);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.MtxtRFC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 242);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la tienda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MtxtDireccion);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBoxCiudad);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.MtxtCodigoPostal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(392, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 242);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Domicilio";
            // 
            // MtxtDireccion
            // 
            this.MtxtDireccion.Location = new System.Drawing.Point(135, 83);
            this.MtxtDireccion.Multiline = true;
            this.MtxtDireccion.Name = "MtxtDireccion";
            this.MtxtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MtxtDireccion.Size = new System.Drawing.Size(157, 74);
            this.MtxtDireccion.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Limite credito:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ClienteTiendaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 389);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.modificarBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregarCliente);
            this.Name = "ClienteTiendaRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClienteTiendaRegistro";
            this.Load += new System.EventHandler(this.ClienteTiendaRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumCredito)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.NumericUpDown NumCredito;
        private System.Windows.Forms.MaskedTextBox MtxtEmail;
        private System.Windows.Forms.MaskedTextBox MtxtTelefono;
        private System.Windows.Forms.MaskedTextBox MtxtRFC;
        private System.Windows.Forms.MaskedTextBox MtxtCodigoPostal;
        private System.Windows.Forms.MaskedTextBox MtxtContacto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MtxtNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.ComboBox comboBoxCiudad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox MtxtDireccion;
        private System.Windows.Forms.Label label6;
    }
}