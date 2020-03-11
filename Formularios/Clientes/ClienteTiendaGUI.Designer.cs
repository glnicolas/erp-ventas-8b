namespace ERP_ventas.Formularios.Clientes
{
    partial class ClienteTiendaGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.paginacionTabla = new System.Windows.Forms.DataGridView();
            this.siguienteBtn = new System.Windows.Forms.Button();
            this.anteriorBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.paginaxdey = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 74);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes Tienda";
            // 
            // paginacionTabla
            // 
            this.paginacionTabla.AllowUserToAddRows = false;
            this.paginacionTabla.AllowUserToDeleteRows = false;
            this.paginacionTabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paginacionTabla.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.paginacionTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paginacionTabla.Location = new System.Drawing.Point(0, 125);
            this.paginacionTabla.MultiSelect = false;
            this.paginacionTabla.Name = "paginacionTabla";
            this.paginacionTabla.ReadOnly = true;
            this.paginacionTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paginacionTabla.Size = new System.Drawing.Size(927, 426);
            this.paginacionTabla.TabIndex = 19;
            this.paginacionTabla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paginacionTabla_CellDoubleClick);
            this.paginacionTabla.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.paginacionTabla_DataBindingComplete);
            // 
            // siguienteBtn
            // 
            this.siguienteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siguienteBtn.Image = global::ERP_ventas.Properties.Resources.right_squared_32px;
            this.siguienteBtn.Location = new System.Drawing.Point(541, 557);
            this.siguienteBtn.Name = "siguienteBtn";
            this.siguienteBtn.Size = new System.Drawing.Size(30, 43);
            this.siguienteBtn.TabIndex = 21;
            this.siguienteBtn.UseVisualStyleBackColor = true;
            this.siguienteBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // anteriorBtn
            // 
            this.anteriorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anteriorBtn.Enabled = false;
            this.anteriorBtn.Image = global::ERP_ventas.Properties.Resources.back_32px;
            this.anteriorBtn.Location = new System.Drawing.Point(375, 557);
            this.anteriorBtn.Name = "anteriorBtn";
            this.anteriorBtn.Size = new System.Drawing.Size(30, 43);
            this.anteriorBtn.TabIndex = 20;
            this.anteriorBtn.UseVisualStyleBackColor = true;
            this.anteriorBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ERP_ventas.Properties.Resources.eliminar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(122, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 18;
            this.button1.Tag = "Agregar nuevo registro";
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Image = global::ERP_ventas.Properties.Resources.plus;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(18, 80);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 39);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // paginaxdey
            // 
            this.paginaxdey.AutoSize = true;
            this.paginaxdey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paginaxdey.Location = new System.Drawing.Point(435, 567);
            this.paginaxdey.Name = "paginaxdey";
            this.paginaxdey.Size = new System.Drawing.Size(59, 20);
            this.paginaxdey.TabIndex = 22;
            this.paginaxdey.Text = "1 de 2";
            // 
            // ClienteTiendaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 607);
            this.Controls.Add(this.paginaxdey);
            this.Controls.Add(this.siguienteBtn);
            this.Controls.Add(this.anteriorBtn);
            this.Controls.Add(this.paginacionTabla);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregar);
            this.Name = "ClienteTiendaGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClienteTienda";
            this.Load += new System.EventHandler(this.ClienteTienda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView paginacionTabla;
        private System.Windows.Forms.Button anteriorBtn;
        private System.Windows.Forms.Button siguienteBtn;
        private System.Windows.Forms.Label paginaxdey;
    }
}