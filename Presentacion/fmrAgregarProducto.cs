using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace Presentacion
{
    public partial class fmrAgregarProducto : Form
    {
        private Catalogo catalogo = null;
        private OpenFileDialog archivo = null;
        public fmrAgregarProducto()
        {
            InitializeComponent();
        }
        public fmrAgregarProducto(Catalogo catalogo)
        {
            InitializeComponent();
            this.catalogo = catalogo;
            Text = "Modificar Producto";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            CatalogoNegocio negocio = new CatalogoNegocio();

            try
            {
                if (catalogo == null)
                    catalogo = new Catalogo();

                catalogo.Codigo = txtCodigo.Text;
                catalogo.Nombre = txtNombre.Text;
                catalogo.Descripcion = txtDescripcion.Text;
                catalogo.Marca = (Marca)cboMarca.SelectedItem;
                catalogo.Categoria = (Categoria)cboCategoria.SelectedItem;
                catalogo.ImagenUrl = txtImagenUrl.Text;
                catalogo.Precio = decimal.Parse(txtPrecio.Text);

                if(catalogo.Id != 0)
                {
                    negocio.modificar(catalogo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(catalogo);
                    MessageBox.Show("Agregado exitosamente");
                }

                if (archivo != null && !(txtImagenUrl.Text.ToUpper().Contains("HTTP")))
                    guardarImagenLocal();
                                
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
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                if(catalogo != null)
                {
                    txtCodigo.Text = catalogo.Codigo;
                    txtNombre.Text = catalogo.Nombre;
                    txtDescripcion.Text = catalogo.Descripcion;
                    cboMarca.SelectedValue = catalogo.Marca.Id;
                    cboCategoria.SelectedValue = catalogo.Categoria.Id;
                    txtImagenUrl.Text = catalogo.ImagenUrl;
                    cargarImagen(catalogo.ImagenUrl);
                    txtPrecio.Text = catalogo.Precio.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);           
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                ptbImagenUrl.Load(imagen);
            }
            catch (Exception ex)
            {
                ptbImagenUrl.Load("https://www.christushealth.org/-/media/images/components/defaults/placeholderimage.jpg");

            }
        }

        private void ptbAgrgarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog(); ;
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                
            }
        }

        private void guardarImagenLocal()
        {
            File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
        }
    }
}
