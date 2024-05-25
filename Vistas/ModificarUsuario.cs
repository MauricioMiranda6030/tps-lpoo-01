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
    public partial class ModificarUsuario : Form
    {
        private static int idUsuario;

        public ModificarUsuario(Usuario usuarioModificar)
        {
            InitializeComponent();
            cargarRoles();

            txtNombre.Text = usuarioModificar.Usu_NombreUsuario;
            txtApellido.Text = usuarioModificar.Usu_ApellidoNombre;
            txtContrasenia.Text = usuarioModificar.Usu_Contrasenia;

            idUsuario = usuarioModificar.Usu_ID;
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void cargarRoles()
        {
            cmbRol.DisplayMember = "descripcion";
            cmbRol.ValueMember = "codigo";
            cmbRol.DataSource = FuncionesUsuario.getRoles();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Usuario oUsuario = crearUsuario();
            FuncionesUsuario.modificarUsuario(oUsuario);

            frmRegistroUsuarios rUsuarios = new frmRegistroUsuarios();
            this.Hide();
            rUsuarios.ShowDialog();
            this.Close();
        }

        private Usuario crearUsuario()
        {
            Usuario nuevoUsuario = new Usuario();

            nuevoUsuario.Usu_ID = idUsuario;
            nuevoUsuario.Usu_NombreUsuario = txtNombre.Text;
            nuevoUsuario.Usu_ApellidoNombre = txtApellido.Text;
            nuevoUsuario.Usu_Contrasenia = txtContrasenia.Text;
            nuevoUsuario.Rol_Codigo = (int)cmbRol.SelectedValue;

            return nuevoUsuario;
        }
    }
}
