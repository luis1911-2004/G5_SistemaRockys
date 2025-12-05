using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logOrdenDeCompra
    {
        private static readonly logOrdenDeCompra _instancia = new logOrdenDeCompra();
        public static logOrdenDeCompra Instancia
        {
            get { return logOrdenDeCompra._instancia; }
        }
        public List<entOrdenDeCompra> ListarOrdenDeCompra()
        {
            return datOrdenDeCompra.Instancia.ListarOrdenDeCompra();
        }
        public void InsertaOrdenDeCompra(entOrdenDeCompra oc)
        {

            datOrdenDeCompra.Instancia.InsertarOrdenDeCompra(oc);
        }
    }
}
