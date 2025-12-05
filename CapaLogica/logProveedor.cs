using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProveedor
    {
        #region sigleton
        // Patrón Singleton
        private static readonly logProveedor _instancia = new logProveedor();
        public static logProveedor Instancia
        {
            get { return logProveedor._instancia; }
        }
        #endregion sigleton

        #region metodos

        /// //////////////// listado
        public List<entProveedor> ListarProveedor()
        {
            // Llama directamente al método de la Capa de Datos
            return datProveedor.Instancia.ListarProveedor();
        }




        public void InsertaProveedor(entProveedor Provee)
        {
            // Llama al método de inserción de la Capa de Datos
            datProveedor.Instancia.InsertarProveedor(Provee);
        }


        public void EditaProveedor(entProveedor Provee)
        {
            datProveedor.Instancia.EditarProveedor(Provee);
        }
        public void EliminarProveedor(entProveedor Provee)
        {
            datProveedor.Instancia.EliminarProveedor(Provee);
        }
        #endregion metodos
    }
}
