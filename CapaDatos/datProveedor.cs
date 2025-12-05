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
    public class datProveedor
    {
        #region sigleton

        private static readonly datProveedor _instancia = new datProveedor();
        public static datProveedor Instancia
        {
            get { return datProveedor._instancia; }
        }
        #endregion sigleton

        #region metodos

        public List<entProveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                // Usa la conexión existente (Patrón Singleton)
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("spListarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entProveedor Provee = new entProveedor();
                    Provee.ProveedorID = Convert.ToInt32(dr["ProveedorID"]);
                    Provee.NombreProveedor = dr["NombreProveedor"].ToString();
                    Provee.RUC = dr["RUC"].ToString();
                    Provee.TelefonoProvee = dr["TelefonoProvee"].ToString();
                    Provee.CiudadProvee = dr["CiudadProvee"].ToString();
                    Provee.DireccionProvee = dr["DireccionProvee"].ToString();
                    Provee.Rubro = dr["Rubro"].ToString();
                    lista.Add(Provee);
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



        public Boolean InsertarProveedor(entProveedor Provee)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Asignación de parámetros
                cmd.Parameters.AddWithValue("@NombreProveedor", Provee.NombreProveedor);
                cmd.Parameters.AddWithValue("@RUC", Provee.RUC);
                cmd.Parameters.AddWithValue("@TelefonoProvee", Provee.TelefonoProvee);
                cmd.Parameters.AddWithValue("@CiudadProvee", Provee.CiudadProvee);
                cmd.Parameters.AddWithValue("@DireccionProvee", Provee.DireccionProvee);
                cmd.Parameters.AddWithValue("@Rubro", Provee.Rubro);

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

        public Boolean EditarProveedor(entProveedor Provee)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProveedorID", Provee.ProveedorID);
                cmd.Parameters.AddWithValue("@NombreProveedor", Provee.NombreProveedor);
                cmd.Parameters.AddWithValue("@RUC", Provee.RUC);
                cmd.Parameters.AddWithValue("@TelefonoProvee", Provee.TelefonoProvee);
                cmd.Parameters.AddWithValue("@CiudadProvee", Provee.CiudadProvee);
                cmd.Parameters.AddWithValue("@DireccionProvee", Provee.DireccionProvee);
                cmd.Parameters.AddWithValue("@Rubro", Provee.Rubro);

                cn.Open();
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    edita = true;
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
            return edita;
        }

        public Boolean EliminarProveedor(entProveedor Provee)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Solo necesitamos el ID para la eliminación
                cmd.Parameters.AddWithValue("@ProveedorID", Provee.ProveedorID);

                cn.Open();
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    elimina = true;
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
            return elimina;
        }
        #endregion metodos
    }
}
