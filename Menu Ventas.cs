using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
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

        private void Menu_Ventas_Load(object sender, EventArgs e)
        {

        }

        private void Boton_Buscar_Click(object sender, EventArgs e)
        {
            int FUN_NumVenta = 0;
            try
            {
                FUN_NumVenta = int.Parse(Input_NumeroVenta.Text);
                if (FUN_NumVenta > 0)
                {
                    Label_TotalDinero.Text= String.Format("{0:0.00}", _ActualizarTabla(FUN_NumVenta).ToString());
                }
                else
                {
                    MessageBox.Show("Ingresaste un dato erroneo; Revisa que los datos que ingresaste sean correctos, puede que hayas escrito mal algo o que falte algun dato.", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch
            {
                MessageBox.Show("Ingresaste un dato erroneo; Revisa que los datos que ingresaste sean correctos, puede que hayas escrito mal algo o que falte algun dato.", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private double _ActualizarTabla(int FUN_NumVenta)
        {
            double FUN_TotalVenta = 0.0;
            try
            {
                
                MySqlDataReader reader = null;
                string sql = "Select venta.numVenta,venta.idProducto,producto.nombre,venta.peso,producto.precio,venta.totalVenta from producto join venta on producto.numClave= venta.idProducto where venta.numVenta= \'" + FUN_NumVenta + "\' order by venta.numVenta asc";
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                try
                {
                    Tabla_ProdcutosDeVenta.Clear();
                    Tabla_ProdcutosDeVenta.Columns.Add("Codigo", 100);
                    Tabla_ProdcutosDeVenta.Columns.Add("Nombre del Producto", 260);
                    Tabla_ProdcutosDeVenta.Columns.Add("Peso del Producto", 120);
                    Tabla_ProdcutosDeVenta.Columns.Add("Precio (Kilo)", 120);
                    Tabla_ProdcutosDeVenta.Columns.Add("Precio del Producto", 120);

                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string[] arr = new string[5];
                            ListViewItem itm;

                            arr[0] = reader.GetString(1);
                            arr[1] = reader.GetString(2);
                            arr[2] = reader.GetString(3);
                            arr[3] = reader.GetString(4);
                            arr[4] = reader.GetString(5);
                            FUN_TotalVenta += double.Parse(reader.GetString(5));


                            itm = new ListViewItem(arr);
                            Tabla_ProdcutosDeVenta.Items.Add(itm);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al buscar la venta, el numero de venta no existe.", "ERROR #11:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al buscar la venta, el numero de venta no existe.", "ERROR #11:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    conexionBD.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error al buscar la venta, el numero de venta no existe.", "ERROR #11:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return FUN_TotalVenta;

        }
        private string _ToGBString(double value)
        {
            return value.ToString(CultureInfo.GetCultureInfo("en-GB"));
        }

    }
}
