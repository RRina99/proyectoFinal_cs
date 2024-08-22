using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Dominio;
using Utilidades;

namespace Negocio
{
    public class CatalogoNegocio
    {
        public List<Dispositivo> listar()
        {
            List<Dispositivo> lista = new List<Dispositivo>();
            ClaseConexion datos = new ClaseConexion();
            try
            {
                datos.setearConsulta("select Codigo, Nombre, A.Descripcion, ImagenUrl, C.Descripcion Dispositivo, M.Descripcion Marca, Precio, A.IdMarca, A.IdCategoria, A.Id from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdCategoria = C.Id and M.Id = A.IdMarca");
                datos.hacerLectura();

                while (datos.Lector.Read())
                {
                    Dispositivo aux = new Dispositivo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];     
                    
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];   
                    
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Dispositivo"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
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
        public void modificar(Dispositivo dispositivo)
        {
            ClaseConexion datos = new ClaseConexion();

            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idmarca, IdCategoria = @idcategoria, ImagenUrl = @imagenurl, Precio = @precio where Id = @id");
                datos.setearParametros("@codigo", dispositivo.Codigo);
                datos.setearParametros("@nombre", dispositivo.Nombre);
                datos.setearParametros("@descripcion", dispositivo.Descripcion);
                datos.setearParametros("@idmarca", dispositivo.Marca.Id);
                datos.setearParametros("@idcategoria", dispositivo.Categoria.Id);
                datos.setearParametros("@imagenurl", dispositivo.ImagenUrl);
                datos.setearParametros("@precio", dispositivo.Precio);
                datos.setearParametros("@id", dispositivo.Id);
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
        public void eliminar(int id)
        {
            try
            {
                ClaseConexion datos = new ClaseConexion();
                datos.setearConsulta("delete from ARTICULOS where id = @id");
                datos.setearParametros("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }













    }

}
