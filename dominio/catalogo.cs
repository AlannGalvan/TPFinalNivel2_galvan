using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class catalogo
    {
        public string CodigoArticulo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string IdMarca { get; set; }

        public int IdCategoria { get; set; }

        public string ImagenUrl { get; set; }

        public float Precio { get; set; }
    }
}
