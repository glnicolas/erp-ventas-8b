namespace ERP_ventas.Formularios
{
    partial class SubMClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubMClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClienteTienda = new System.Windows.Forms.Button();
            this.btnClienteIndividual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 65);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(280, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Clientes";
            // 
            // btnClienteTienda
            // 
            this.btnClienteTienda.BackColor = System.Drawing.Color.Transparent;
            this.btnClienteTienda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClienteTienda.BackgroundImage")));
            this.btnClienteTienda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClienteTienda.Location = new System.Drawing.Point(24, 98);
            this.btnClienteTienda.Name = "btnClienteTienda";
            this.btnClienteTienda.Size = new System.Drawing.Size(140, 120);
            this.btnClienteTienda.TabIndex = 1;
            this.btnClienteTienda.UseVisualStyleBackColor = false;
            this.btnClienteTienda.Click += new System.EventHandler(this.btnClienteTienda_Click);
            // 
            // btnClienteIndividual
            // 
            this.btnClienteIndividual.BackColor = System.Drawing.Color.Transparent;
            this.btnClienteIndividual.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClienteIndividual.BackgroundImage")));
            this.btnClienteIndividual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClienteIndividual.Location = new System.Drawing.Point(229, 98);
            this.btnClienteIndividual.Name = "btnClienteIndividual";
            this.btnClienteIndividual.Size = new System.Drawing.Size(140, 120);
            this.btnClienteIndividual.TabIndex = 2;
            this.btnClienteIndividual.UseVisualStyleBackColor = false;
            this.btnClienteIndividual.Click += new System.EventHandler(this.btnClienteIndividual_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente tienda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente individual";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SubMClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClienteIndividual);
            this.Controls.Add(this.btnClienteTienda);
            this.Controls.Add(this.panel1);
            this.Name = "SubMClientes";
            this.Text = "SubMClientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClienteTienda;
        private System.Windows.Forms.Button btnClienteIndividual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}