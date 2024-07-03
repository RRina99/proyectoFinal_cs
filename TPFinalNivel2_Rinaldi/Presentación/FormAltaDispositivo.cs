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
    public partial class FormAltaDispositivo : Form
    {
        public FormAltaDispositivo()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_agregarNuevoDis_Click(object sender, EventArgs e)
        {   
            Dispositivo dispositivo = new Dispositivo();    
            CatalogoNegocio negocio = new CatalogoNegocio();
            try
            {
                dispositivo.Codigo = txtbox_Codigo.Text;
                dispositivo.Nombre = txtbox_Nombre.Text;    
                dispositivo.Descripcion = txtbox_Descripcion.Text;
                dispositivo.ImagenUrl = txtbox_UrlImagen.Text;
                dispositivo.Marca = (Marca)comboBox_Marca.SelectedItem;
                dispositivo.Categoria = (Categoria)comboBox_Categoria.SelectedItem;
                dispositivo.Precio = int.Parse(txtbox_Precio.Text);

                negocio.agregar(dispositivo);
                MessageBox.Show("Dispositivo agregado");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void FormAltaDispositivo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            
            try
            {
                comboBox_Categoria.DataSource = categoriaNegocio.listar();
                comboBox_Marca.DataSource     = marcaNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
