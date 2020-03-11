namespace ERP_ventas.Formularios.Envios
{
    partial class AddTransporte
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MarcaTB = new System.Windows.Forms.TextBox();
            this.ModeloTB = new System.Windows.Forms.TextBox();
            this.CapacidadTB = new System.Windows.Forms.NumericUpDown();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.AnioTB = new System.Windows.Forms.MaskedTextBox();
            this.PlacasTB = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.modificarButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CapacidadTB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 74);
            this.panel1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(8, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Agregar Transporte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Placas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Año";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Capacidad (Kg)";
            // 
            // MarcaTB
            // 
            this.MarcaTB.Location = new System.Drawing.Point(135, 128);
            this.MarcaTB.Name = "MarcaTB";
            this.MarcaTB.Size = new System.Drawing.Size(120, 20);
            this.MarcaTB.TabIndex = 25;
            // 
            // ModeloTB
            // 
            this.ModeloTB.Location = new System.Drawing.Point(135, 167);
            this.ModeloTB.Name = "ModeloTB";
            this.ModeloTB.Size = new System.Drawing.Size(120, 20);
            this.ModeloTB.TabIndex = 26;
            // 
            // CapacidadTB
            // 
            this.CapacidadTB.Location = new System.Drawing.Point(135, 245);
            this.CapacidadTB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CapacidadTB.Name = "CapacidadTB";
            this.CapacidadTB.Size = new System.Drawing.Size(120, 20);
            this.CapacidadTB.TabIndex = 28;
            this.CapacidadTB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ERP_ventas.Properties.Resources.save_24px;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(177, 302);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(78, 38);
            this.btnNuevo.TabIndex = 29;
            this.btnNuevo.Tag = "Agregar nuevo registro";
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // AnioTB
            // 
            this.AnioTB.Location = new System.Drawing.Point(135, 206);
            this.AnioTB.Mask = "0000";
            this.AnioTB.Name = "AnioTB";
            this.AnioTB.Size = new System.Drawing.Size(120, 20);
            this.AnioTB.TabIndex = 30;
            this.AnioTB.ValidatingType = typeof(int);
            // 
            // PlacasTB
            // 
            this.PlacasTB.Location = new System.Drawing.Point(135, 89);
            this.PlacasTB.Mask = "aaa 00 00";
            this.PlacasTB.Name = "PlacasTB";
            this.PlacasTB.Size = new System.Drawing.Size(120, 20);
            this.PlacasTB.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(35, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 38);
            this.button1.TabIndex = 32;
            this.button1.Tag = "Agregar nuevo registro";
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modificarButton
            // 
            this.modificarButton.Image = global::ERP_ventas.Properties.Resources.editar2;
            this.modificarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarButton.Location = new System.Drawing.Point(177, 287);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(78, 38);
            this.modificarButton.TabIndex = 33;
            this.modificarButton.Tag = "Agregar nuevo registro";
            this.modificarButton.Text = "Modificar";
            this.modificarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 364);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlacasTB);
            this.Controls.Add(this.AnioTB);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.CapacidadTB);
            this.Controls.Add(this.ModeloTB);
            this.Controls.Add(this.MarcaTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "AddTransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddTransporte";
            this.Load += new System.EventHandler(this.AddTransporte_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CapacidadTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MarcaTB;
        private System.Windows.Forms.TextBox ModeloTB;
        private System.Windows.Forms.NumericUpDown CapacidadTB;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.MaskedTextBox AnioTB;
        private System.Windows.Forms.MaskedTextBox PlacasTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button modificarButton;
    }
}