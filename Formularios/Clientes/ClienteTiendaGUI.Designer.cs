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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.siguienteBtn = new System.Windows.Forms.Button();
            this.anteriorBtn = new System.Windows.Forms.Button();
            this.paginaxdey = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.elementosPaginacionCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionTabla)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.paginacionTabla.Size = new System.Drawing.Size(927, 421);
            this.paginacionTabla.TabIndex = 19;
            this.paginacionTabla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paginacionTabla_CellDoubleClick);
            this.paginacionTabla.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.paginacionTabla_DataBindingComplete);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 548);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 59);
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
            this.panel4.Size = new System.Drawing.Size(727, 59);
            this.panel4.TabIndex = 1;
            // 
            // siguienteBtn
            // 
            this.siguienteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siguienteBtn.AutoSize = true;
            this.siguienteBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siguienteBtn.Image = global::ERP_ventas.Properties.Resources.right_squared_32px;
            this.siguienteBtn.Location = new System.Drawing.Point(341, 4);
            this.siguienteBtn.Name = "siguienteBtn";
            this.siguienteBtn.Size = new System.Drawing.Size(50, 43);
            this.siguienteBtn.TabIndex = 28;
            this.siguienteBtn.UseVisualStyleBackColor = false;
            this.siguienteBtn.Click += new System.EventHandler(this.siguienteBtn_Click);
            // 
            // anteriorBtn
            // 
            this.anteriorBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.anteriorBtn.AutoSize = true;
            this.anteriorBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anteriorBtn.Enabled = false;
            this.anteriorBtn.Image = global::ERP_ventas.Properties.Resources.back_32px;
            this.anteriorBtn.Location = new System.Drawing.Point(173, 4);
            this.anteriorBtn.Name = "anteriorBtn";
            this.anteriorBtn.Size = new System.Drawing.Size(50, 43);
            this.anteriorBtn.TabIndex = 27;
            this.anteriorBtn.UseVisualStyleBackColor = false;
            this.anteriorBtn.Click += new System.EventHandler(this.anteriorBtn_Click);
            // 
            // paginaxdey
            // 
            this.paginaxdey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paginaxdey.AutoSize = true;
            this.paginaxdey.BackColor = System.Drawing.Color.Transparent;
            this.paginaxdey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paginaxdey.Location = new System.Drawing.Point(250, 14);
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
            // ClienteTiendaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 607);
            this.Controls.Add(this.panel2);
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
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView paginacionTabla;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button siguienteBtn;
        private System.Windows.Forms.Button anteriorBtn;
        private System.Windows.Forms.Label paginaxdey;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox elementosPaginacionCmb;
        private System.Windows.Forms.Label label2;
    }
}