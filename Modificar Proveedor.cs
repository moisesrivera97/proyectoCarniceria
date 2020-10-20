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
                int AUX_NumProv = int.Parse(Input_NumProveedor.Text);
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

                            Boton_Modificar.Enabled = true;
                            Boton_Limpiar.Enabled = true;
                            Boton_Verificar.Enabled = false;
                            Input_NumProveedor.Enabled = false;
                            Input_NomProv.Enabled = true;
                            Input_Telefono.Enabled = true;
                            Input_Direccion.Enabled = true;
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

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deceas modificar el registro \"" + Input_NomProv.Text + "\".",
                        "ADVERTENCIA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Yes:
                    try
                    {
                        int AUX_NumCod = int.Parse(Input_NumProveedor.Text);
                        string AUX_NomProv = Input_NomProv.Text.ToUpper();
                        string AUX_Direccion = Input_Direccion.Text.ToUpper();
                        string AUX_Telefono = Input_Telefono.Text.ToUpper();
                        long AUX_Telefono2 = long.Parse(Input_Telefono.Text);

                        if (AUX_NumCod > 0 && AUX_NomProv.Length > 0 && AUX_Direccion.Length > 0 && AUX_Telefono.Length > 0)
                        {


                            string sql = "UPDATE proveedor SET nombreProveedor='" + AUX_NomProv + "', telefono='" + AUX_Telefono + "', direccion='" + AUX_Direccion + "' WHERE claveProveedor='" + AUX_NumCod + "'";

                            MySqlConnection conexionBD = Conexion.conexion();
                            conexionBD.Open();

                            try
                            {
                                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                                comando.ExecuteNonQuery();
                                MessageBox.Show("Se ah modificado el proveedor correctamente.", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
