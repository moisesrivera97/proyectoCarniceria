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
        }

        private void Eliminar_Productos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_Productos AA = new Menu_Productos();
            AA.Show();
        }

        private void Boton_Verificar_Click(object sender, EventArgs e)
        {
            try
            {
                int BD_idProveedor = int.Parse(Input_NumProducto.Text);
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
                            Input_NumProducto.Text = "";
                            break;

                        case '9':
                            MessageBox.Show("NO SE PUDO ESTABLECER CONEXION CON LA BASE DE DATOS", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        default:
                            char SW_delimitador = ',';
                            string[] SW_campos = SW_respuesta.Split(SW_delimitador);
                            Input_NomProd.Text = SW_campos[0];
                            Input_Precio.Text = SW_campos[1];
                            Input_CodigoProveedor.Text = SW_campos[2];
                            Boton_Eliminar.Enabled = true;
                            Boton_Limpiar.Enabled = true;
                            Boton_Verificar.Enabled = false;
                            Input_NumProducto.Enabled = false;
                            break;
                    }
                    
                   

                }


            }
            catch
            {
                MessageBox.Show("Ingresaste un dato erroneo; Revisa que los datos que ingresaste sean correctos, puede que hayas escrito mal algo o que falte algun dato.", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Boton_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int BD_idProveedor = int.Parse(Input_NumProducto.Text);
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

        private void Boton_Limpiar_Click(object sender, EventArgs e)
        {
            _limpiarCampos();
        }

        private void _limpiarCampos()
        {
            Input_NomProd.Text = "";
            Input_Precio.Text = "";
            Input_CodigoProveedor.Text = "";
            Input_NumProducto.Text = "";

            Boton_Eliminar.Enabled = false;
            Boton_Limpiar.Enabled = false;
            Boton_Verificar.Enabled = true;
            Input_NumProducto.Enabled = true;
        }

        private void Eliminar_Productos_Load(object sender, EventArgs e)
        {

        }
    }
}
