using System.Data.SqlClient;
using System.Data;
using Capa_Entidad;

namespace Capa_Datos
{
    public class CD_Usuarios
    {
        private readonly CD_Conexion con = new CD_Conexion();
        private readonly CE_Usuarios ce = new CE_Usuarios();

        public void CD_Insertar(CE_Usuarios Usuarios)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_Insertar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@Nombre", Usuarios.Nombre);
            com.Parameters.AddWithValue("@Apellidos", Usuarios.Apellidos);
            com.Parameters.AddWithValue("@DNI",Usuarios.DNI);
            com.Parameters.AddWithValue("@Correo", Usuarios.Correo);
            com.Parameters.AddWithValue("@Telefono", Usuarios.Telefono);
            com.Parameters.AddWithValue("@Fecha_Nacimiento", SqlDbType.Date).Value=Usuarios.Fecha_nac;
            com.Parameters.AddWithValue("@Privilegio", Usuarios.Privilegio);
            com.Parameters.AddWithValue("@IMG", Usuarios.Img);
            com.Parameters.AddWithValue("@Usuario", Usuarios.Usuario);
            com.Parameters.AddWithValue("@Contrasenia", Usuarios.Contrasenia);
            com.Parameters.AddWithValue("@Patron", Usuarios.Patron);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        public CE_Usuarios CD_Consultar(int idUsuarios)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_U_Consultar", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = idUsuarios;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.Nombre = Convert.ToString(row[1]);
            ce.Apellidos = Convert.ToString(row[2]);
            ce.DNI = Convert.ToString(row[3]);
            ce.Correo = Convert.ToString(row[4]);
            ce.Telefono = Convert.ToInt32(row[5]);
            ce.Fecha_nac = Convert.ToDateTime(row[6]);
            ce.Privilegio = Convert.ToInt32(row[7]);
            ce.Img = (byte[])row[8];
            ce.Usuario = Convert.ToString(row[9]);

            return ce;
        }
        public void CD_Eliminar(CE_Usuarios usuarios)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = con.AbrirConexion();
            com.CommandText = "SP_U_ELiminar";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@idUsuario", usuarios.IdUsuario);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        public void CD_ActualizarDatos(CE_Usuarios usuarios)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_Modificar",
                CommandType = CommandType.StoredProcedure
            };
            com.Parameters.AddWithValue("@IdUsuario", usuarios.IdUsuario);
            com.Parameters.AddWithValue("@Nombre", usuarios.Nombre);
            com.Parameters.AddWithValue("@Apellidos", usuarios.Apellidos);
            com.Parameters.AddWithValue("@DNI", usuarios.DNI);
            com.Parameters.AddWithValue("@Correo", usuarios.Correo);
            com.Parameters.AddWithValue("@Telefono", usuarios.Telefono);
            com.Parameters.AddWithValue("@Fecha_Nacimiento", SqlDbType.Date).Value = usuarios.Fecha_nac;
            com.Parameters.AddWithValue("@Privilegio", usuarios.Privilegio);
            com.Parameters.AddWithValue("@Usuario", usuarios.Usuario);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        public void CD_ActualizarContrasenia(CE_Usuarios usuario)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_ModificarContrasenia",
                CommandType = CommandType.StoredProcedure
            };
            com.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
            com.Parameters.AddWithValue("@contrasenia", usuario.Contrasenia);
            com.Parameters.AddWithValue("@patron", usuario.Patron);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        public void CD_ActualizarImg(CE_Usuarios usuario)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_ModificarIMG",
                CommandType = CommandType.StoredProcedure
            };
            com.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
            com.Parameters.AddWithValue("@IMG", usuario.Img);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        public DataTable CargarUsuarios()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_P_CargarUsuarios", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.CerrarConexion();

            return dt;

        }
        public DataTable Buscar(string buscar)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_U_Buscar", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@buscar", SqlDbType.VarChar).Value = buscar;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.CerrarConexion();

            return dt;

        }
    }
}
