using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class CN_Productos
    {
        readonly CD_Productos objProdcutos = new CD_Productos();


        public DataTable BuscarProducto(string buscar)
        {
            return objProdcutos.Buscar(buscar);
        }

        public CE_Productos Consultar(int idproducto)
        {
            return objProdcutos.consulta(idproducto);
        }
        public void Insertar(CE_Productos productos)
        {
            objProdcutos.CD_Insertar(productos);
        }
        public void Eliminar(CE_Productos productos)
        {
            objProdcutos.ELiminar(productos);
        }
        public void ActualizarDatos(CE_Productos productos)
        {
            objProdcutos.CD_ActualizarDatos(productos);
        }
        public void ActualizarIMG()
        {
            objProdcutos.ActualizarImg();
        }

    }
}
