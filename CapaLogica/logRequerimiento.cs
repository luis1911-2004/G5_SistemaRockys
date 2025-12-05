using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logRequerimiento
    {
        #region sigleton
        private static readonly logRequerimiento _instancia = new logRequerimiento();
        public static logRequerimiento Instancia
        {
            get { return logRequerimiento._instancia; }
        }
        #endregion sigleton

        #region metodos
        /// listado
        public List<entRequerimiento> ListarRequerimiento()
        {
            return datRequerimiento.Instancia.ListarRequerimiento();
        }


        public void InsertaRequerimiento(entRequerimiento req)
        {
            datRequerimiento.Instancia.InsertarRequerimiento(req);
        }
        public void EliminarRequerimiento(entRequerimiento req)
        {
            datRequerimiento.Instancia.EliminarRequerimiento(req);
        }
        #endregion metodos
    }
}
