namespace ERP_ventas
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnEnvios = new System.Windows.Forms.Button();
            this.btnTransporte = new System.Windows.Forms.Button();
            this.btnOfertas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 74);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(606, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Módulo ventas";
            // 
            // btnVentas
            // 
            this.btnVentas.BackgroundImage = global::ERP_ventas.Properties.Resources.Sector_1;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.Location = new System.Drawing.Point(84, 107);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(259, 113);
            this.btnVentas.TabIndex = 9;
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnEnvios
            // 
            this.btnEnvios.BackColor = System.Drawing.Color.Transparent;
            this.btnEnvios.BackgroundImage = global::ERP_ventas.Properties.Resources.Sector_5;
            this.btnEnvios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnvios.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEnvios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnvios.Location = new System.Drawing.Point(84, 388);
            this.btnEnvios.Name = "btnEnvios";
            this.btnEnvios.Size = new System.Drawing.Size(259, 113);
            this.btnEnvios.TabIndex = 7;
            this.btnEnvios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnvios.UseVisualStyleBackColor = false;
            // 
            // btnTransporte
            // 
            this.btnTransporte.BackColor = System.Drawing.Color.Transparent;
            this.btnTransporte.BackgroundImage = global::ERP_ventas.Properties.Resources.Sector_4;
            this.btnTransporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTransporte.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransporte.Location = new System.Drawing.Point(450, 246);
            this.btnTransporte.Name = "btnTransporte";
            this.btnTransporte.Size = new System.Drawing.Size(259, 113);
            this.btnTransporte.TabIndex = 6;
            this.btnTransporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransporte.UseVisualStyleBackColor = false;
            this.btnTransporte.Click += new System.EventHandler(this.btnTransporte_Click);
            // 
            // btnOfertas
            // 
            this.btnOfertas.BackColor = System.Drawing.Color.Transparent;
            this.btnOfertas.BackgroundImage = global::ERP_ventas.Properties.Resources.Sector_3;
            this.btnOfertas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOfertas.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnOfertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfertas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOfertas.Location = new System.Drawing.Point(84, 246);
            this.btnOfertas.Name = "btnOfertas";
            this.btnOfertas.Size = new System.Drawing.Size(259, 113);
            this.btnOfertas.TabIndex = 5;
            this.btnOfertas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOfertas.UseVisualStyleBackColor = false;
            this.btnOfertas.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackgroundImage = global::ERP_ventas.Properties.Resources.Sector_2;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(450, 107);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(259, 113);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 74);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(3, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(474, 37);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "[USUARIO]";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblFechaHora, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUsuario, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(66, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 74);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFechaHora.Location = new System.Drawing.Point(3, 37);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFechaHora.Size = new System.Drawing.Size(474, 37);
            this.lblFechaHora.TabIndex = 4;
            this.lblFechaHora.Text = "[FECHA - HORA]";
            this.lblFechaHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 532);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnEnvios);
            this.Controls.Add(this.btnTransporte);
            this.Controls.Add(this.btnOfertas);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.panel1);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.Click += new System.EventHandler(this.MenuPrincipal_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnOfertas;
        private System.Windows.Forms.Button btnTransporte;
        private System.Windows.Forms.Button btnEnvios;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFechaHora;
    }
}

