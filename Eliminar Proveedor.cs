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
    public partial class Eliminar_Proveedor : Form
    {
        public Eliminar_Proveedor()
        {
            InitializeComponent();
            buttonLimpiar.Enabled = false;
            buttonModificar.Enabled = false;
        }
        private void _limpiarCampos()
        {
            textBoxCodigoProveedor.Text = "";
            textBoxNombreProveedor.Text = "";
            textBoxTelefono.Text = "";
            textBoxDireccion.Text = "";

            buttonModificar.Enabled = false;
            buttonLimpiar.Enabled = false;
            buttonVerificar.Enabled = true;
            textBoxCodigoProveedor.Enabled = true;
        }

        private void ButtonVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                int BD_idProveedor = int.Parse(textBoxCodigoProveedor.Text);
                string urlAddress = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/Proveedor_Verificar.php";

                using (WebClient client = new WebClient())
                {
                    NameValueCollection postData = new NameValueCollection()
                    {
                          { "bd_idProveedor", BD_idProveedor.ToString() }
                   };

                    string SW_respuesta = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                    switch (SW_respuesta[0])
                    {
                        case '0':
                            MessageBox.Show("NO EXISTE NINGUN PROVEEDOR CON EL CODIGO: " + BD_idProveedor, "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;


                        case '9':
                            MessageBox.Show("NO SE PUDO ESTABLECER CONEXION CON LA BASE DE DATOS", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        default:
                            char SW_delimitador = ',';
                            string[] SW_campos = SW_respuesta.Split(SW_delimitador);
                            textBoxNombreProveedor.Text = SW_campos[0];
                            textBoxTelefono.Text = SW_campos[1];
                            textBoxDireccion.Text = SW_campos[2];
                            buttonModificar.Enabled = true;
                            buttonLimpiar.Enabled = true;
                            buttonVerificar.Enabled = false;
                            textBoxCodigoProveedor.Enabled = false; break;
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
            DialogResult dr = MessageBox.Show("Deceas borrar el proveedor \"" + textBoxNombreProveedor.Text + "\".",
             "ADVERTENCIA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            switch (dr)
            {
                case DialogResult.Yes:

                    int AUX_NumCod = int.Parse(textBoxCodigoProveedor.Text);
                    int BD_idProveedor = int.Parse(textBoxCodigoProveedor.Text);
                    string urlAddress = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/Proveedor_Eliminar.php";

                    using (WebClient client = new WebClient())
                    {
                        NameValueCollection postData = new NameValueCollection()
                    {
                          { "bd_idProveedor", BD_idProveedor.ToString() }
                   };
                        string SW_respuesta = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                        switch (SW_respuesta[0])
                        {
                            case '0':
                                MessageBox.Show("NO SE PUEDE BORRAR A ESTE PROVEDOR POR QUE AUN HAY PRODUCTOS ASOCIADOS CON EL: ", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            case '2':
                                MessageBox.Show("EL CODIGO DE PRODUCTO YA EXISTE", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            case '9':
                                MessageBox.Show("NO SE PUDO ESTABLECER CONEXION CON LA BASE DE DATOS", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            default:
                                MessageBox.Show("Borrado con exito");
                                break;
                        }
                        _limpiarCampos();
                    }
                    break;
            }
        }
    }
}
