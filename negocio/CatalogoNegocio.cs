using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class CatalogoNegocio
    {
        public List<Catalogo> listar()
        {
            List<Catalogo> lista = new List<Catalogo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio From ARTICULOS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Catalogo aux = new Catalogo();
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.IdMarca = (int)lector["IdMarca"];
                    aux.IdCategoria = (int)lector["IdCategoria"];
                    aux.ImagenUrl = (string)lector["ImagenUrl"];
                    aux.Precio = (decimal)lector["Precio"];
                    

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
                conexion.Close();
            }

            
        }
    }
}
