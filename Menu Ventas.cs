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
    public partial class Menu_Ventas : Form
    {
        public Menu_Ventas()
        {
            InitializeComponent();
            Tabla_ProdcutosDeVenta.Columns.Add("Codigo", 100);
            Tabla_ProdcutosDeVenta.Columns.Add("Nombre del Producto", 260);
            Tabla_ProdcutosDeVenta.Columns.Add("Peso del Producto", 120);
            Tabla_ProdcutosDeVenta.Columns.Add("Precio (Kilo)", 120);
            Tabla_ProdcutosDeVenta.Columns.Add("Precio del Producto", 120);
        }
        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            int SW_numeroVenta = int.Parse(textBoxNumeroVenta.Text);

            string urlAddress = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/Venta_Buscar.php";

            using (WebClient client = new WebClient())
            {
                NameValueCollection postData = new NameValueCollection()
                    {

                            { "bd_fkVenta", SW_numeroVenta.ToString() },
                    };

                string SW_respuesta = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                switch (SW_respuesta[0])
                {
                    case '0':
                        MessageBox.Show("NO SE ENCUENTRA NINGUNA VENTA CON ESTE CODIGO", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case '9':
                        MessageBox.Show("NO SE PUDO ESTABLECER CONEXION CON LA BASE DE DATOS", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    default:
                        double venta = 0;
                        string[] arreglo = SW_respuesta.Split('|');


                        for (int i = 0; i < arreglo.Length - 1; i++)
                        {

                            string[] arr = arreglo[i].Split(',');
                            ListViewItem itm;

                            itm = new ListViewItem(arr);
                            Tabla_ProdcutosDeVenta.Items.Add(itm);
                            venta += double.Parse(arr[4]);


                        }
                        Label_TotalDinero.Text = venta.ToString();
                        break;
                }
            }
        }
    }
}
