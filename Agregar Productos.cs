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
                int AUX_NumCod = int.Parse(Input_NumProducto.Text);
                string AUX_NomProd = Input_NomProd.Text.ToUpper();
                double AUX_Precio = double.Parse(Input_Precio.Text, System.Globalization.NumberFormatInfo.InvariantInfo);
                int AUX_NumProv = int.Parse(Input_CodigoProveedor.Text);
                bool FLAG_Guardo = false;

                if (AUX_NumCod > 0 && AUX_NomProd.Length > 0 && AUX_Precio > 0 && AUX_NumProv > 0)
                {
                    string sql = "INSERT INTO producto (numClave, nombre, precio, proveedor) VALUES ('" + AUX_NumCod + "', '" + AUX_NomProd + "','" + _ToGBString(AUX_Precio) + "','" + AUX_NumProv + "')";
                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();

                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Se ah agregado el producto correctamente.", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FLAG_Guardo = true;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error Al tratar de guardar; Puede que ya exista un registro con esta clave para producto o que no exista ningun proveedor con esa clave.", "ERROR #4:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        conexionBD.Close();
                    }


                    if (FLAG_Guardo)
                    {
                        sql = "INSERT INTO producto_inventario (numCodigo,pesoProducto) VALUES ('" + AUX_NumCod + "', ' 0')";

                        conexionBD.Open();

                        try
                        {
                            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                            comando.ExecuteNonQuery();
                            _limpiarCampos();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error Al tratar de guardar; Puede que ya exista un registro con esta clave para producto o que no exista ningun proveedor con esa clave.", "ERROR #4:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            conexionBD.Close();
                        }
                    }
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
        private string _ToGBString(double value)
        {
            return value.ToString(CultureInfo.GetCultureInfo("en-GB"));
        }
    }
}
