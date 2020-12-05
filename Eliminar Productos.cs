using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOIS1
{
    public partial class Eliminar_Productos : Form
    {
        public Eliminar_Productos()
        {
            InitializeComponent();
            buttonModificar.Enabled = false;
            buttonLimpiar.Enabled = false;
        }
        private void _limpiarCampos()
        {
            textBoxNombreProducto.Text = "";
            textBoxPrecio.Text = "";
            textBoxCodigoProveedor.Text = "";
            textBoxNumeroProducto.Text = "";

            buttonModificar.Enabled = false;
            buttonLimpiar.Enabled = false;
            buttonVerificar.Enabled = true;
            textBoxNumeroProducto.Enabled = true;
        }

        private void ButtonVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                int BD_idProveedor = int.Parse(textBoxNumeroProducto.Text);
                string urlAddress = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/Producto_Verificar.php";

                using (WebClient client = new WebClient())
                {
                    NameValueCollection postData = new NameValueCollection()
                    {
                          { "bd_idProducto", BD_idProveedor.ToString() }
                   };

                    string SW_respuesta = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                    switch (SW_respuesta[0])
                    {
                        case '0':
                            MessageBox.Show("NO EXISTE NINGUN PRODUCTO CON EL CODIGO: " + BD_idProveedor, "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxNumeroProducto.Text = "";
                            break;

                        case '9':
                            MessageBox.Show("NO SE PUDO ESTABLECER CONEXION CON LA BASE DE DATOS", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        default:
                            char SW_delimitador = ',';
                            string[] SW_campos = SW_respuesta.Split(SW_delimitador);
                            textBoxNombreProducto.Text = SW_campos[0];
                            textBoxPrecio.Text = SW_campos[1];
                            textBoxCodigoProveedor.Text = SW_campos[2];
                            buttonModificar.Enabled = true;
                            buttonLimpiar.Enabled = true;
                            buttonVerificar.Enabled = false;
                            textBoxNumeroProducto.Enabled = false;
                            break;
                    }



                }


            }
            catch
            {
                MessageBox.Show("Ingresaste un dato erroneo; Revisa que los datos que ingresaste sean correctos, puede que hayas escrito mal algo o que falte algun dato.", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            _limpiarCampos();
        }

        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int BD_idProveedor = int.Parse(textBoxNumeroProducto.Text);
                string urlAddress = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/Producto_Eliminar.php";

                using (WebClient client = new WebClient())
                {
                    NameValueCollection postData = new NameValueCollection()
                    {
                          { "bd_idProducto", BD_idProveedor.ToString() }
                   };
                    string SW_respuesta = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                    switch (SW_respuesta[0])
                    {
                        case '0':
                            MessageBox.Show("FALLA EN LA OPERACION SQL", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        case '2':
                            MessageBox.Show("EL CODIGO DE PRODUCTO YA EXISTE", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        case '8':
                            MessageBox.Show("AUN SE TIENE ESTE PRODUCTO EN EL INVENTARIO", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case '9':
                            MessageBox.Show("NO SE PUDO ESTABLECER CONEXION CON LA BASE DE DATOS", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        default:
                            MessageBox.Show("SE ELIMINO CORRECTAMENTE EL PRODUCTO", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                    _limpiarCampos();




                }


            }
            catch
            {
                MessageBox.Show("Ingresaste un dato erroneo; Revisa que los datos que ingresaste sean correctos, puede que hayas escrito mal algo o que falte algun dato.", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
