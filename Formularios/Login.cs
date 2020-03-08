using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Newtonsoft.Json;
using ERP_ventas.Datos;
using System.Windows.Forms;
using ERP_ventas.Modelo;
using System.Data.SqlClient;
using System.IO;

namespace ERP_ventas.Formularios
{
    public partial class Login : Form
    {
        UsuarioDAO usuarioDAO;
        public Login()
        {
            InitializeComponent();
            usuarioDAO = new UsuarioDAO();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = usuarioDAO.iniciarSesion(usuariotextBox.Text, passtextBox.Text);
           if (user != null)
            {
                Properties.Settings.Default.IDUsuario = user.ID;
                Properties.Settings.Default.Save();
                Console.WriteLine(Properties.Settings.Default.IDUsuario);
                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
                this.Close();
            }
            else
            {
                Mensajes.Error("Usuario y/o contraseña incorrectos");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            usuariotextBox.GotFocus += new EventHandler(this.TextGotFocusUser);
            usuariotextBox.LostFocus += new EventHandler(this.TextLostFocususer);

            passtextBox.GotFocus += new EventHandler(this.TextGotFocusPass);
            passtextBox.LostFocus += new EventHandler(this.TextLostFocusPass);
        }

        public void TextGotFocusUser(object sender, EventArgs e)
        {

            if (usuariotextBox.Text == "Usuario")
            {
                usuariotextBox.Text = "";
            }
        }

        public void TextLostFocususer(object sender, EventArgs e)
        {

            if (usuariotextBox.Text == "")
            {
                usuariotextBox.Text = "Usuario";
            }
        }

        public void TextGotFocusPass(object sender, EventArgs e)
        {

            if (passtextBox.Text == "Contraseña")
            {
                passtextBox.Text = "";
               // passtextBox.PasswordChar = '*';
            }
        }

        public void TextLostFocusPass(object sender, EventArgs e)
        {

            if (passtextBox.Text == "")
            {
                passtextBox.Text = "Contraseña";
                passtextBox.PasswordChar = '\0';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
                if (dragging)
                {
                    Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                    this.Location = Point.Add(dragFormPoint, new Size(dif));
                }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
