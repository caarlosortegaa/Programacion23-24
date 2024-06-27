using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Grupos
    {
        CD_Conexion con = new CD_Conexion();
        CE_Grupos CE_Grupos = new CE_Grupos();

        public List<string> ListarGrupos()
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_G_CargarDatos",
                CommandType = CommandType.StoredProcedure,
            };
            SqlDataReader reader = com.ExecuteReader();
            List<string> retorno = new List<string>();
            while(reader.Read())
            {
                retorno.Add(Convert.ToString(reader["Nombre"]));
            }
            con.CerrarConexion();
            return retorno;

            
        }

        public CE_Grupos Nombre(int IdGrupo)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_G_NombreGrupo", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdGrupo", SqlDbType.Int).Value = IdGrupo;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            CE_Grupos.Nombre = Convert.ToString(row[0]);

            return CE_Grupos;
        }
        public int IdGrupo(string nombre)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_G_IdGrupo",
                CommandType = CommandType.StoredProcedure
            };
            com.Parameters.AddWithValue("@Nombre", nombre);
            object valor = com.ExecuteScalar();
            int idGrupo = (int)valor;
            con.CerrarConexion();

            return idGrupo;
        }

    }
}
