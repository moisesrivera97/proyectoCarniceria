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
    public partial class Actualizar_Inventario : Form
    {
        public Actualizar_Inventario()
        {
            InitializeComponent();
        }


      

        private void Boton_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int AUX_NumCod = int.Parse(Input_NumProd.Text);
                double AUX_CantidadPeso = double.Parse(Input_CantidadKg.Text, System.Globalization.NumberFormatInfo.InvariantInfo);
                double VAR_PesoAntesDeModificar = 0.00;

                if (Input_NumProd.Text.Length>0 && Input_CantidadKg.Text.Length > 0)
                {
                    
                    string sql = "SELECT pesoProducto FROM producto_inventario WHERE numCodigo LIKE '" + AUX_NumCod + "' LIMIT 1";
                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();

                    try
                    {
                        MySqlDataReader reader = null;
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        reader = comando.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                VAR_PesoAntesDeModificar= double.Parse(reader.GetString(0));
                                
                            }
                            if ((VAR_PesoAntesDeModificar + AUX_CantidadPeso) >= 0)
                            {
                                VAR_PesoAntesDeModificar = (VAR_PesoAntesDeModificar + AUX_CantidadPeso);

                                sql = "UPDATE producto_Inventario SET pesoProducto='" + ToGBString(VAR_PesoAntesDeModificar) + "' WHERE numCodigo='" + AUX_NumCod + "'";

                                conexionBD = Conexion.conexion();
                                conexionBD.Open();

                                try
                                {
                                     comando = new MySqlCommand(sql, conexionBD);
                                    comando.ExecuteNonQuery();
                                    MessageBox.Show("Se ah Actualizado Correctamente El producto","Actualizacion Exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                    _limpiarCampos();

                                }
                                catch (MySqlException ex)
                                {
                                    MessageBox.Show("ERROR: "+ ex, "ERROR #5:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                                finally
                                {
                                    conexionBD.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error al tratar de actualizar el inventario; El producto quedara en existencia negativa, revisa que este correcto el dato que ingresaste.", "ERROR #8:", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void Actualizar_Inventario_Load_1(object sender, EventArgs e)
        {

        }
        private void _limpiarCampos()
        {
            Input_CantidadKg.Text = "";
            Input_NumProd.Text = "";
           
        }

        private string ToGBString(double value)
        {
            return value.ToString(CultureInfo.GetCultureInfo("en-GB"));
        }

        private void Actualizar_Inventario_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Sistema_de_Inventariado AA = new Sistema_de_Inventariado(3);
            AA.Show();
        }


    }
}
