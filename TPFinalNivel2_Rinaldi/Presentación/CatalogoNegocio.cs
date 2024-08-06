using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    internal class CatalogoNegocio
    {
        public List<Dispositivo> listar()
        {
            List<Dispositivo> lista = new List<Dispositivo>();
            ClaseConexion datos = new ClaseConexion();
            try
            {
                datos.setearConsulta("select Codigo, Nombre, A.Descripcion, ImagenUrl, C.Descripcion Dispositivo, M.Descripcion Marca, Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdCategoria = C.Id and M.Id = A.IdMarca");
                datos.hacerLectura();

                while (datos.Lector.Read())
                {
                    Dispositivo aux = new Dispositivo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];                    
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];                                                                                     
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Dispositivo"];
                    aux.Marca = new Marca();    
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();
            }   
        }
        public void agregar(Dispositivo dispositivo)
        {   
            ClaseConexion datos = new ClaseConexion();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl,Precio) values (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @urlImagen, @precio)");
                datos.setearParametros("@codigo",dispositivo.Codigo);
                datos.setearParametros("@nombre",dispositivo.Nombre);
                datos.setearParametros("@descripcion",dispositivo.Descripcion);
                datos.setearParametros("@idMarca", dispositivo.Marca.Id);
                datos.setearParametros("@idCategoria",dispositivo.Categoria.Id);
                datos.setearParametros("@urlImagen", dispositivo.ImagenUrl);
                datos.setearParametros("@precio", dispositivo.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();
            }
        }
    }

}
