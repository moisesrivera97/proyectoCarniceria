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
    public partial class Agregar_Proveedor : Form
    {
        public Agregar_Proveedor()
        {
            InitializeComponent();
        }

        private void Boton_Verificar_Click(object sender, EventArgs e)
        {
            try
            {
                int AUX_NumCod = int.Parse(Input_NumProv.Text);
                string AUX_NomProv = Input_NomProv.Text.ToUpper();
                string AUX_Direccion = Input_Direccion.Text.ToUpper();
                string AUX_Telefono = Input_Telefono.Text.ToUpper();
                long AUX_Telefono2 = long.Parse(Input_Telefono.Text);

                if (AUX_NumCod > 0 && AUX_NomProv.Length > 0 && AUX_Direccion.Length > 0 && AUX_Telefono.Length > 0)
                {
                    string sql = "INSERT INTO proveedor (claveProveedor, nombreProveedor, telefono, direccion) VALUES ('" + AUX_NumCod + "', '" + AUX_NomProv + "','" + AUX_Telefono + "','" + AUX_Direccion + "')";
                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();

                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Se ah agregado el proveedor correctamente.", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _limpiarCampos();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error Al tratar de guardar; Puede que ya exista un registro con esta clave para el proveedor.", "ERROR #6:", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        }

        private void Agregar_Proveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_Proveedores Mn = new Menu_Proveedores();
            Mn.Show();
        }

        private void _limpiarCampos()
        {
            Input_NumProv.Text = "";
            Input_NomProv.Text = "";
            Input_Telefono.Text = "";
            Input_Direccion.Text = "";


        }
    }
}
