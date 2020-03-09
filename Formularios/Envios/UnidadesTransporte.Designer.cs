namespace ERP_ventas.Formularios.Envios
{
    partial class UnidadesTransporte
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
            this.dataGridViewtransportes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.paginaxdey = new System.Windows.Forms.Label();
            this.siguienteBtn = new System.Windows.Forms.Button();
            this.anteriorBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtransportes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewtransportes
            // 
            this.dataGridViewtransportes.AllowUserToAddRows = false;
            this.dataGridViewtransportes.AllowUserToDeleteRows = false;
            this.dataGridViewtransportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtransportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Placas,
            this.Marca,
            this.Modelo,
            this.Anio,
            this.Capacidad,
            this.Estatus});
            this.dataGridViewtransportes.Location = new System.Drawing.Point(0, 130);
            this.dataGridViewtransportes.MultiSelect = false;
            this.dataGridViewtransportes.Name = "dataGridViewtransportes";
            this.dataGridViewtransportes.ReadOnly = true;
            this.dataGridViewtransportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewtransportes.Size = new System.Drawing.Size(856, 297);
            this.dataGridViewtransportes.TabIndex = 13;
            this.dataGridViewtransportes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtransportes_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Placas
            // 
            this.Placas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Placas.HeaderText = "Placas";
            this.Placas.Name = "Placas";
            this.Placas.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Anio
            // 
            this.Anio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Anio.HeaderText = "Año";
            this.Anio.Name = "Anio";
            this.Anio.ReadOnly = true;
            // 
            // Capacidad
            // 
            this.Capacidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.ReadOnly = true;
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            this.Estatus.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Unidades Transporte";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 74);
            this.panel1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Unidades Transporte";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ERP_ventas.Properties.Resources.plus;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(12, 80);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(123, 35);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Tag = "Agregar nuevo registro";
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ERP_ventas.Properties.Resources.eliminar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(141, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 35);
            this.button1.TabIndex = 17;
            this.button1.Tag = "Agregar nuevo registro";
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // paginaxdey
            // 
            this.paginaxdey.AutoSize = true;
            this.paginaxdey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paginaxdey.Location = new System.Drawing.Point(376, 451);
            this.paginaxdey.Name = "paginaxdey";
            this.paginaxdey.Size = new System.Drawing.Size(59, 20);
            this.paginaxdey.TabIndex = 25;
            this.paginaxdey.Text = "1 de 2";
            // 
            // siguienteBtn
            // 
            this.siguienteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siguienteBtn.Image = global::ERP_ventas.Properties.Resources.right_squared_32px;
            this.siguienteBtn.Location = new System.Drawing.Point(458, 441);
            this.siguienteBtn.Name = "siguienteBtn";
            this.siguienteBtn.Size = new System.Drawing.Size(30, 43);
            this.siguienteBtn.TabIndex = 24;
            this.siguienteBtn.UseVisualStyleBackColor = true;
            this.siguienteBtn.Click += new System.EventHandler(this.siguienteBtn_Click);
            // 
            // anteriorBtn
            // 
            this.anteriorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anteriorBtn.Enabled = false;
            this.anteriorBtn.Image = global::ERP_ventas.Properties.Resources.back_32px;
            this.anteriorBtn.Location = new System.Drawing.Point(316, 441);
            this.anteriorBtn.Name = "anteriorBtn";
            this.anteriorBtn.Size = new System.Drawing.Size(30, 43);
            this.anteriorBtn.TabIndex = 23;
            this.anteriorBtn.UseVisualStyleBackColor = true;
            this.anteriorBtn.Click += new System.EventHandler(this.anteriorBtn_Click);
            // 
            // UnidadesTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 494);
            this.Controls.Add(this.paginaxdey);
            this.Controls.Add(this.siguienteBtn);
            this.Controls.Add(this.anteriorBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewtransportes);
            this.Name = "UnidadesTransporte";
            this.Text = "Unidades de Transporte";
            this.Load += new System.EventHandler(this.UnidadesTransporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtransportes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewtransportes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label paginaxdey;
        private System.Windows.Forms.Button siguienteBtn;
        private System.Windows.Forms.Button anteriorBtn;
    }
}