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
    public partial class Sistema_de_Inventariado : Form
    {
        public Sistema_de_Inventariado(int SW_TipoUsuario)
        {
            InitializeComponent();
            this.SW_TipoUsuario = SW_TipoUsuario;
        }

        readonly int SW_TipoUsuario;
        readonly int CON_TipoAdministrador = 1;
        readonly int CON_TipoInventario = 3;

     

        private void Sistema_de_Inventariado_FormClosed(object sender, FormClosedEventArgs e)
        {
            {
                Inicio In = new Inicio(SW_TipoUsuario);
                In.Show();
            }
        }

        private void Boton_ActualizarInventario_Click(object sender, EventArgs e)
        {
            if (SW_TipoUsuario == CON_TipoInventario)
            {
                Actualizar_Inventario AI = new Actualizar_Inventario();
                AI.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El tipo de Usuario NO tiene autorizacion para realizar esta accion.", "ERROR #2:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void _ActualizarTabla()
        {/*
            Tabla_Productos.Clear();
            MySqlDataReader reader = null;
            string sql = "SELECT * FROM producto t1 INNER JOIN producto_inventario t2 ON t1.numClave = t2.numCodigo INNER JOIN proveedor t3  ON t1.proveedor = t3.claveProveedor";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                Tabla_Productos.Columns.Add("Codigo Del Producto", 110);
                Tabla_Productos.Columns.Add("Nombre ", 240);
                Tabla_Productos.Columns.Add("Kilos Actuales", 120);
                Tabla_Productos.Columns.Add("Precio Actual", 120);
                Tabla_Productos.Columns.Add("Proveedor", 160);
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] arr = new string[5];
                        ListViewItem itm;

                        arr[0] = reader.GetString(0);
                        arr[1] = reader.GetString(1);
                        arr[2] = reader.GetString(5);
                        arr[3] = reader.GetString(2);
                        arr[4] = reader.GetString(7);

                        itm = new ListViewItem(arr);
                        Tabla_Productos.Items.Add(itm);

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }*/
        }

        private void Sistema_de_Inventariado_Load(object sender, EventArgs e)
        {
            _ActualizarTabla();
        }

        private void Tabla_Productos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
