using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Privilegios
    {
        private int idPrivilegio;
        private string _NombrePrivilegio;
        public int IdPrivilegio { get => idPrivilegio; set => idPrivilegio = value; }
        public string NombrePrivilegio { get => _NombrePrivilegio; set => _NombrePrivilegio = value; }
    }
}
