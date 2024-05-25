using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Vistas
{
    public partial class Principal : Form
    {
        private string nombreUsuario;

        public Principal(string nombreUsuario, int rol)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;

            Console.WriteLine(rol);

            switch (rol)
            {
                case 1: btnUsuarios.Enabled = false;
                    btnParticipante.Enabled = true;
                    btnCompetencias.Enabled = true;
                    btnEventos.Enabled = true;
                break;

                case 2: btnUsuarios.Enabled = true;
                    btnParticipante.Enabled = false;
                    btnCompetencias.Enabled = false;
                    btnEventos.Enabled = true;
                break;

                case 3: btnUsuarios.Enabled = true;
                    btnParticipante.Enabled = true;
                    btnCompetencias.Enabled = true;
                    btnEventos.Enabled = true;
                break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            formLogin.Show();
            this.Close();
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

        private void Principal_Load(object sender, EventArgs e)
        {
            lblUserOnLine.Text =nombreUsuario;
        }

        private void btnParticipante_Click(object sender, EventArgs e)
        {
            subeMenuPart.Visible = true;
        }

        private void btnAltaParticipante_Click(object sender, EventArgs e)
        {
            subeMenuPart.Visible = false;
            AltaParticipante formAltaParticipante = new AltaParticipante(nombreUsuario);
            formAltaParticipante.Show();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            subeMenuPart.Visible = false;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            subeMenuPart.Visible = false;
        }

        private void btnCompetencias_Click(object sender, EventArgs e)
        {
            subMenuComptencia.Visible = true;
        }

        /*private void btnAltaComp_Click(object sender, EventArgs e)
        {
            subMenuComptencia.Visible = false;
        }

        private void btnEditComp_Click(object sender, EventArgs e)
        {
            subMenuComptencia.Visible = false;
        }

        private void btnBajaComp_Click(object sender, EventArgs e)
        {
            subMenuComptencia.Visible = false;
        }*/

        private void btnEventos_Click(object sender, EventArgs e)
        {
            subMenuEventos.Visible = true;
        }

        private void btnAltaEve_Click(object sender, EventArgs e)
        {
            subMenuEventos.Visible = false;
            AltaEvento formAltaEvento = new AltaEvento(nombreUsuario);
            formAltaEvento.Show();
        }

        private void btnModiEve_Click(object sender, EventArgs e)
        {
            subMenuEventos.Visible = false;
        }

        private void btnBajaEve_Click(object sender, EventArgs e)
        {
            subMenuEventos.Visible = false;
        }

        private void btnAltaCat_Click(object sender, EventArgs e)
        {
            subMenuComptencia.Visible = false;
            AltaCategoria formAltaCategoria = new AltaCategoria(nombreUsuario);
            formAltaCategoria.Show();
        }

        private void btnAltaDis_Click(object sender, EventArgs e)
        {
            subMenuComptencia.Visible = false;
            AltaDisciplina formAltaDisciplina = new AltaDisciplina(nombreUsuario);
            formAltaDisciplina.Show();
            this.Close();
        }

        private void btnBajaComp_Click(object sender, EventArgs e)
        {
            subMenuComptencia.Visible = false;
        }

        private void btnABMUsuarios_Click(object sender, EventArgs e)
        {
            subMenuUsuarios.Visible = false;
            AltaUsuario aUsuario = new AltaUsuario();
            aUsuario.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            subMenuUsuarios.Visible = true;
        }


    }
}
