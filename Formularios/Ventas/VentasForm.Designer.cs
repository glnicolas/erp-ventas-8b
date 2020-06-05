namespace ERP_ventas.Formularios.Ventas
{
    partial class VentasForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.siguienteBtn = new System.Windows.Forms.Button();
            this.anteriorBtn = new System.Windows.Forms.Button();
            this.paginaxdey = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.elementosPaginacionCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buscartextBox = new System.Windows.Forms.TextBox();
            this.dataVentas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.limpiarbutton = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 540);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 59);
            this.panel2.TabIndex = 44;
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
            this.panel4.Size = new System.Drawing.Size(838, 59);
            this.panel4.TabIndex = 1;
            // 
            // siguienteBtn
            // 
            this.siguienteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siguienteBtn.AutoSize = true;
            this.siguienteBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siguienteBtn.Image = global::ERP_ventas.Properties.Resources.right_squared_32px;
            this.siguienteBtn.Location = new System.Drawing.Point(397, 4);
            this.siguienteBtn.Name = "siguienteBtn";
            this.siguienteBtn.Size = new System.Drawing.Size(50, 43);
            this.siguienteBtn.TabIndex = 28;
            this.siguienteBtn.UseVisualStyleBackColor = false;
            // 
            // anteriorBtn
            // 
            this.anteriorBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.anteriorBtn.AutoSize = true;
            this.anteriorBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anteriorBtn.Enabled = false;
            this.anteriorBtn.Image = global::ERP_ventas.Properties.Resources.back_32px;
            this.anteriorBtn.Location = new System.Drawing.Point(229, 4);
            this.anteriorBtn.Name = "anteriorBtn";
            this.anteriorBtn.Size = new System.Drawing.Size(50, 43);
            this.anteriorBtn.TabIndex = 27;
            this.anteriorBtn.UseVisualStyleBackColor = false;
            // 
            // paginaxdey
            // 
            this.paginaxdey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paginaxdey.AutoSize = true;
            this.paginaxdey.BackColor = System.Drawing.Color.Transparent;
            this.paginaxdey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paginaxdey.Location = new System.Drawing.Point(306, 14);
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
            this.buscartextBox.Location = new System.Drawing.Point(648, 82);
            this.buscartextBox.Name = "buscartextBox";
            this.buscartextBox.Size = new System.Drawing.Size(329, 29);
            this.buscartextBox.TabIndex = 43;
            // 
            // dataVentas
            // 
            this.dataVentas.AllowUserToAddRows = false;
            this.dataVentas.AllowUserToDeleteRows = false;
            this.dataVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataVentas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVentas.Location = new System.Drawing.Point(0, 124);
            this.dataVentas.MultiSelect = false;
            this.dataVentas.Name = "dataVentas";
            this.dataVentas.ReadOnly = true;
            this.dataVentas.RowHeadersVisible = false;
            this.dataVentas.RowHeadersWidth = 51;
            this.dataVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVentas.Size = new System.Drawing.Size(1038, 414);
            this.dataVentas.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 74);
            this.panel1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas";
            // 
            // btnDetalle
            // 
            this.btnDetalle.Image = global::ERP_ventas.Properties.Resources.detail_property_30px;
            this.btnDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalle.Location = new System.Drawing.Point(96, 80);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(77, 38);
            this.btnDetalle.TabIndex = 46;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::ERP_ventas.Properties.Resources.print_blue_30px;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(261, 80);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(77, 38);
            this.btnImprimir.TabIndex = 45;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // limpiarbutton
            // 
            this.limpiarbutton.Image = global::ERP_ventas.Properties.Resources.broom_32px;
            this.limpiarbutton.Location = new System.Drawing.Point(983, 80);
            this.limpiarbutton.Name = "limpiarbutton";
            this.limpiarbutton.Size = new System.Drawing.Size(43, 38);
            this.limpiarbutton.TabIndex = 42;
            this.limpiarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.limpiarbutton.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ERP_ventas.Properties.Resources.eliminar2;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(178, 80);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 38);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.Text = "Eliminar  ";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ERP_ventas.Properties.Resources.plus;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(12, 80);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(78, 38);
            this.btnNuevo.TabIndex = 39;
            this.btnNuevo.Tag = "Agregar nuevo registro";
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Image = global::ERP_ventas.Properties.Resources.right_squared_32px;
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviar.Location = new System.Drawing.Point(344, 80);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(77, 38);
            this.btnEnviar.TabIndex = 47;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ERP_ventas.Properties.Resources.print_blue_30px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(427, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 38);
            this.button1.TabIndex = 48;
            this.button1.Text = "Formato Excel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buscartextBox);
            this.Controls.Add(this.limpiarbutton);
            this.Controls.Add(this.dataVentas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panel1);
            this.Name = "VentasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VentasForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentasForm_FormClosed);
            this.Load += new System.EventHandler(this.VentasForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dataVentas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button button1;
    }
}