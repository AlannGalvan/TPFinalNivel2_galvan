using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace dominio
{
    public class Catalogo
    {
        public int Id { get; set; }

        [DisplayName("Código")]
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public string ImagenUrl { get; set; }
        public Marca Marca { get; set; }        
        public Categoria Categoria { get; set; }

        private decimal _precio;

        public decimal Precio
        {
            get { return _precio; }
            set { _precio = Math.Round(value, 2); }
        }


    }
}
