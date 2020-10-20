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
    public partial class Eliminar_Proveedor : Form
    {
        public Eliminar_Proveedor()
        {
            InitializeComponent();
        }

        private void Boton_Verificar_Click(object sender, EventArgs e)
        {
            try
            {
                int AUX_NumProv = int.Parse(Input_NumProv.Text);
                MySqlDataReader reader = null;
                string sql = "SELECT nombreProveedor, telefono, direccion FROM proveedor WHERE claveProveedor LIKE '" + AUX_NumProv + "' LIMIT 1";
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
                            Input_NomProv.Text = reader.GetString(0);
                            Input_Telefono.Text = reader.GetString(1);
                            Input_Direccion.Text = reader.GetString(2);

                            Boton_Eliminar.Enabled = true;
                            Boton_Limpiar.Enabled = true;
                            Boton_Verificar.Enabled = false;
                            Input_NumProv.Enabled = false;
                            Input_NomProv.Enabled = false;
                            Input_Telefono.Enabled = false;
                            Input_Direccion.Enabled = false;
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

        private void Boton_Limpiar_Click(object sender, EventArgs e)
        {
            _limpiarCampos();
        }

        private void Boton_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deceas borrar el proveedor \"" + Input_NomProv.Text + "\".",
                         "ADVERTENCIA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            switch (dr)
            {
                case DialogResult.Yes:
                    int AUX_NumCod = int.Parse(Input_NumProv.Text);
                    string sql = "DELETE FROM proveedor WHERE claveProveedor='" + AUX_NumCod + "'";

                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();

                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Se ah eliminado el proveedor correctamente.", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _limpiarCampos();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al tratar de eliminar; Aun existen productos que son abastecidos por este proveedor, para eliminar este proveedor primero tienes que modificar los productos relacionados con este proveedor..", "ERROR #7:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexionBD.Close();
                    }
                    break;

            }
        }

        private void Eliminar_Proveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_Proveedores AA = new Menu_Proveedores();
            AA.Show();
        }
        private void _limpiarCampos()
        {
            Input_NumProv.Text = "";
            Input_NomProv.Text = "";
            Input_Telefono.Text = "";
            Input_Direccion.Text = "";

            Boton_Eliminar.Enabled = false;
            Boton_Limpiar.Enabled = false;
            Boton_Verificar.Enabled = true;
            Input_NumProv.Enabled = true;
        }
    }
}
