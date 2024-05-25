using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class FuncionesUsuario
    {
        public static DataTable verificarUsuario(string nombre, string contrasenia)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario WHERE nombre = @nombre AND contrasenia = @contrasenia", cn);

            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@contrasenia", contrasenia);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable getRoles()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Rol";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cn.Close();
            return dt;
        }

        public static void altaUsuario(Usuario usuario) 
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(nombre, contrasenia, apellido, rolCodigo) values(@nombre, @contrasenia, @apellido, @rol)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@nombre", usuario.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@contrasenia", usuario.Usu_Contrasenia);
            cmd.Parameters.AddWithValue("@apellido", usuario.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", usuario.Rol_Codigo);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static DataTable getUsuarios() 
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT ";
            cmd.CommandText += "id as 'ID', descripcion as 'Rol', ";
            cmd.CommandText += "nombre as 'Nombre', apellido as 'Apellido', ";
            cmd.CommandText += "contrasenia as 'Contraseña' ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Rol as R ON (R.codigo=U.rolCodigo)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void modificarUsuario(Usuario usuario)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Usuario SET nombre = @nombre, apellido = @apellido, contrasenia = @contrasenia, rolCodigo = @rol WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@id", usuario.Usu_ID);
            cmd.Parameters.AddWithValue("@nombre", usuario.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@contrasenia", usuario.Usu_Contrasenia);
            cmd.Parameters.AddWithValue("@apellido", usuario.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", usuario.Rol_Codigo);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void eliminarUsuario(int id)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Usuario WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@id", id);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
