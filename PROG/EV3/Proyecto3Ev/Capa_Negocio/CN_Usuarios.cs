using System.Data;
using Capa_Datos;
using Capa_Entidad;
namespace Capa_Negocio
{
    public class CN_Usuarios
    {
        private readonly CD_Usuarios objDatos= new CD_Usuarios();

        public CE_Usuarios Consulta(int IdUsuario)
        {
            return objDatos.CD_Consultar(IdUsuario);
        }
        public void Insertar(CE_Usuarios usuarios)
        {
            objDatos.CD_Insertar(usuarios);
        }
        public void Eliminar(CE_Usuarios usuarios)
        {
            objDatos.CD_Eliminar(usuarios);
        }
        public void ActualizarDatos(CE_Usuarios usuarios)
        {
            objDatos.CD_ActualizarDatos(usuarios);
        }
        public void ActualizarContrasenia(CE_Usuarios usuarios)
        {
            objDatos.CD_ActualizarContrasenia(usuarios);
        }
        public void ActualizarImagen(CE_Usuarios usuarios)
        {
            objDatos.CD_ActualizarImg(usuarios);
        }
        public DataTable CargarUsuarios()
        {
            return objDatos.CargarUsuarios();
        }
        public DataTable Buscar(string name)
        {
            return objDatos.Buscar(name);
        }
    }
}
