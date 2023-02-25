using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using BaseDeDatos;


namespace negocio
{
    public class CatalogoNegocio
    {
        public List<Catalogo> listar()
        {
            List<Catalogo> lista = new List<Catalogo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Codigo, Nombre, A.Descripcion, ImagenUrl, M.Descripcion Marca, C.Descripcion Categoria, Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where C.Id = A.IdCategoria and M.Id = A.IdMarca");
                datos.ejecutarLectura();                

                while (datos.Lector.Read())
                {
                    Catalogo aux = new Catalogo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];                    
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];                    
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
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

        public void agregar(Catalogo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio)values(@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @imagenUrl, @precio)");
                datos.setearParametro("@codigo", nuevo.Codigo);
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@idMarca", nuevo.Marca.Id);
                datos.setearParametro("@idCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@imagenUrl", nuevo.ImagenUrl);
                datos.setearParametro("@precio", nuevo.Precio);
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
