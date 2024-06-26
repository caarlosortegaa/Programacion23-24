using Capa_Datos;
using Capa_Entidad;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Negocio
{
    public class CN_Privilegio
    {
        CD_Privilegios CD_Privilegios = new CD_Privilegios();
        public int IdPrivilegio(string NombrePrivilegio)
        {
            return CD_Privilegios.IdPrivilegio(NombrePrivilegio);
        }
        public CE_Privilegios NombrePrivilegio(int id)
        {
            return CD_Privilegios.NombrePrivilegio(id);
        }
        public List<string> ListarPrivilegios()
        {
            return CD_Privilegios.ObtenerPrivilegios();
        }


    }
}
