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
    public partial class Sistema_de_Inventariado : Form
    {
        public Sistema_de_Inventariado(int SW_TipoUsuario)
        {
            InitializeComponent();
            this.SW_TipoUsuario = SW_TipoUsuario;
            _ActualizarTabla();
        }

        readonly int SW_TipoUsuario;
        readonly int CON_TipoInventario = 3;
        private void _ActualizarTabla()
        {
            try
            {
                Tabla_Productos.Clear();
                Tabla_Productos.Columns.Add("Codigo Del Producto", 110);
                Tabla_Productos.Columns.Add("Nombre ", 240);
                Tabla_Productos.Columns.Add("Kilos Actuales", 120);
                Tabla_Productos.Columns.Add("Precio Actual", 120);
                Tabla_Productos.Columns.Add("Proveedor", 160);
                {
                    string urlAddress = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/Inventario_ObtenerDatos.php";

                    using (WebClient client = new WebClient())
                    {
                        NameValueCollection postData = new NameValueCollection()
                        {
                        };
                        string SW_respuesta = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                        string[] arreglo = SW_respuesta.Split('|');


                        for (int i = 0; i < arreglo.Length; i++)
                        {

                            string[] arr = arreglo[i].Split(',');
                            ListViewItem itm;
                           
                            arr[2] = String.Format("{0:0.000}", double.Parse(arr[2]));
                            arr[3] = String.Format("{0:0.00}", double.Parse(arr[3]));
                            itm = new ListViewItem(arr);
                            Tabla_Productos.Items.Add(itm);

                        }
                    }
                }//CARGAR DATOS A LA TABLA}
            }
            catch { 
            }
        }
        private void Segundero_Tick(object sender, EventArgs e)
        {
            _ActualizarTabla();
        }

        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            if (SW_TipoUsuario == CON_TipoInventario)
            {
                Actualizar_Inventario AI = new Actualizar_Inventario();
                AI.Show();
            }
            else
            {
                MessageBox.Show("El tipo de Usuario NO tiene autorizacion para realizar esta accion.", "ERROR #2:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
