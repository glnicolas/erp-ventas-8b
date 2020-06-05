namespace ERP_ventas.Formularios.Devoluciones
{
    partial class DevolcionesForm
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
            this.buscartextBox = new System.Windows.Forms.TextBox();
            this.dataDevo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiarbutton = new System.Windows.Forms.Button();
            this.elementosPaginacionCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paginaxdey = new System.Windows.Forms.Label();
            this.siguienteBtn = new System.Windows.Forms.Button();
            this.anteriorBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDevo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscartextBox
            // 
            this.buscartextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscartextBox.Location = new System.Drawing.Point(526, 99);
            this.buscartextBox.Name = "buscartextBox";
            this.buscartextBox.Size = new System.Drawing.Size(329, 29);
            this.buscartextBox.TabIndex = 47;
            // 
            // dataDevo
            // 
            this.dataDevo.AllowUserToAddRows = false;
            this.dataDevo.AllowUserToDeleteRows = false;
            this.dataDevo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataDevo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataDevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDevo.Location = new System.Drawing.Point(18, 134);
            this.dataDevo.MultiSelect = false;
            this.dataDevo.Name = "dataDevo";
            this.dataDevo.ReadOnly = true;
            this.dataDevo.RowHeadersVisible = false;
            this.dataDevo.RowHeadersWidth = 51;
            this.dataDevo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDevo.Size = new System.Drawing.Size(886, 335);
            this.dataDevo.TabIndex = 45;
            this.dataDevo.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataVentas_DataBindingComplete);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 74);
            this.panel1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Devoluciones";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // limpiarbutton
            // 
            this.limpiarbutton.Image = global::ERP_ventas.Properties.Resources.broom_32px;
            this.limpiarbutton.Location = new System.Drawing.Point(861, 99);
            this.limpiarbutton.Name = "limpiarbutton";
            this.limpiarbutton.Size = new System.Drawing.Size(43, 29);
            this.limpiarbutton.TabIndex = 46;
            this.limpiarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.limpiarbutton.UseVisualStyleBackColor = true;
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
            this.elementosPaginacionCmb.Location = new System.Drawing.Point(102, 494);
            this.elementosPaginacionCmb.Name = "elementosPaginacionCmb";
            this.elementosPaginacionCmb.Size = new System.Drawing.Size(65, 26);
            this.elementosPaginacionCmb.TabIndex = 48;
            this.elementosPaginacionCmb.SelectedIndexChanged += new System.EventHandler(this.elementosPaginacionCmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mostrar";
            // 
            // paginaxdey
            // 
            this.paginaxdey.AutoSize = true;
            this.paginaxdey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paginaxdey.Location = new System.Drawing.Point(425, 494);
            this.paginaxdey.Name = "paginaxdey";
            this.paginaxdey.Size = new System.Drawing.Size(59, 20);
            this.paginaxdey.TabIndex = 52;
            this.paginaxdey.Text = "1 de 2";
            // 
            // siguienteBtn
            // 
            this.siguienteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siguienteBtn.Image = global::ERP_ventas.Properties.Resources.right_squared_32px;
            this.siguienteBtn.Location = new System.Drawing.Point(507, 484);
            this.siguienteBtn.Name = "siguienteBtn";
            this.siguienteBtn.Size = new System.Drawing.Size(30, 43);
            this.siguienteBtn.TabIndex = 51;
            this.siguienteBtn.UseVisualStyleBackColor = true;
            this.siguienteBtn.Click += new System.EventHandler(this.siguienteBtn_Click);
            // 
            // anteriorBtn
            // 
            this.anteriorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anteriorBtn.Enabled = false;
            this.anteriorBtn.Image = global::ERP_ventas.Properties.Resources.back_32px;
            this.anteriorBtn.Location = new System.Drawing.Point(365, 484);
            this.anteriorBtn.Name = "anteriorBtn";
            this.anteriorBtn.Size = new System.Drawing.Size(30, 43);
            this.anteriorBtn.TabIndex = 50;
            this.anteriorBtn.UseVisualStyleBackColor = true;
            this.anteriorBtn.Click += new System.EventHandler(this.anteriorBtn_Click);
            // 
            // DevolcionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 525);
            this.Controls.Add(this.paginaxdey);
            this.Controls.Add(this.siguienteBtn);
            this.Controls.Add(this.anteriorBtn);
            this.Controls.Add(this.elementosPaginacionCmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buscartextBox);
            this.Controls.Add(this.limpiarbutton);
            this.Controls.Add(this.dataDevo);
            this.Controls.Add(this.panel1);
            this.Name = "DevolcionesForm";
            this.Text = "DevolcionesForm";
            this.Load += new System.EventHandler(this.DevolcionesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDevo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox buscartextBox;
        private System.Windows.Forms.Button limpiarbutton;
        private System.Windows.Forms.DataGridView dataDevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox elementosPaginacionCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label paginaxdey;
        private System.Windows.Forms.Button siguienteBtn;
        private System.Windows.Forms.Button anteriorBtn;
    }
}