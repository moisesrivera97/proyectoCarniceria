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
    public partial class Modificar_Proveedor : Form
    {
        public Modificar_Proveedor()
        {
            InitializeComponent();
        }

        private void Boton_Verificar_Click(object sender, EventArgs e)
        {
            try
            {
                int BD_idProveedor = int.Parse(Input_NumProveedor.Text);
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
                            Input_NomProv.Text = SW_campos[0];
                            Input_Telefono.Text = SW_campos[1];
                            Input_Direccion.Text = SW_campos[2];
                            Input_NumProveedor.Enabled = false;
                            Input_NomProv.Enabled = true;
                            Input_Direccion.Enabled = true;
                            Input_Telefono.Enabled = true;
                            Boton_Modificar.Enabled = true;
                            Boton_Limpiar.Enabled = true;
                            Boton_Verificar.Enabled = false;
                            Input_NumProveedor.Enabled = false; 
                            break;
                    }
                    


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

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deceas modificar el proveedor \"" + Input_NomProv.Text + "\".",
                         "ADVERTENCIA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            switch (dr)
            {
                case DialogResult.Yes:

                    try
                    {
                        int BD_idProveedor = int.Parse(Input_NumProveedor.Text);
                        string BD_nombre = Input_NomProv.Text.ToUpper();
                        string BD_direccion = Input_Direccion.Text.ToUpper();
                        long BD_telefono = long.Parse(Input_Telefono.Text);

                        if (BD_idProveedor > 0 && BD_nombre.Length > 0 && BD_direccion.Length > 0 && BD_telefono > 0)
                        {
                            string urlAddress = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/Proveedor_Modificar.php";

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
                                        MessageBox.Show("FALLA EN LA SENTENCAI SQL ", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;

                                   
                                    case '9':
                                        MessageBox.Show("NO SE PUDO ESTABLECER CONEXION CON LA BASE DE DATOS", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;

                                    default:
                                        MessageBox.Show("Modificado con exito");
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

        private void Modificar_Proveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_Proveedores Mn = new Menu_Proveedores();
            Mn.Show();
        }
        private void _limpiarCampos()
        {
            Input_NumProveedor.Text = "";
            Input_NomProv.Text = "";
            Input_Telefono.Text = "";
            Input_Direccion.Text = "";

            Boton_Modificar.Enabled = false;
            Boton_Limpiar.Enabled = false;
            Boton_Verificar.Enabled = true;
            Input_NumProveedor.Enabled = true;
            Input_NomProv.Enabled = false;
            Input_Telefono.Enabled = false;
            Input_Direccion.Enabled = false;


        }
    }
}
