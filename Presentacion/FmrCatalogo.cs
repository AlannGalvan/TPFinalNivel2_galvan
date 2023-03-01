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
    public partial class FmrCatalogo : Form
    {
        private List<Catalogo> listaCatalogo;
        public FmrCatalogo()
        {
            InitializeComponent();
        }        

        private void FmrCatalogo_Load(object sender, EventArgs e)
        {
            cargar();            
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Precio");
        }

        private void dgvTablaBD_SelectionChanged(object sender, EventArgs e)
        {   
            if(dgvTablaBD.CurrentRow != null)
            {
                Catalogo seleccionado = (Catalogo)dgvTablaBD.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
      
        }

        private void cargar()
        {
            CatalogoNegocio negocio = new CatalogoNegocio();
            try
            {
                listaCatalogo = negocio.listar();
                dgvTablaBD.DataSource = listaCatalogo;
                ocultarCulumnas();
                cargarImagen(listaCatalogo[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarCulumnas()
        {
            dgvTablaBD.Columns["Id"].Visible = false;
            dgvTablaBD.Columns["Descripcion"].Visible = false;
            dgvTablaBD.Columns["ImagenUrl"].Visible = false;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            fmrAgregarProducto alta = new fmrAgregarProducto();
            alta.ShowDialog();
            cargar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Catalogo seleccionado;
            seleccionado = (Catalogo)dgvTablaBD.CurrentRow.DataBoundItem;

            fmrAgregarProducto modificar = new fmrAgregarProducto(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            CatalogoNegocio negocio = new CatalogoNegocio();
            Catalogo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De Verdad Querés Eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Catalogo)dgvTablaBD.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltroBuscar_Click(object sender, EventArgs e)
        {
            CatalogoNegocio negocio = new CatalogoNegocio();
            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvTablaBD.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Catalogo> listaFriltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 2)
            {
                listaFriltrada = listaCatalogo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFriltrada = listaCatalogo;
            }

            dgvTablaBD.DataSource = null;
            dgvTablaBD.DataSource = listaFriltrada;
            ocultarCulumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if(opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }
    }
}
