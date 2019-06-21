using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class HechizoNegocio
    {
        public List<Hechizo> ListarHechizo()
        {

            List<Hechizo> listado = new List<Hechizo>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Hechizo hechizo = new Hechizo();
            try
            {
                accesoDatos.setearConsulta("select * from hechizos");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    hechizo = new Hechizo();
                    hechizo.Id = (int)accesoDatos.Lector["Id"];
                    hechizo.Nombre = accesoDatos.Lector["Nombre"].ToString();




                    listado.Add(hechizo);
                }


                return listado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();

            }
        }
        public void agregarHechizo(HechizoMago nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = "data source=(local); initial catalog=MAGOS_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SET DATEFORMAT 'DMY' insert into HECHIZOSMAGOS (IdMago, IdHechizo) values ('" + nuevo.mago.Id + "','" + nuevo.hechizo.Id + "')";
                comando.Connection = conexion;
                conexion.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
