using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class MagoNegocio
    {
        public List<Mago> ListarMago()
        {

            List<Mago> listado = new List<Mago>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Mago Magol = new Mago();
            Casa casa   = new Casa();
            try
            {
                accesoDatos.setearConsulta("select m.Id, m.nombre, c.Descripcion from MAGOS as m inner join CASAS as c on m.IdCasa=c.Id");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    Magol = new Mago();
                    Magol.Id = (int)accesoDatos.Lector["Id"];
                    Magol.Nombre = accesoDatos.Lector["Nombre"].ToString();
                    Magol.Casa = new Casa();
                    Magol.Casa.Id = (int)accesoDatos.Lector["Id"];
                    Magol.Casa.Descripcion = accesoDatos.Lector["Descripcion"].ToString();
                  


                    listado.Add(Magol);
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
