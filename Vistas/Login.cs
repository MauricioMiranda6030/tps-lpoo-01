using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using ClasesBase;

namespace Vistas
{
    public partial class Login : Form
    {
        private Dictionary<string, string> usuarios = new Dictionary<string, string>()
        {
            { "administrador", "administrador" },
            { "operador", "operador" },
            { "vendedor", "vendedor" }
        };

        public Login()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Inicio formInicio = new Inicio();
            formInicio.Show();
            this.Close();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasenia = txtPassword.Text;

            DataTable dt = new DataTable();
            dt = FuncionesUsuario.verificarUsuario(usuario, contrasenia);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido/a " + usuario);

                int rolCodigo = (int) dt.Rows[0]["rolCodigo"];
                Principal formPrincipal = new Principal(usuario, rolCodigo);
                
                formPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }      
        }
    }
}
