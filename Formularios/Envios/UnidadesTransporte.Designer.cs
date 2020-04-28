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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.siguienteBtn = new System.Windows.Forms.Button();
            this.anteriorBtn = new System.Windows.Forms.Button();
            this.paginaxdey = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.elementosPaginacionCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtransportes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewtransportes
            // 
            this.dataGridViewtransportes.AllowUserToAddRows = false;
            this.dataGridViewtransportes.AllowUserToDeleteRows = false;
            this.dataGridViewtransportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtransportes.Location = new System.Drawing.Point(0, 130);
            this.dataGridViewtransportes.MultiSelect = false;
            this.dataGridViewtransportes.Name = "dataGridViewtransportes";
            this.dataGridViewtransportes.ReadOnly = true;
            this.dataGridViewtransportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewtransportes.Size = new System.Drawing.Size(856, 303);
            this.dataGridViewtransportes.TabIndex = 13;
            this.dataGridViewtransportes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtransportes_CellDoubleClick);
            this.dataGridViewtransportes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewtransportes_DataBindingComplete);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 59);
            this.panel2.TabIndex = 38;
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
            this.panel4.Size = new System.Drawing.Size(656, 59);
            this.panel4.TabIndex = 1;
            // 
            // siguienteBtn
            // 
            this.siguienteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siguienteBtn.AutoSize = true;
            this.siguienteBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siguienteBtn.Image = global::ERP_ventas.Properties.Resources.right_squared_32px;
            this.siguienteBtn.Location = new System.Drawing.Point(306, 4);
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
            this.anteriorBtn.Location = new System.Drawing.Point(138, 4);
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
            this.paginaxdey.Location = new System.Drawing.Point(215, 14);
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
            // UnidadesTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 494);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewtransportes);
            this.Name = "UnidadesTransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unidades de Transporte";
            this.Load += new System.EventHandler(this.UnidadesTransporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtransportes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewtransportes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button button1;
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