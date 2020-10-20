using MySql.Data.MySqlClient;
using System;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Windows.Forms;

namespace PROYECTOIS1
{
    public partial class Punto_de_Venta : Form
    {
        public Punto_de_Venta()
        {
            InitializeComponent();

            Tabla_ProdcutosDeVenta.Columns.Add("Codigo", 100);
            Tabla_ProdcutosDeVenta.Columns.Add("Nombre del Producto", 260);
            Tabla_ProdcutosDeVenta.Columns.Add("Peso del Producto", 120);
            Tabla_ProdcutosDeVenta.Columns.Add("Precio (Kilo)", 120);
            Tabla_ProdcutosDeVenta.Columns.Add("Precio del Producto", 120);
        }
        bool FLAG_PrimerProducto = true;
        double SW_TotalVentasCorte = 0.0;
        bool FLAG_PoderPagar = true;
        int SW_NumVenta = 0;

        private void Boton_AgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                int AUX_NumCod = int.Parse(Input_CodProducto.Text);
                double AUX_Peso = double.Parse(Input_PesoProducto.Text, System.Globalization.NumberFormatInfo.InvariantInfo);

                if (AUX_Peso > 0)
                {
                    string AUX_STR_Peso = _ToGBString(AUX_Peso);
                    bool FLAG_ExisteRegistro = false;
                    bool FLAG_PesoCorrecto = false;



                    int OB_Producto_Clave = AUX_NumCod;
                    string OB_Producto_Nombre = "";
                    double OB_Producto_Peso = AUX_Peso;
                    double OB_Producto_PrecioKilo = 0.0;

                    double AUX_PesoInventario;



                    MySqlDataReader reader = null;
                    string sql = "SELECT nombre, precio FROM producto WHERE numClave LIKE '" + AUX_NumCod + "' LIMIT 1";
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
                                OB_Producto_Nombre = reader.GetString(0);
                                OB_Producto_PrecioKilo = double.Parse(reader.GetString(1));
                                FLAG_ExisteRegistro = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se Encontro ningun registro con este codigo.", "ERROR #5:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        if (FLAG_ExisteRegistro)
                        {
                            sql = "SELECT pesoProducto FROM producto_inventario WHERE numCodigo LIKE '" + AUX_NumCod + "' LIMIT 1";
                            conexionBD = Conexion.conexion();
                            conexionBD.Open();

                            try
                            {
                                comando = new MySqlCommand(sql, conexionBD);
                                reader = comando.ExecuteReader();
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        AUX_PesoInventario = double.Parse(reader.GetString(0));
                                        if (AUX_PesoInventario >= OB_Producto_Peso)
                                        {
                                            FLAG_PesoCorrecto = true;
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("; No existe esa cantidad de producto para vender.", "ERROR #9:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }

                                if (FLAG_PesoCorrecto)
                                {
                                    string[] arr = new string[5];
                                    ListViewItem itm;

                                    arr[0] = OB_Producto_Clave.ToString();
                                    arr[1] = OB_Producto_Nombre;

                                    arr[2] = String.Format("{0:0.000}", OB_Producto_Peso);
                                    arr[3] = String.Format("{0:0.00}", OB_Producto_PrecioKilo);
                                    arr[4] = String.Format("{0:0.00}", OB_Producto_PrecioKilo * OB_Producto_Peso);

                                    itm = new ListViewItem(arr);
                                    Tabla_ProdcutosDeVenta.Items.Add(itm);

                                    Label_TotalDinero.Text = String.Format("{0:0.00}", double.Parse(Label_TotalDinero.Text) + (OB_Producto_PrecioKilo * OB_Producto_Peso));

                                    Boton_Pagar.Enabled = true;
                                    Boton_Cancelar.Enabled = true;
                                    if (FLAG_PrimerProducto)
                                    {
                                        Label_NumTicket.Text = _determinarNumTicket().ToString();
                                        SW_NumVenta = _determinarNumTicket();
                                        FLAG_PrimerProducto = false;
                                    }


                                }
                                else
                                {
                                    MessageBox.Show("Error al tratar de registrar un producto a la venta; No existe esa cantidad de producto para vender.", "ERROR #9:", MessageBoxButtons.OK, MessageBoxIcon.Error);

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






        private void Punto_de_Venta_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Inicio In = new Inicio(2);
            In.Show();
        }

        private void Input_CodProducto_KeyPress_1(object sender, KeyPressEventArgs e)

        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void Input_PesoProducto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar) || e.KeyChar == '.') //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
        private string _ToGBString(double value)
        {
            return value.ToString(CultureInfo.GetCultureInfo("en-GB"));
        }

        private void Timer_Segundero_Tick(object sender, EventArgs e)
        {
            Label_Hora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void Boton_Pagar_Click(object sender, EventArgs e)
        {


            double FUN_TotalAPagar = double.Parse(Label_TotalDinero.Text);
            //MessageBox.Show(_ToGBString(FUN_TotalAPagar));
            int OB_Producto_Codigo = 0;
            double OB_Producto_Peso = 0.0;
            double OB_Producto_Precio = 0.0;
            int i = 0;

            bool FLAG_GuardoVenta = false;


            string mensaje, titulo, valorDefecto;
            object miValor;

            mensaje = "Monto a Pagar: "+ String.Format("{0:0.00}", (FUN_TotalAPagar));
            titulo = "Pago";
            valorDefecto = "0.00";

            miValor= Microsoft.VisualBasic.Interaction.InputBox(mensaje, titulo, valorDefecto);
            try
            {
                double sw_DineroUsuario = double.Parse(miValor.ToString());
                if (sw_DineroUsuario >= FUN_TotalAPagar)
                {
                    for (i = 0; i < Tabla_ProdcutosDeVenta.Items.Count; i++)
                    {
                        OB_Producto_Codigo = int.Parse(Tabla_ProdcutosDeVenta.Items[i].SubItems[0].Text);
                        OB_Producto_Peso = double.Parse(Tabla_ProdcutosDeVenta.Items[i].SubItems[2].Text) * -1.0;
                       

                        double VAR_PesoAntesDeModificar = 0.0;

                        string sql = "SELECT pesoProducto FROM producto_inventario WHERE numCodigo LIKE '" + OB_Producto_Codigo + "' LIMIT 1";
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
                                    VAR_PesoAntesDeModificar = double.Parse(reader.GetString(0));

                                }
                                if ((VAR_PesoAntesDeModificar + OB_Producto_Peso) >= 0)
                                {
                                    VAR_PesoAntesDeModificar = (VAR_PesoAntesDeModificar + OB_Producto_Peso);

                                    sql = "UPDATE producto_Inventario SET pesoProducto='" + _ToGBString(VAR_PesoAntesDeModificar) + "' WHERE numCodigo='" + OB_Producto_Codigo + "'";

                                    conexionBD = Conexion.conexion();
                                    conexionBD.Open();

                                    try
                                    {
                                        comando = new MySqlCommand(sql, conexionBD);
                                        comando.ExecuteNonQuery();


                                    }
                                    catch (MySqlException ex)
                                    {
                                    }
                                    finally
                                    {
                                        conexionBD.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error al tratar de realizar la venta; Algun producto quedara en existencia negativa por lo que no se puede vender esa cantidad.", "ERROR #10:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    FLAG_PoderPagar = false;
                                    break;
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

                    if (FLAG_PoderPagar)
                    {
                        for (i = 0; i < Tabla_ProdcutosDeVenta.Items.Count; i++)
                        {
                            OB_Producto_Codigo = int.Parse(Tabla_ProdcutosDeVenta.Items[i].SubItems[0].Text);
                            OB_Producto_Peso = double.Parse(Tabla_ProdcutosDeVenta.Items[i].SubItems[2].Text);
                            OB_Producto_Precio = double.Parse(Tabla_ProdcutosDeVenta.Items[i].SubItems[4].Text);
                            string sql = "INSERT INTO venta (numVenta, totalVenta, idProducto, peso) VALUES ('" + SW_NumVenta + "', '" + _ToGBString(OB_Producto_Precio) + "','" + OB_Producto_Codigo + "','" + _ToGBString(OB_Producto_Peso) + "')";
                            MySqlConnection conexionBD = Conexion.conexion();
                            conexionBD.Open();

                            try
                            {
                                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                                comando.ExecuteNonQuery();
                                FLAG_GuardoVenta = true;


                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show("Error Al tratar de guardar; .", "ERROR #X:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            finally
                            {
                                conexionBD.Close();


                            }
                        }
                        if (FLAG_GuardoVenta)
                        {
                            MessageBox.Show("Cambio: "+ String.Format("{0:0.00}", (sw_DineroUsuario - FUN_TotalAPagar)) + "\nGracias por su compra c:");
                            SW_TotalVentasCorte += double.Parse(Label_TotalDinero.Text);
                            _LimpiarCampos();
                        }
                    }
                    else
                    {
                        int SW_NumTermino = i;
                        Boton_AgregarProducto.Enabled = false;
                        Boton_Pagar.Enabled = false;
                        Boton_RealizarCorte.Enabled = false;

                        Input_CodProducto.Text = "";
                        Input_CodProducto.Enabled = false;
                        Input_PesoProducto.Text = "";
                        Input_PesoProducto.Enabled = false;

                        for (i = 0; i < SW_NumTermino; i++)
                        {
                            OB_Producto_Codigo = int.Parse(Tabla_ProdcutosDeVenta.Items[i].SubItems[0].Text);
                            OB_Producto_Peso = double.Parse(Tabla_ProdcutosDeVenta.Items[i].SubItems[2].Text);
                            //MessageBox.Show(_ToGBString( OB_Producto_Peso));

                            double VAR_PesoAntesDeModificar = 0.0;

                            string sql = "SELECT pesoProducto FROM producto_inventario WHERE numCodigo LIKE '" + OB_Producto_Codigo + "' LIMIT 1";
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
                                        VAR_PesoAntesDeModificar = double.Parse(reader.GetString(0));

                                    }
                                    if ((VAR_PesoAntesDeModificar + OB_Producto_Peso) >= 0)
                                    {
                                        VAR_PesoAntesDeModificar = (VAR_PesoAntesDeModificar + OB_Producto_Peso);

                                        sql = "UPDATE producto_Inventario SET pesoProducto='" + _ToGBString(VAR_PesoAntesDeModificar) + "' WHERE numCodigo='" + OB_Producto_Codigo + "'";

                                        conexionBD = Conexion.conexion();
                                        conexionBD.Open();

                                        try
                                        {
                                            comando = new MySqlCommand(sql, conexionBD);
                                            comando.ExecuteNonQuery();
                                        }
                                        catch (MySqlException ex)
                                        {
                                        }
                                        finally
                                        {
                                            conexionBD.Close();
                                        }
                                    }
                                    else
                                    {
                                        break;
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
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Error al pagar, la cantidad que ingresaste es insuficiente.", "ERROR #11:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            catch
            {
                MessageBox.Show("Ingresaste un dato erroneo; Revisa que los datos que ingresaste sean correctos, puede que hayas escrito mal algo o que falte algun dato.", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deceas cancelar la venta actual",
                           "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (dr)
            {
                case DialogResult.Yes:
                    _LimpiarCampos();
                    break;
            }
        }

        private void Label_NumTicket_Click(object sender, EventArgs e)
        {

        }

        private int _determinarNumTicket()
        {
            int FUN_numticket = 0;
            MySqlDataReader reader = null;
            string sql = "SELECT numVenta FROM venta ORDER BY numVenta DESC LIMIT 1";
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
                        FUN_numticket = int.Parse(reader.GetString(0)) + 1;

                    }
                }
                else
                {
                    FUN_numticket = 1;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al obtener numero de venta " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

            return FUN_numticket;
        }

        private void Input_PesoProducto_TextChanged(object sender, EventArgs e)
        {

        }
        private void _LimpiarCampos()
        {
            Tabla_ProdcutosDeVenta.Clear();
            Tabla_ProdcutosDeVenta.Columns.Add("Codigo", 100);
            Tabla_ProdcutosDeVenta.Columns.Add("Nombre del Producto", 260);
            Tabla_ProdcutosDeVenta.Columns.Add("Peso del Producto", 120);
            Tabla_ProdcutosDeVenta.Columns.Add("Precio (Kilo)", 120);
            Tabla_ProdcutosDeVenta.Columns.Add("Precio del Producto", 120);
            Label_TotalDinero.Text = "0.00";
            Boton_Pagar.Enabled = false;
            Boton_Cancelar.Enabled = false;
            Boton_RealizarCorte.Enabled = true;

            Input_CodProducto.Enabled = true;
            Input_CodProducto.Text = "";
            Input_PesoProducto.Enabled = true;
            Input_PesoProducto.Text = "";

            FLAG_PrimerProducto = true;
            FLAG_PoderPagar = true;
            Label_NumTicket.Text = "";
        }

        private void Boton_RealizarCorte_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Quieres realizar el corte del dia?",
                           "CORTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Yes:
                    MessageBox.Show("El saldo al corte es: "+SW_TotalVentasCorte.ToString(),
                           "CORTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
            }
        }

        private void Tabla_ProdcutosDeVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
