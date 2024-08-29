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
    public partial class FormAltaDispositivo : Form
    {
        private Dispositivo dispositivo = null;

        public FormAltaDispositivo()
        {
            InitializeComponent();
        }
        public FormAltaDispositivo(Dispositivo dispositivo)
        {
            InitializeComponent();
            this.dispositivo = dispositivo;
            Text = "Modificar Dispositivo";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_agregarNuevoDis_Click(object sender, EventArgs e)
        {   
               
            CatalogoNegocio negocio = new CatalogoNegocio();
            try
            {   
                if (dispositivo == null)
                    dispositivo = new Dispositivo();
                
                dispositivo.Codigo = txtbox_Codigo.Text;
                dispositivo.Nombre = txtbox_Nombre.Text;    
                dispositivo.Descripcion = txtbox_Descripcion.Text;
                dispositivo.ImagenUrl = txtbox_UrlImagen.Text;
                dispositivo.Marca = (Marca)comboBox_Marca.SelectedItem;
                dispositivo.Categoria = (Categoria)comboBox_Categoria.SelectedItem;
                dispositivo.Precio = decimal.Parse(txtbox_Precio.Text);

               if(dispositivo.Id != 0)
                {
                    negocio.modificar(dispositivo);
                    MessageBox.Show("Dispositivo modificado");
                }
                else
                {
                    negocio.agregar(dispositivo);
                    MessageBox.Show("Dispositivo agregado");
                }

                Close();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Hay campos obligatorios vacíos");
                
            }

        }

        private void FormAltaDispositivo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            
            try
            {
                comboBox_Categoria.DataSource = categoriaNegocio.listar();
                comboBox_Categoria.ValueMember = "Id";
                comboBox_Categoria.DisplayMember = "Descripcion";
                comboBox_Marca.DataSource     = marcaNegocio.listar();
                comboBox_Marca.ValueMember = "Id";    
                comboBox_Marca.DisplayMember = "Descripcion";

                if (dispositivo != null)
                {
                    txtbox_Codigo.Text = dispositivo.Codigo;
                    txtbox_Nombre.Text = dispositivo.Nombre;
                    txtbox_Descripcion.Text = dispositivo.Descripcion;
                    txtbox_UrlImagen.Text=dispositivo.ImagenUrl;
                    cargarImagen(dispositivo.ImagenUrl);
                    txtbox_Precio.Text = dispositivo.Precio.ToString();
                    comboBox_Categoria.SelectedValue = dispositivo.Categoria.Id;
                    comboBox_Marca.SelectedValue = dispositivo.Marca.Id;
                }

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
                pictureBoxCarga.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBoxCarga.Load("https://i0.wp.com/casagres.com.ar/wp-content/uploads/2022/09/placeholder.png?ssl=1");
            }
        }
        private void txtbox_UrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtbox_UrlImagen.Text);
        }

        private void txtbox_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
           if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta",MessageBoxButtons.OK, MessageBoxIcon.Error);   
                e.Handled = true;
                return;
            }
  
        }

    }   
}   
