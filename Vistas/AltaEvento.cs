using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ClasesBase;

namespace Vistas
{
    public partial class AltaEvento : Form
    {
        private string nombreUsuario;
        public AltaEvento(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void LimpiarTextBox()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
            }
        }

        private void asignarEvento(Evento nuevoEvento)
        {
            nuevoEvento.Eve_Estado = txtEstado.Text;
            nuevoEvento.Eve_HoraInicio = dateHoraInicio.Value;
            nuevoEvento.Eve_HoraFin = dateHoraFin.Value;
        }

        private void mostrarInfoEvento(Evento evento)
        {
            MessageBox.Show(evento.ToString(), "Guardado exitoso");
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtEstado.Text == "" || dateHoraFin.Text == "" || dateHoraInicio.Text == "")
            {
                MessageBox.Show("No se permite campos en blanco");
            }
            else
            {
                DialogResult mensaje = MessageBox.Show("¿Estás seguro que quieres cargar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mensaje == DialogResult.Yes)
                {
                    Evento nuevoEvento = new Evento();
                    asignarEvento(nuevoEvento);
                    mostrarInfoEvento(nuevoEvento);
                    LimpiarTextBox();
                }
                else
                {
                    LimpiarTextBox();
                }
            }
        }
    }
}
