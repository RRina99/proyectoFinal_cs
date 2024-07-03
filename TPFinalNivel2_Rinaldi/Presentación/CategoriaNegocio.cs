﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Presentación
{
    internal class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
			List<Categoria> lista = new List<Categoria>();
			ClaseConexion datos = new ClaseConexion();
			try
			{
				datos.setearConsulta("select Id, Descripcion from CATEGORIAS");
				datos.hacerLectura();
				while (datos.Lector.Read())
				{
					Categoria aux = new Categoria();
					aux.Id = (int)datos.Lector["Id"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];
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
    }
}
