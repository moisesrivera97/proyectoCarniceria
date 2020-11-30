using MySql.Data.MySqlClient;
using System;
using System.Collections.Specialized;
using System.Globalization;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace PROYECTOIS1
{
    public partial class Agregar_Productos : Form
    {
        public Agregar_Productos()
        {
            InitializeComponent();
        }

        private void Boton_Verificar_Click(object sender, EventArgs e)
        {
            try
            {
                int BD_idProducto = int.Parse(Input_NumProducto.Text);
                string BD_nombre = Input_NomProd.Text.ToUpper();
                double BD_precio = double.Parse(Input_Precio.Text);
                int BD_fkProveedor = int.Parse(Input_CodigoProveedor.Text);

                if (BD_idProducto > 0 && BD_nombre.Length > 0 && BD_precio > 0 && BD_fkProveedor > 0)
                {
                    string urlAddress = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/Producto_Agregar.php";

                    using (WebClient client = new WebClient())
                    {
                        NameValueCollection postData = new NameValueCollection()
                {
                      { "bd_idProducto", BD_idProducto.ToString() },
                      { "bd_nombre", BD_nombre },
                      { "bd_precio", BD_precio.ToString()  },
                      { "bd_fkProveedor", BD_fkProveedor.ToString()}
               };
                        string SW_respuesta = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                        switch (SW_respuesta[0])
                        {
                            case '0':
                                MessageBox.Show("NO EXISTE EL CODIGO DE ESE PROVEEDOR", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            case '2':
                                MessageBox.Show("EL CODIGO DE PRODUCTO YA EXISTE", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            case '9':
                                MessageBox.Show("NO SE PUDO ESTABLECER CONEXION CON LA BASE DE DATOS", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            default:
                                MessageBox.Show("SE AGREGO CORRECTAMENTE EL PRODUCTO", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                        _limpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Falta uno o mas campos por rellenar; Asegurate que todos los  campos esten rellenados", "ERROR #:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {
                MessageBox.Show("Ingresaste un dato erroneo; Revisa que los datos que ingresaste sean correctos, puede que hayas escrito mal algo o que falte algun dato.", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Agregar_Productos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_Productos Mn = new Menu_Productos();
            Mn.Show();
        }
        private void _limpiarCampos()
        {
            Input_NomProd.Text = "";
            Input_Precio.Text = "";
            Input_CodigoProveedor.Text = "";
            Input_NumProducto.Text = "";


        }
       
    }
}
