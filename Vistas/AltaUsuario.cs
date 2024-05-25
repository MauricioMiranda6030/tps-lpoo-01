using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            cargarRoles();
        }

        private void cargarRoles() 
        {
            cmbRol.DisplayMember = "descripcion";
            cmbRol.ValueMember = "codigo";
            cmbRol.DataSource = FuncionesUsuario.getRoles();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario oUsuario = crearUsuario();
            FuncionesUsuario.altaUsuario(oUsuario);

            MessageBox.Show("Se creo el usuario " + txtNombre.Text + " correctamente");
        }

        private Usuario crearUsuario() 
        {
            Usuario nuevoUsuario = new Usuario();

            nuevoUsuario.Usu_NombreUsuario = txtNombre.Text;
            nuevoUsuario.Usu_ApellidoNombre = txtApellido.Text;
            nuevoUsuario.Usu_Contrasenia = txtContrasenia.Text;
            nuevoUsuario.Rol_Codigo = (int) cmbRol.SelectedValue;

            return nuevoUsuario;
        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            frmRegistroUsuarios oRegistroUsuarios = new frmRegistroUsuarios();
            this.Hide();
            oRegistroUsuarios.ShowDialog();
            this.Close();
        }
    }
}
