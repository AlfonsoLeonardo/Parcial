using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class HechizoMagoNegocio
    {
        public List<HechizoMago> ListarHechizoMago(int Idmago)
        {

            List<HechizoMago> listado = new List<HechizoMago>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            HechizoMago hechizoMago = new HechizoMago();
            Hechizo hechizo = new Hechizo();
            try
            {
                accesoDatos.setearConsulta("select h.Id,h.Nombre,h.Descripcion from HECHIZOSMAGOS as hm, HECHIZOS as h,MAGOS as m where hm.IdMago=m.Id and h.Id=hm.IdHechizo and m.Id =@IdMago");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@IdMago",Idmago);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    hechizoMago = new HechizoMago();
                    hechizoMago.Id = (int)accesoDatos.Lector["Id"];
                    hechizoMago.hechizo = new Hechizo();
                    hechizoMago.hechizo.Id = (int)accesoDatos.Lector["Id"];
                    hechizoMago.hechizo.Nombre = accesoDatos.Lector["Nombre"].ToString();
                    hechizoMago.hechizo.Descripcion = accesoDatos.Lector["Descripcion"].ToString();

                    listado.Add(hechizoMago);
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

    }
}
