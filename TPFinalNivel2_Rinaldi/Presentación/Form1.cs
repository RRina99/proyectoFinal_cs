using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FormPrincipal : Form
    {
        private List<Dispositivo> listaDispositivo;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            cargar_form();
        }
        private void cargar_form()
        {
            try
            {
                CatalogoNegocio negocio = new CatalogoNegocio();
                listaDispositivo = negocio.listar();
                dgvCatalogo.DataSource = listaDispositivo;
                dgvCatalogo.Columns["ImagenUrl"].Visible = false;
                pictureBoxCatalogo.Load(listaDispositivo[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvCatalogo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Dispositivo seleccionado = (Dispositivo)dgvCatalogo.CurrentRow.DataBoundItem;
                pictureBoxCatalogo.Load(seleccionado.ImagenUrl);
            }
            catch (Exception)
            {
                pictureBoxCatalogo.Load("https://i0.wp.com/casagres.com.ar/wp-content/uploads/2022/09/placeholder.png?ssl=1");
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FormAltaDispositivo agregar = new FormAltaDispositivo();
            agregar.ShowDialog();
            cargar_form();
        }
    }
}
