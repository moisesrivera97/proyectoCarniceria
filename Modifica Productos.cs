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
                int AUX_NumCod = int.Parse(Input_NumProducto.Text);
                MySqlDataReader reader = null;
                string sql = "SELECT nombre, precio, proveedor FROM producto WHERE numClave LIKE '" + AUX_NumCod + "' LIMIT 1";
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Input_NomProd.Text = reader.GetString(0);
                            Input_Precio.Text = reader.GetString(1);
                            Input_CodigoProveedor.Text = reader.GetString(2);

                            Boton_Modificar.Enabled = true;
                            Boton_Limpiar.Enabled = true;
                            Boton_Verificar.Enabled = false;
                            Input_NumProducto.Enabled = false;
                            Input_NomProd.Enabled = true;
                            Input_Precio.Enabled = true;
                            Input_CodigoProveedor.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se Encontro ningun registro con este codigo.", "ERROR #5:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al buscar " + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }


            }
            catch
            {
                MessageBox.Show("Ingresaste un dato erroneo; Revisa que los datos que ingresaste sean correctos, puede que hayas escrito mal algo o que falte algun dato.", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deceas modificar el registro \"" + Input_NomProd.Text + "\".",
                        "ADVERTENCIA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Yes:
                    try
                    {
                        int AUX_NumCod = int.Parse(Input_NumProducto.Text);
                        string AUX_NomProd = Input_NomProd.Text.ToUpper();
                        double AUX_Precio = double.Parse(Input_Precio.Text, System.Globalization.NumberFormatInfo.InvariantInfo);
                        int AUX_NumProv = int.Parse(Input_CodigoProveedor.Text);

                        if (AUX_NumCod > 0 && AUX_NomProd.Length > 0 && AUX_Precio > 0 && AUX_NumProv > 0)
                        {

                            MessageBox.Show(_ToGBString(AUX_Precio));
                            string sql = "UPDATE producto SET nombre='" + AUX_NomProd + "', precio='" + _ToGBString(AUX_Precio) + "', proveedor='" + AUX_NumProv + "' WHERE numClave='" + AUX_NumCod + "'";

                            MySqlConnection conexionBD = Conexion.conexion();
                            conexionBD.Open();

                            try
                            {
                                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                                comando.ExecuteNonQuery();
                                MessageBox.Show("Se ah modificado el producto correctamente.", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                _limpiarCampos();

                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show("Error al intentar modificar el registro; Es posible que no exista el numero del proveedor que estas actualizando.", "ERROR #5:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            finally
                            {
                                conexionBD.Close();
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

        private string _ToGBString(double value)
        {
            return value.ToString(CultureInfo.GetCultureInfo("en-GB"));
        }
    }
}
