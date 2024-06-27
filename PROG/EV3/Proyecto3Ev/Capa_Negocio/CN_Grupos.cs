using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Grupos
    {
        CD_Grupos CD_Grupos = new CD_Grupos();
        CE_Grupos CE_Grupos = new CE_Grupos();

        public List<string> ListarGrupos()
        {
            return CD_Grupos.ListarGrupos();
        }

        public CE_Grupos Nombre(int grupo)
        {
            return CD_Grupos.Nombre(grupo);   
        }
        public int IdGrupo(string nombre)
        {
            return CD_Grupos.IdGrupo(nombre);
        }
    }
}
