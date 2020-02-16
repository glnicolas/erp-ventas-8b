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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MarcaTB = new System.Windows.Forms.TextBox();
            this.ModeloTB = new System.Windows.Forms.TextBox();
            this.CapacidadTB = new System.Windows.Forms.NumericUpDown();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.AnioTB = new System.Windows.Forms.MaskedTextBox();
            this.PlacasTB = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(319, 74);
            this.panel1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Agregar Transporte";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(84, 95);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Placas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Año";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Capacidad";
            // 
            // MarcaTB
            // 
            this.MarcaTB.Location = new System.Drawing.Point(84, 173);
            this.MarcaTB.Name = "MarcaTB";
            this.MarcaTB.Size = new System.Drawing.Size(120, 20);
            this.MarcaTB.TabIndex = 25;
            // 
            // ModeloTB
            // 
            this.ModeloTB.Location = new System.Drawing.Point(84, 212);
            this.ModeloTB.Name = "ModeloTB";
            this.ModeloTB.Size = new System.Drawing.Size(120, 20);
            this.ModeloTB.TabIndex = 26;
            // 
            // CapacidadTB
            // 
            this.CapacidadTB.Location = new System.Drawing.Point(84, 291);
            this.CapacidadTB.Name = "CapacidadTB";
            this.CapacidadTB.Size = new System.Drawing.Size(120, 20);
            this.CapacidadTB.TabIndex = 28;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ERP_ventas.Properties.Resources.plus;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(18, 342);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(261, 38);
            this.btnNuevo.TabIndex = 29;
            this.btnNuevo.Tag = "Agregar nuevo registro";
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // AnioTB
            // 
            this.AnioTB.Location = new System.Drawing.Point(84, 252);
            this.AnioTB.Mask = "0000";
            this.AnioTB.Name = "AnioTB";
            this.AnioTB.Size = new System.Drawing.Size(120, 20);
            this.AnioTB.TabIndex = 30;
            this.AnioTB.ValidatingType = typeof(int);
            // 
            // PlacasTB
            // 
            this.PlacasTB.Location = new System.Drawing.Point(84, 135);
            this.PlacasTB.Mask = "aaa 00 00";
            this.PlacasTB.Name = "PlacasTB";
            this.PlacasTB.Size = new System.Drawing.Size(120, 20);
            this.PlacasTB.TabIndex = 31;
            // 
            // AddTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 450);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.panel1);
            this.Name = "AddTransporte";
            this.Text = "AddTransporte";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapacidadTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox MarcaTB;
        private System.Windows.Forms.TextBox ModeloTB;
        private System.Windows.Forms.NumericUpDown CapacidadTB;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.MaskedTextBox AnioTB;
        private System.Windows.Forms.MaskedTextBox PlacasTB;
    }
}