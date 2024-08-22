using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Utilidades;
using Negocio;

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
                ocultarColumnas();
                pictureBoxCatalogo.Load(listaDispositivo[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvCatalogo.Columns["ImagenUrl"].Visible = false;
            dgvCatalogo.Columns["Id"].Visible = false;
            dgvCatalogo.Columns["Descripcion"].Visible=false;

        }



        private void dgvCatalogo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Dispositivo seleccionado = (Dispositivo)dgvCatalogo.CurrentRow.DataBoundItem;
                if (seleccionado != null)
                {
                    cargarImagen(seleccionado.ImagenUrl);
                    labelDescripcion.Text = seleccionado.Descripcion;
                }
                else
                {
                    cargarImagen("nada");
                    labelDescripcion.Text = "";

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxCatalogo.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBoxCatalogo.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }
        }


        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FormAltaDispositivo agregar = new FormAltaDispositivo();
            agregar.ShowDialog();
            cargar_form();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Dispositivo seleccionado;
            seleccionado = (Dispositivo)dgvCatalogo.CurrentRow.DataBoundItem;

            FormAltaDispositivo modificar = new FormAltaDispositivo(seleccionado);
            modificar.ShowDialog();
            cargar_form();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            CatalogoNegocio negocio = new CatalogoNegocio();
            Dispositivo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Estás seguro?","Eliminandi",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Dispositivo)dgvCatalogo.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar_form();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }



        private void txtbox_Filtro_TextChanged(object sender, EventArgs e)
        {
            List<Dispositivo> listafiltrada;
            string filtro = txtbox_Filtro.Text;

            if (filtro != "")
            {
                listafiltrada = listaDispositivo.FindAll(Dispositivo => Dispositivo.Nombre.ToUpper().Contains(txtbox_Filtro.Text.ToUpper()));
            }
            else
            {
                listafiltrada = listaDispositivo;
            }

            dgvCatalogo.DataSource = null;
            dgvCatalogo.DataSource = listafiltrada;
            ocultarColumnas();
        }


    }
}
