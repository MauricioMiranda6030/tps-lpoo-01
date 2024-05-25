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
    public partial class frmRegistroUsuarios : Form
    {
        public frmRegistroUsuarios()
        {
            InitializeComponent();
        }

        private void frmRegistroUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private void cargarUsuarios()
        {
            grdUsuarios.DataSource = FuncionesUsuario.getUsuarios();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdUsuarios.CurrentRow != null)
            {
                Usuario oUsuario = new Usuario();

                oUsuario.Usu_NombreUsuario = grdUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                oUsuario.Usu_ApellidoNombre = grdUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
                oUsuario.Usu_Contrasenia = grdUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                oUsuario.Usu_ID = (int) grdUsuarios.CurrentRow.Cells["ID"].Value;
                
                ModificarUsuario mUsuario = new ModificarUsuario(oUsuario);
                this.Hide();
                mUsuario.ShowDialog();
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FuncionesUsuario.eliminarUsuario((int) grdUsuarios.CurrentRow.Cells["ID"].Value);
            cargarUsuarios();
        }
    }
}
