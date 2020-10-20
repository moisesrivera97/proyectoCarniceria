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

namespace PROYECTOIS1
{
    public partial class Eliminar_Productos : Form
    {
        public Eliminar_Productos()
        {
            InitializeComponent();
        }

        private void Eliminar_Productos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_Productos AA = new Menu_Productos();
            AA.Show();
        }

        private void Boton_Verificar_Click(object sender, EventArgs e)
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

                            Boton_Eliminar.Enabled = true;
                            Boton_Limpiar.Enabled = true;
                            Boton_Verificar.Enabled = false;
                            Input_NumProducto.Enabled = false;
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

        private void Boton_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deceas borrar el registro \""+Input_NomProd.Text+"\".",
                         "ADVERTENCIA", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
            switch (dr)
            {
                case DialogResult.Yes:
                    int AUX_NumCod = int.Parse(Input_NumProducto.Text);
                    string sql = "DELETE FROM producto_inventario WHERE numCodigo='" + AUX_NumCod + "'";

                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();

                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Se ah borrado el producto correctamente.", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();
                    }

                     sql = "DELETE FROM producto WHERE numClave='" + AUX_NumCod + "'";

                     conexionBD = Conexion.conexion();
                    conexionBD.Open();

                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        _limpiarCampos();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();
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

            Boton_Eliminar.Enabled = false;
            Boton_Limpiar.Enabled = false;
            Boton_Verificar.Enabled = true;
            Input_NumProducto.Enabled = true;
        }
    }
}
