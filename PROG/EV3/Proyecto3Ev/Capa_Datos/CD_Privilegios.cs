using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Datos
{
    public class CD_Privilegios
    {
        readonly CD_Conexion con = new CD_Conexion();
        readonly CE_Privilegios ce = new CE_Privilegios();

        public int IdPrivilegio(string privilegio)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_P_IdPrivilegio",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@NombrePriivlegio", privilegio);
            object valor = com.ExecuteScalar();
            int idPrivilegio = (int)valor;
            con.CerrarConexion();
            return idPrivilegio;
        }
        public CE_Privilegios NombrePrivilegio(int idPrivilegio)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_P_NombrePrivilegio", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdPrivilegio", SqlDbType.Int).Value = idPrivilegio;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.NombrePrivilegio = Convert.ToString(row[0]);

            return ce;
        }
        public List<string> ObtenerPrivilegios()
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_P_CargarPrivilegios",
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader reader = com.ExecuteReader();
            List<string> lista = new List<string>();
            while(reader.Read())
            {
                lista.Add(Convert.ToString(reader["NombrePrivilegio"]));
            }
            con.CerrarConexion();
            return lista;
        }
    }
}
