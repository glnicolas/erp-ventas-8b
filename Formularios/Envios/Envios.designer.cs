namespace ERP_ventas.Formularios.Envios
{
    partial class Envios
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.paginacionTabla = new System.Windows.Forms.DataGridView();
            this.paginaxdey = new System.Windows.Forms.Label();
            this.siguienteBtn = new System.Windows.Forms.Button();
            this.anteriorBtn = new System.Windows.Forms.Button();
            this.buscartextBox = new System.Windows.Forms.TextBox();
            this.limpiarbutton = new System.Windows.Forms.Button();
            this.elementosPaginacionCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 74);
            this.panel1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Envios";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ERP_ventas.Properties.Resources.eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(141, 80);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 35);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Tag = "Agregar nuevo registro";
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ERP_ventas.Properties.Resources.plus;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(12, 80);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(123, 35);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Tag = "Agregar nuevo registro";
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // paginacionTabla
            // 
            this.paginacionTabla.AllowUserToAddRows = false;
            this.paginacionTabla.AllowUserToDeleteRows = false;
            this.paginacionTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paginacionTabla.Location = new System.Drawing.Point(0, 121);
            this.paginacionTabla.MultiSelect = false;
            this.paginacionTabla.Name = "paginacionTabla";
            this.paginacionTabla.ReadOnly = true;
            this.paginacionTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paginacionTabla.Size = new System.Drawing.Size(800, 179);
            this.paginacionTabla.TabIndex = 20;
            this.paginacionTabla.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paginacionTabla_CellContentDoubleClick);
            this.paginacionTabla.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.paginacionTabla_DataBindingComplete);
            // 
            // paginaxdey
            // 
            this.paginaxdey.AutoSize = true;
            this.paginaxdey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paginaxdey.Location = new System.Drawing.Point(362, 316);
            this.paginaxdey.Name = "paginaxdey";
            this.paginaxdey.Size = new System.Drawing.Size(59, 20);
            this.paginaxdey.TabIndex = 28;
            this.paginaxdey.Text = "1 de 2";
            // 
            // siguienteBtn
            // 
            this.siguienteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siguienteBtn.Image = global::ERP_ventas.Properties.Resources.right_squared_32px;
            this.siguienteBtn.Location = new System.Drawing.Point(444, 306);
            this.siguienteBtn.Name = "siguienteBtn";
            this.siguienteBtn.Size = new System.Drawing.Size(30, 43);
            this.siguienteBtn.TabIndex = 27;
            this.siguienteBtn.UseVisualStyleBackColor = true;
            this.siguienteBtn.Click += new System.EventHandler(this.siguienteBtn_Click);
            // 
            // anteriorBtn
            // 
            this.anteriorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anteriorBtn.Enabled = false;
            this.anteriorBtn.Image = global::ERP_ventas.Properties.Resources.back_32px;
            this.anteriorBtn.Location = new System.Drawing.Point(302, 306);
            this.anteriorBtn.Name = "anteriorBtn";
            this.anteriorBtn.Size = new System.Drawing.Size(30, 43);
            this.anteriorBtn.TabIndex = 26;
            this.anteriorBtn.UseVisualStyleBackColor = true;
            this.anteriorBtn.Click += new System.EventHandler(this.anteriorBtn_Click);
            // 
            // buscartextBox
            // 
            this.buscartextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscartextBox.Location = new System.Drawing.Point(403, 80);
            this.buscartextBox.Name = "buscartextBox";
            this.buscartextBox.Size = new System.Drawing.Size(329, 29);
            this.buscartextBox.TabIndex = 35;
            this.buscartextBox.TextChanged += new System.EventHandler(this.buscartextBox_TextChanged);
            // 
            // limpiarbutton
            // 
            this.limpiarbutton.Image = global::ERP_ventas.Properties.Resources.broom_32px;
            this.limpiarbutton.Location = new System.Drawing.Point(738, 78);
            this.limpiarbutton.Name = "limpiarbutton";
            this.limpiarbutton.Size = new System.Drawing.Size(43, 38);
            this.limpiarbutton.TabIndex = 34;
            this.limpiarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.limpiarbutton.UseVisualStyleBackColor = true;
            this.limpiarbutton.TextChanged += new System.EventHandler(this.buscartextBox_TextChanged);
            this.limpiarbutton.Click += new System.EventHandler(this.limpiarbutton_Click);
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
            this.elementosPaginacionCmb.Location = new System.Drawing.Point(102, 314);
            this.elementosPaginacionCmb.Name = "elementosPaginacionCmb";
            this.elementosPaginacionCmb.Size = new System.Drawing.Size(65, 26);
            this.elementosPaginacionCmb.TabIndex = 36;
            this.elementosPaginacionCmb.SelectedIndexChanged += new System.EventHandler(this.elementosPaginacionCmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mostrar";
            // 
            // Envios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.elementosPaginacionCmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buscartextBox);
            this.Controls.Add(this.limpiarbutton);
            this.Controls.Add(this.paginaxdey);
            this.Controls.Add(this.siguienteBtn);
            this.Controls.Add(this.anteriorBtn);
            this.Controls.Add(this.paginacionTabla);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panel1);
            this.Name = "Envios";
            this.Text = "Envios";
            this.Load += new System.EventHandler(this.Envios_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView paginacionTabla;
        private System.Windows.Forms.Label paginaxdey;
        private System.Windows.Forms.Button siguienteBtn;
        private System.Windows.Forms.Button anteriorBtn;
        private System.Windows.Forms.TextBox buscartextBox;
        private System.Windows.Forms.Button limpiarbutton;
        private System.Windows.Forms.ComboBox elementosPaginacionCmb;
        private System.Windows.Forms.Label label2;
    }
}