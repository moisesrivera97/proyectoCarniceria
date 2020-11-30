using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOIS1
{
    public partial class Modifica_Productos : Form
    {
        public Modifica_Productos()
        {
            InitializeComponent();
        }

      

    

        private void Modifica_Productos_Load(object sender, EventArgs e)
        {

        }

        private void Modifica_Productos_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Menu_Productos AA = new Menu_Productos();
            AA.Show();
        }

        private void Boton_Verificar_Click_1(object sender, EventArgs e)
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
                            Input_NomProd.Enabled = true;
                            Input_Precio.Enabled = true;
                            Input_CodigoProveedor.Enabled = true;
                            Boton_Modificar.Enabled = true;
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

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deceas modificar el producto \"" + Input_NumProducto.Text + "\".",
                        "ADVERTENCIA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            switch (dr)
            {
                case DialogResult.Yes:

                    try
                    {
                        int BD_idProveedor = int.Parse(Input_NumProducto.Text);
                        string BD_nombre = Input_NomProd.Text.ToUpper();
                        double BD_precio = double.Parse(Input_Precio.Text);
                        int BD_fkProveedor = int.Parse(Input_CodigoProveedor.Text);

                        if (BD_idProveedor > 0 && BD_nombre.Length > 0 && BD_precio > 0 && BD_fkProveedor > 0)
                        {
                            string urlAddress = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/Producto_Modificar.php";

                            using (WebClient client = new WebClient())
                            {
                                NameValueCollection postData = new NameValueCollection()
                {
                      { "bd_idProducto", BD_idProveedor.ToString() },
                      { "bd_nombre", BD_nombre },
                      { "bd_precio", BD_precio.ToString()  },
                      { "bd_fkProveedor", BD_fkProveedor.ToString() }
               };
                                string SW_respuesta = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                                switch (SW_respuesta[0])
                                {
                                    case '0':
                                        MessageBox.Show("NO SE ENCUENTRA NINGUN PROVEEDOR CON ESTE ID", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;

                                    case '8':
                                        MessageBox.Show("ESE PROVEEDOR NO EXISTE", "ERROR #:", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                                        break;
                                    case '9':
                                        MessageBox.Show("NO SE PUDO ESTABLECER CONEXION CON LA BASE DE DATOS", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;

                                    default:
                                        MessageBox.Show("SE MODIFICO CORRECTAMENTE EL PRODUCTO", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Ingresaste un dato erroneo; Revisa que los datos que ingresaste sean correctos, puede que hayas escrito mal algo", "ERROR #:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    break;

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

            Boton_Modificar.Enabled = false;
            Boton_Limpiar.Enabled = false;
            Boton_Verificar.Enabled = true;
            Input_NumProducto.Enabled = true;
            Input_NomProd.Enabled = false;
            Input_Precio.Enabled = false;
            Input_CodigoProveedor.Enabled = false;
        }

      
    }
}
