using System;
using ERP_ventas.Datos;
using ERP_ventas.Modelo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_ventas.Formularios;
using ERP_ventas.Formularios.Tripulacion;

namespace ERP_ventas.Formularios.Tripulacion
{
    public partial class AddTripulacion : Form
    {
        Modelo.Tripulacion tripulacion;
        private Panel panel1;
        private Label label8;
        private NumericUpDown txtIdEnvio;
        private Label label2;
        private TextBox textRol;
        private Button btnRegistrar;
        private Button modificarBtn;
        private Label label1;
        private ComboBox comboBoxEmpleado;
        private Label label3;
        
        public AddTripulacion()
        {
            InitializeComponent();
            modificarBtn.Visible = false;
            btnRegistrar.Visible = true;
        }

        public AddTripulacion(Modelo.Tripulacion tripulacion) 
        {
            InitializeComponent();
            this.tripulacion = tripulacion;
            label8.Text = "Editar Tripulacion";
            modificarBtn.Visible = true;
            btnRegistrar.Visible = false;
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdEnvio = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textRol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEmpleado = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdEnvio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 74);
            this.panel1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(8, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Agregar Tripulacion";
            // 
            // txtIdEnvio
            // 
            this.txtIdEnvio.Location = new System.Drawing.Point(42, 161);
            this.txtIdEnvio.Name = "txtIdEnvio";
            this.txtIdEnvio.Size = new System.Drawing.Size(120, 20);
            this.txtIdEnvio.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "idEnvio";
            // 
            // textRol
            // 
            this.textRol.Location = new System.Drawing.Point(42, 198);
            this.textRol.Name = "textRol";
            this.textRol.Size = new System.Drawing.Size(120, 20);
            this.textRol.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Rol";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = global::ERP_ventas.Properties.Resources.save_24px;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(179, 240);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(89, 41);
            this.btnRegistrar.TabIndex = 57;
            this.btnRegistrar.Text = "Guardar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // modificarBtn
            // 
            this.modificarBtn.Image = global::ERP_ventas.Properties.Resources.save_24px;
            this.modificarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarBtn.Location = new System.Drawing.Point(12, 242);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(94, 39);
            this.modificarBtn.TabIndex = 58;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modificarBtn.UseVisualStyleBackColor = true;
            this.modificarBtn.Visible = false;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Empleado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxEmpleado
            // 
            this.comboBoxEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpleado.FormattingEnabled = true;
            this.comboBoxEmpleado.Location = new System.Drawing.Point(42, 121);
            this.comboBoxEmpleado.Name = "comboBoxEmpleado";
            this.comboBoxEmpleado.Size = new System.Drawing.Size(157, 21);
            this.comboBoxEmpleado.TabIndex = 60;
            // 
            // AddTripulacion
            // 
            this.ClientSize = new System.Drawing.Size(280, 293);
            this.Controls.Add(this.comboBoxEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modificarBtn);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdEnvio);
            this.Controls.Add(this.panel1);
            this.Name = "AddTripulacion";
            this.Load += new System.EventHandler(this.AddTripulacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdEnvio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           var resultado = new TripulacionDAO().Registrar(tripulacion);
            Type resultadoTipo = resultado.GetType();
            if (resultadoTipo.Equals(typeof(string))) 
            {
                Mensajes.Error(resultado.ToString());
            }
            else
            {
                Mensajes.Info("Registro exitoso.");
                Close();
            }
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            var resultado = new TripulacionDAO().Editar(tripulacion);
            Type resultado_tipo = resultado.GetType();

            if (resultado_tipo.Equals(typeof(string)))
            {
                Mensajes.Error(resultado.ToString());
            }
            else
            {
                Mensajes.Info("Actualización exitosa.");
                Close();
            }
        }

        private void AddTripulacion_Load(object sender, EventArgs e)
        {
            //comboBoxEmpleado.Items.AddRange();
            if (tripulacion!=null) 
            {
                txtIdEnvio.Value = tripulacion.idEnvio;
                textRol.Text = tripulacion.rol;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //public List<> empleado
    }
}
