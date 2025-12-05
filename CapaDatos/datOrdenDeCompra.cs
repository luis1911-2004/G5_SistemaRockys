using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datOrdenDeCompra
    {
        private static readonly datOrdenDeCompra _instancia = new datOrdenDeCompra();
        public static datOrdenDeCompra Instancia
        {
            get { return datOrdenDeCompra._instancia; }
        }

        public List<entOrdenDeCompra> ListarOrdenDeCompra()
        {
            SqlCommand cmd = null;
            List<entOrdenDeCompra> lista = new List<entOrdenDeCompra>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarOrdenDeCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entOrdenDeCompra oc = new entOrdenDeCompra();
                    oc.OrdenDeCompraID = Convert.ToInt32(dr["OrdenDeCompraID"]);
                    oc.Fecha = Convert.ToDateTime(dr["Fecha"]);
                    oc.EstadoOrden = dr["EstadoOrden"].ToString();

                    // Mapeo de los campos del JOIN
                    oc.NombreProveedor = dr["NombreProveedor"].ToString();
                    oc.DescripcionRequerimiento = dr["DescripcionRequerimiento"].ToString();

                    lista.Add(oc);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return lista;
        }
        public Boolean InsertarOrdenDeCompra(entOrdenDeCompra oc)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarOrdenDeCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Solo asignamos los IDs de las llaves foráneas
                cmd.Parameters.AddWithValue("@ProveedorID", oc.ProveedorID);
                cmd.Parameters.AddWithValue("@RequerimientoID", oc.RequerimientoID);
                // ELIMINAMOS: cmd.Parameters.AddWithValue("@Fecha", oc.Fecha);

                cn.Open();
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return inserta;
        }
    }
}
