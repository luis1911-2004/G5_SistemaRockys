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
    public class datRequerimiento
    {
        #region sigleton
        private static readonly datRequerimiento _instancia = new datRequerimiento();
        public static datRequerimiento Instancia
        {
            get { return datRequerimiento._instancia; }
        }
        #endregion sigleton

        #region metodos
        //////////////////// listado de Requerimientos
        public List<entRequerimiento> ListarRequerimiento()
        {
            SqlCommand cmd = null;
            List<entRequerimiento> lista = new List<entRequerimiento>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // Obtiene la conexión
                cmd = new SqlCommand("spListarRequerimiento", cn); // Llama al Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entRequerimiento req = new entRequerimiento();
                    req.RequerimientoID = Convert.ToInt32(dr["RequerimientoID"]);
                    req.Descripcion = dr["Descripcion"].ToString();
                    req.EstadoDeRequerimiento = dr["EstadoDeRequerimiento"].ToString();
                    lista.Add(req);
                }
            }
            catch (Exception e)
            {
                throw e; // Lanza la excepción para que se maneje en la capa superior
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
        public Boolean InsertarRequerimiento(entRequerimiento req)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarRequerimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Asignación de parámetros
                cmd.Parameters.AddWithValue("@Descripcion", req.Descripcion);

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

        public Boolean EliminarRequerimiento(entRequerimiento req)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarRequerimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Solo necesitamos el ID para la eliminación
                cmd.Parameters.AddWithValue("@RequerimientoID", req.RequerimientoID);

                cn.Open();
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    elimina = true;
                }
            }
            catch (Exception e)
            {
                // Se lanza la excepción para manejar el error de llave foránea en la capa de presentación
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return elimina;
        }
        #endregion metodos

    }
}
