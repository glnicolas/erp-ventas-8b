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
        private Label label2;
        private TextBox textRol;
        private Button btnRegistrar;
        private Button modificarBtn;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
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
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textRol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Envio";
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 61;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(42, 121);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 62;
            // 
            // AddTripulacion
            // 
            this.ClientSize = new System.Drawing.Size(280, 293);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modificarBtn);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "AddTripulacion";
            this.Load += new System.EventHandler(this.AddTripulacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int id = ((Modelo.Envios)comboBox1.SelectedItem).idenvio;
            int idE = ((Modelo.Empleado)comboBox2.SelectedItem).ID;
            Modelo.Tripulacion trip = new Modelo.Tripulacion(idE,id,textRol.Text);
           var resultado = new TripulacionDAO().Registrar(trip);
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

            int id = ((Modelo.Envios)comboBox1.SelectedItem).idenvio;
            int idE = ((Modelo.Empleado)comboBox2.SelectedItem).ID;
            Modelo.Tripulacion trip = new Modelo.Tripulacion(idE, id, textRol.Text);
            var resultado = new TripulacionDAO().Editar(trip);
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
            comboBox1.Items.AddRange((new EnviosDAO().ConsultaGeneral("", new List<String>(), new List<object>())).ToArray());
            comboBox1.DisplayMember = "Env";
            comboBox2.Items.AddRange((new EmpleadoDAO().ConsultaGeneral("", new List<String>(), new List<object>())).ToArray());
            comboBox2.DisplayMember = "Emp";
            if (tripulacion!=null) 
            {
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    comboBox1.SelectedIndex = i;
                    if (((Modelo.Envios)comboBox1.SelectedItem).idenvio == tripulacion.idEnvio) 
                    {
                        break;
                    }
                }
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    comboBox2.SelectedIndex = i;
                    if (((Modelo.Empleado)comboBox2.SelectedItem).ID == tripulacion.idEnvio)
                    {
                        break;
                    }
                }
                textRol.Text = tripulacion.rol;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //public List<> empleado
    }
}
