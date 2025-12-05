using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOrdenDeCompra
    {
        public int OrdenDeCompraID { get; set; }
        public System.DateTime Fecha { get; set; } // Ajustado a DateTime
        public string EstadoOrden { get; set; }

        // Propiedades del JOIN para el listado
        public string NombreProveedor { get; set; }
        public string DescripcionRequerimiento { get; set; }

        // Propiedades de la llave foránea que usaremos para otras operaciones
        public int ProveedorID { get; set; }
        public int RequerimientoID { get; set; }
    }
}
