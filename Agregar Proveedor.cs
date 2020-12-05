using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Net;

namespace PROYECTOIS1
{
    public partial class Agregar_Proveedor : Form
    {
        public Agregar_Proveedor()
        {
            InitializeComponent();
        }
        private void _limpiarCampos()
        {
            textBoxClaveProveedor.Text = "";
            textBoxNombreProveedor.Text = "";
            textBoxTelefono.Text = "";
            textBoxDireccion.Text = "";
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int BD_idProveedor = int.Parse(textBoxClaveProveedor.Text);
                string BD_nombre = textBoxNombreProveedor.Text.ToUpper();
                string BD_direccion = textBoxDireccion.Text.ToUpper();
                long BD_telefono = long.Parse(textBoxTelefono.Text);

                if (BD_idProveedor > 0 && BD_nombre.Length > 0 && BD_direccion.Length > 0 && BD_telefono > 0)
                {
                    string urlAddress = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/Proveedor_Agregar.php";

                    using (WebClient client = new WebClient())
                    {
                        NameValueCollection postData = new NameValueCollection()
                {
                      { "bd_idProveedor", BD_idProveedor.ToString() },
                      { "bd_nombre", BD_nombre },
                      { "bd_telefono", BD_telefono.ToString()  },
                      { "bd_direccion", BD_direccion }
               };
                        string SW_respuesta = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                        switch (SW_respuesta[0])
                        {
                            case '0':
                                MessageBox.Show("FALLA EN LA OPERACION SQL", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            case '2':
                                MessageBox.Show("EL CODIGO DE PROVEEDOR YA EXISTE", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            case '9':
                                MessageBox.Show("NO SE PUDO ESTABLECER CONEXION CON LA BASE DE DATOS", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            default:
                                MessageBox.Show("SE AGREGO CORRECTAMENTE EL PROVEEDOR", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    }
}
