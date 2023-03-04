using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;



namespace Presentacion
{
    public partial class fmrVerMas : Form
    {
        private Catalogo catalogo;
        public fmrVerMas(Catalogo catalogo)
        {
            InitializeComponent();
            this.catalogo = catalogo;
        }

        private void fmrVerMas_Load(object sender, EventArgs e)
        {

            lblNombre.Text += catalogo.Nombre;
            lblPrecio.Text += catalogo.Precio.ToString();
            txtDescripcion.Text = catalogo.Descripcion;
            cargarImagen(catalogo.ImagenUrl);
            
            
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                ptbImagen.Load(imagen);
            }
            catch (Exception )
            {
                ptbImagen.Load("https://www.christushealth.org/-/media/images/components/defaults/placeholderimage.jpg");

            }
        }


    }
}
