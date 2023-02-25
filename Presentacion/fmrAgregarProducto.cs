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
using negocio;

namespace Presentacion
{
    public partial class fmrAgregarProducto : Form
    {
        public fmrAgregarProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Catalogo nuevo = new Catalogo();
            CatalogoNegocio negocio = new CatalogoNegocio();

            try
            {
                nuevo.Codigo = txtCodigo.Text;
                nuevo.Nombre = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.Marca = (Marca)cboMarca.SelectedItem;
                nuevo.Categoria = (Categoria)cboCategoria.SelectedItem;
                nuevo.ImagenUrl = txtImagenUrl.Text;
                nuevo.Precio = decimal.Parse(txtPrecio.Text);

                negocio.agregar(nuevo);
                MessageBox.Show("Agregado exitosamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void fmrAgregarProducto_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboMarca.DataSource = marcaNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
