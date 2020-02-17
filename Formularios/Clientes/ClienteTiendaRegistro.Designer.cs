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
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.NumCredito = new System.Windows.Forms.NumericUpDown();
            this.ComboEstatus = new System.Windows.Forms.ComboBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.comboCiuadad = new System.Windows.Forms.ComboBox();
            this.MtxtEmail = new System.Windows.Forms.MaskedTextBox();
            this.MtxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.MtxtRFC = new System.Windows.Forms.MaskedTextBox();
            this.MtxtCodigoPostal = new System.Windows.Forms.MaskedTextBox();
            this.MtxtDireccion = new System.Windows.Forms.MaskedTextBox();
            this.MtxtContacto = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MtxtNombre = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.modificarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumCredito)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Image = global::ERP_ventas.Properties.Resources.save_24px;
            this.btnAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCliente.Location = new System.Drawing.Point(33, 426);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(94, 39);
            this.btnAgregarCliente.TabIndex = 52;
            this.btnAgregarCliente.Text = "Guardar";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // NumCredito
            // 
            this.NumCredito.DecimalPlaces = 2;
            this.NumCredito.Location = new System.Drawing.Point(184, 162);
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
            this.NumCredito.Size = new System.Drawing.Size(69, 20);
            this.NumCredito.TabIndex = 51;
            this.NumCredito.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ComboEstatus
            // 
            this.ComboEstatus.FormattingEnabled = true;
            this.ComboEstatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.ComboEstatus.Location = new System.Drawing.Point(132, 473);
            this.ComboEstatus.Name = "ComboEstatus";
            this.ComboEstatus.Size = new System.Drawing.Size(121, 21);
            this.ComboEstatus.TabIndex = 50;
            this.ComboEstatus.Visible = false;
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(133, 500);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(121, 21);
            this.comboTipo.TabIndex = 49;
            this.comboTipo.Visible = false;
            // 
            // comboCiuadad
            // 
            this.comboCiuadad.FormattingEnabled = true;
            this.comboCiuadad.Location = new System.Drawing.Point(133, 383);
            this.comboCiuadad.Name = "comboCiuadad";
            this.comboCiuadad.Size = new System.Drawing.Size(121, 21);
            this.comboCiuadad.TabIndex = 48;
            // 
            // MtxtEmail
            // 
            this.MtxtEmail.Location = new System.Drawing.Point(115, 347);
            this.MtxtEmail.Name = "MtxtEmail";
            this.MtxtEmail.Size = new System.Drawing.Size(140, 20);
            this.MtxtEmail.TabIndex = 47;
            // 
            // MtxtTelefono
            // 
            this.MtxtTelefono.Location = new System.Drawing.Point(137, 312);
            this.MtxtTelefono.Name = "MtxtTelefono";
            this.MtxtTelefono.Size = new System.Drawing.Size(118, 20);
            this.MtxtTelefono.TabIndex = 46;
            // 
            // MtxtRFC
            // 
            this.MtxtRFC.Location = new System.Drawing.Point(101, 272);
            this.MtxtRFC.Name = "MtxtRFC";
            this.MtxtRFC.Size = new System.Drawing.Size(154, 20);
            this.MtxtRFC.TabIndex = 45;
            // 
            // MtxtCodigoPostal
            // 
            this.MtxtCodigoPostal.Location = new System.Drawing.Point(195, 234);
            this.MtxtCodigoPostal.Name = "MtxtCodigoPostal";
            this.MtxtCodigoPostal.Size = new System.Drawing.Size(60, 20);
            this.MtxtCodigoPostal.TabIndex = 44;
            // 
            // MtxtDireccion
            // 
            this.MtxtDireccion.Location = new System.Drawing.Point(149, 198);
            this.MtxtDireccion.Name = "MtxtDireccion";
            this.MtxtDireccion.Size = new System.Drawing.Size(108, 20);
            this.MtxtDireccion.TabIndex = 43;
            // 
            // MtxtContacto
            // 
            this.MtxtContacto.Location = new System.Drawing.Point(148, 128);
            this.MtxtContacto.Name = "MtxtContacto";
            this.MtxtContacto.Size = new System.Drawing.Size(106, 20);
            this.MtxtContacto.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(40, 380);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 24);
            this.label14.TabIndex = 41;
            this.label14.Text = "Ciudad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 497);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 24);
            this.label13.TabIndex = 40;
            this.label13.Text = "Tipo:";
            this.label13.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(37, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 24);
            this.label12.TabIndex = 39;
            this.label12.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 24);
            this.label11.TabIndex = 38;
            this.label11.Text = "Telefono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 24);
            this.label10.TabIndex = 37;
            this.label10.Text = "RFC:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "Codigo Postal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "Direccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Estatus:";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Limite credito:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Contacto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nombre:";
            // 
            // MtxtNombre
            // 
            this.MtxtNombre.Location = new System.Drawing.Point(136, 91);
            this.MtxtNombre.Name = "MtxtNombre";
            this.MtxtNombre.Size = new System.Drawing.Size(118, 20);
            this.MtxtNombre.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 74);
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
            this.modificarBtn.Location = new System.Drawing.Point(184, 428);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(94, 39);
            this.modificarBtn.TabIndex = 54;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modificarBtn.UseVisualStyleBackColor = true;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // ClienteTiendaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 484);
            this.Controls.Add(this.modificarBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.NumCredito);
            this.Controls.Add(this.ComboEstatus);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.comboCiuadad);
            this.Controls.Add(this.MtxtEmail);
            this.Controls.Add(this.MtxtTelefono);
            this.Controls.Add(this.MtxtRFC);
            this.Controls.Add(this.MtxtCodigoPostal);
            this.Controls.Add(this.MtxtDireccion);
            this.Controls.Add(this.MtxtContacto);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MtxtNombre);
            this.Name = "ClienteTiendaRegistro";
            this.Text = "ClienteTiendaRegistro";
            this.Load += new System.EventHandler(this.ClienteTiendaRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumCredito)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.NumericUpDown NumCredito;
        private System.Windows.Forms.ComboBox ComboEstatus;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.ComboBox comboCiuadad;
        private System.Windows.Forms.MaskedTextBox MtxtEmail;
        private System.Windows.Forms.MaskedTextBox MtxtTelefono;
        private System.Windows.Forms.MaskedTextBox MtxtRFC;
        private System.Windows.Forms.MaskedTextBox MtxtCodigoPostal;
        private System.Windows.Forms.MaskedTextBox MtxtDireccion;
        private System.Windows.Forms.MaskedTextBox MtxtContacto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MtxtNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modificarBtn;
    }
}