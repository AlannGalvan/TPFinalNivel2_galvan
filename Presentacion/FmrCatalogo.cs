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
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class FmrCatalogo : Form
    {
        private List<Catalogo> listaCatalogo;
        public FmrCatalogo()
        {
            InitializeComponent();
        }

        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ptbMaximizar.Visible = false;
            ptbRestaurar.Visible = true;
        }

        private void ptbRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ptbRestaurar.Visible = false;
            ptbMaximizar.Visible = true;

        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelArriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FmrCatalogo_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dgvTablaBD_SelectionChanged(object sender, EventArgs e)
        {
            Catalogo seleccionado = (Catalogo)dgvTablaBD.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
        }

        private void cargar()
        {
            CatalogoNegocio negocio = new CatalogoNegocio();
            try
            {
                listaCatalogo = negocio.listar();
                dgvTablaBD.DataSource = listaCatalogo;
                dgvTablaBD.Columns["Descripcion"].Visible = false;
                dgvTablaBD.Columns["ImagenUrl"].Visible = false;
                cargarImagen(listaCatalogo[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                ptbCatalogo.Load(imagen);
            }
            catch (Exception ex)
            {
                ptbCatalogo.Load("https://www.christushealth.org/-/media/images/components/defaults/placeholderimage.jpg");
                
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            fmrAgregarProducto alta = new fmrAgregarProducto();
            alta.ShowDialog();
            cargar();

        }
    }
}
