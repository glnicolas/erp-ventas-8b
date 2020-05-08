namespace ERP_ventas.Formularios.Tripulacion
{
    partial class TripulacionForm
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
            this.dataTripulacion = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.siguienteBtn = new System.Windows.Forms.Button();
            this.anteriorBtn = new System.Windows.Forms.Button();
            this.paginaxdey = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.elementosPaginacionCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buscartextBox = new System.Windows.Forms.TextBox();
            this.limpiarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTripulacion)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTripulacion
            // 
            this.dataTripulacion.AllowUserToAddRows = false;
            this.dataTripulacion.AllowUserToDeleteRows = false;
            this.dataTripulacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTripulacion.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataTripulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTripulacion.Location = new System.Drawing.Point(-119, 70);
            this.dataTripulacion.MultiSelect = false;
            this.dataTripulacion.Name = "dataTripulacion";
            this.dataTripulacion.ReadOnly = true;
            this.dataTripulacion.RowHeadersVisible = false;
            this.dataTripulacion.RowHeadersWidth = 51;
            this.dataTripulacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTripulacion.Size = new System.Drawing.Size(1038, 361);
            this.dataTripulacion.TabIndex = 27;
            this.dataTripulacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOfertas_CellContentClick);
            this.dataTripulacion.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTripulacion_CellContentDoubleClick);
            this.dataTripulacion.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataTripulacion_DataBindingComplete_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ERP_ventas.Properties.Resources.eliminar2;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(96, 26);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 38);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar  ";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ERP_ventas.Properties.Resources.plus;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(12, 26);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(78, 38);
            this.btnNuevo.TabIndex = 29;
            this.btnNuevo.Tag = "Agregar nuevo registro";
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 59);
            this.panel2.TabIndex = 37;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.siguienteBtn);
            this.panel4.Controls.Add(this.anteriorBtn);
            this.panel4.Controls.Add(this.paginaxdey);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 59);
            this.panel4.TabIndex = 1;
            // 
            // siguienteBtn
            // 
            this.siguienteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siguienteBtn.AutoSize = true;
            this.siguienteBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siguienteBtn.Image = global::ERP_ventas.Properties.Resources.right_squared_32px;
            this.siguienteBtn.Location = new System.Drawing.Point(278, 4);
            this.siguienteBtn.Name = "siguienteBtn";
            this.siguienteBtn.Size = new System.Drawing.Size(50, 43);
            this.siguienteBtn.TabIndex = 28;
            this.siguienteBtn.UseVisualStyleBackColor = false;
            this.siguienteBtn.Click += new System.EventHandler(this.siguienteBtn_Click_1);
            // 
            // anteriorBtn
            // 
            this.anteriorBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.anteriorBtn.AutoSize = true;
            this.anteriorBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anteriorBtn.Enabled = false;
            this.anteriorBtn.Image = global::ERP_ventas.Properties.Resources.back_32px;
            this.anteriorBtn.Location = new System.Drawing.Point(110, 4);
            this.anteriorBtn.Name = "anteriorBtn";
            this.anteriorBtn.Size = new System.Drawing.Size(50, 43);
            this.anteriorBtn.TabIndex = 27;
            this.anteriorBtn.UseVisualStyleBackColor = false;
            this.anteriorBtn.Click += new System.EventHandler(this.anteriorBtn_Click_1);
            // 
            // paginaxdey
            // 
            this.paginaxdey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paginaxdey.AutoSize = true;
            this.paginaxdey.BackColor = System.Drawing.Color.Transparent;
            this.paginaxdey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paginaxdey.Location = new System.Drawing.Point(187, 14);
            this.paginaxdey.Name = "paginaxdey";
            this.paginaxdey.Size = new System.Drawing.Size(59, 20);
            this.paginaxdey.TabIndex = 29;
            this.paginaxdey.Text = "1 de 2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.elementosPaginacionCmb);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 59);
            this.panel3.TabIndex = 0;
            // 
            // elementosPaginacionCmb
            // 
            this.elementosPaginacionCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.elementosPaginacionCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementosPaginacionCmb.FormattingEnabled = true;
            this.elementosPaginacionCmb.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "10",
            "15"});
            this.elementosPaginacionCmb.Location = new System.Drawing.Point(108, 12);
            this.elementosPaginacionCmb.Name = "elementosPaginacionCmb";
            this.elementosPaginacionCmb.Size = new System.Drawing.Size(65, 26);
            this.elementosPaginacionCmb.TabIndex = 34;
            this.elementosPaginacionCmb.SelectedIndexChanged += new System.EventHandler(this.elementosPaginacionCmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mostrar";
            // 
            // buscartextBox
            // 
            this.buscartextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscartextBox.Location = new System.Drawing.Point(376, 26);
            this.buscartextBox.Name = "buscartextBox";
            this.buscartextBox.Size = new System.Drawing.Size(329, 29);
            this.buscartextBox.TabIndex = 38;
            this.buscartextBox.TextChanged += new System.EventHandler(this.buscartextBox_TextChanged);
            // 
            // limpiarbutton
            // 
            this.limpiarbutton.Image = global::ERP_ventas.Properties.Resources.broom_32px;
            this.limpiarbutton.Location = new System.Drawing.Point(720, 24);
            this.limpiarbutton.Name = "limpiarbutton";
            this.limpiarbutton.Size = new System.Drawing.Size(43, 38);
            this.limpiarbutton.TabIndex = 39;
            this.limpiarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.limpiarbutton.UseVisualStyleBackColor = true;
            this.limpiarbutton.Click += new System.EventHandler(this.limpiarbutton_Click);
            // 
            // TripulacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.limpiarbutton);
            this.Controls.Add(this.buscartextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dataTripulacion);
            this.Name = "TripulacionForm";
            this.Text = "Tripulacion";
            this.Load += new System.EventHandler(this.Tripulacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTripulacion)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTripulacion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button siguienteBtn;
        private System.Windows.Forms.Button anteriorBtn;
        private System.Windows.Forms.Label paginaxdey;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox elementosPaginacionCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox buscartextBox;
        private System.Windows.Forms.Button limpiarbutton;
    }
}