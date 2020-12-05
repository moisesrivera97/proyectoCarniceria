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
    public partial class Actualizar_Inventario : Form
    {
        public Actualizar_Inventario()
        {
            InitializeComponent();
        }
        private void _limpiarCampos()
        {
            textBoxKilos.Text = "";
            textBoxNumeroProducto.Text = "";
        }
        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            {
                string urlAddress = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/Inventario_Actualizar.php";

                using (WebClient client = new WebClient())
                {
                    NameValueCollection postData = new NameValueCollection()
                    {
                          { "bd_fkProducto", textBoxNumeroProducto.Text},
                          { "bd_peso", textBoxKilos.Text}
                   };
                    string SW_respuesta = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                    switch (SW_respuesta[0])
                    {
                        case '0':
                            MessageBox.Show("NO EXISTE NINGUN PRODUCTO CON EL CODIGO: " + textBoxNumeroProducto.Text, "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxNumeroProducto.Text = "";
                            break;
                        case '8':
                            MessageBox.Show("No se tiene tanta cantidad de este producto como para quitar la cantidad que ingresaste.", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;

                        case '9':
                            MessageBox.Show("NO SE PUDO ESTABLECER CONEXION CON LA BASE DE DATOS", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        default:
                            MessageBox.Show("Correcto");

                            break;
                    }
                    _limpiarCampos();

                }
            }//ACTUALIZACION DE PRODUCTO
        }
    }
}
