using MySql.Data.MySqlClient;
using System;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.IO;
using iTextSharp.tool.xml;
using System.Diagnostics;

namespace PROYECTOIS1
{
    public partial class Punto_de_Venta : Form
    {
        public Punto_de_Venta()
        {
            InitializeComponent();
            Label_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
            Tabla_ProdcutosDeVenta.Columns.Add("Codigo", 100);
            Tabla_ProdcutosDeVenta.Columns.Add("Nombre del Producto", 260);
            Tabla_ProdcutosDeVenta.Columns.Add("Peso del Producto", 120);
            Tabla_ProdcutosDeVenta.Columns.Add("Precio (Kilo)", 120);
            Tabla_ProdcutosDeVenta.Columns.Add("Precio del Producto", 120);

        }
        private double SW_TotalVentasCorte = 0.0;



        private void Boton_AgregarProducto_Click(object sender, EventArgs e)
        {
            {
                string urlAddress = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/PuntoVenta_NumeroTicket.php";

                using (WebClient client = new WebClient())
                {
                    NameValueCollection postData = new NameValueCollection()
                    {
                    };

                    string SW_respuesta = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                    switch (SW_respuesta[0])
                    {
                       

                        default:
                            Label_NumTicket.Text = SW_respuesta;
                            break;
                    }
                }
            }//Obtencion del numero del ticket
            {
                try
                {

                    int BD_idProducto = int.Parse(Input_CodProducto.Text);
                    double BD_peso = double.Parse(Input_PesoProducto.Text);
                    string urlAddress = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/PuntoVenta_VerificarProducto.php";


                    using (WebClient client = new WebClient())
                    {
                        NameValueCollection postData = new NameValueCollection()
                        {
                            { "bd_fkProducto", BD_idProducto.ToString() },
                            { "bd_peso", BD_peso.ToString() }
                        };

                        string SW_respuesta = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                        switch (SW_respuesta[0])
                        {
                            case '0':
                                MessageBox.Show("NO SE ENCUENTRA NINGUN PRODUCTO CON ESTE CODIGO", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            case '8':
                                MessageBox.Show("NO SE PUEDE VENDER LA CANTIDAD DEL PRODUCTO YA QUE NO HAY TANTA CANTIDAD", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case '9':
                                MessageBox.Show("NO SE PUDO ESTABLECER CONEXION CON LA BASE DE DATOS", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            default:
                                string urlAddress2 = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/PuntoVenta_ObtenerProducto.php";

                                using (WebClient client2 = new WebClient())
                                {
                                    NameValueCollection postData2 = new NameValueCollection()
                                    {
                                        { "bd_fkProducto", BD_idProducto.ToString() },
                                    };

                                    string SW_respuesta2 = Encoding.UTF8.GetString(client2.UploadValues(urlAddress2, postData2));
                                    switch (SW_respuesta2[0])
                                    {
                                        case '0':
                                            MessageBox.Show("NO SE ENCUENTRA NINGUNA PRODUCTO CON ESE CODIGO", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            Label_NumTicket.Text = "1";
                                            break;

                                        case '9':
                                            MessageBox.Show("NO SE PUDO ESTABLECER CONEXION CON LA BASE DE DATOS", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            break;

                                        default:
                                            string[] arr = new string[5];
                                            ListViewItem itm;
                                            string[] cadena = SW_respuesta2.Split(',');

                                            arr[0] = cadena[0];
                                            arr[1] = cadena[1];
                                            arr[2] = String.Format("{0:0.000}", BD_peso);
                                            arr[3] = String.Format("{0:0.00}", double.Parse(cadena[2]));
                                            arr[4] = String.Format("{0:0.00}", (double.Parse(cadena[2]) * BD_peso));

                                            itm = new ListViewItem(arr);
                                            Tabla_ProdcutosDeVenta.Items.Add(itm);

                                            Label_TotalDinero.Text = String.Format("{0:0.00}", double.Parse(Label_TotalDinero.Text) + double.Parse(arr[3]) * BD_peso);

                                            Boton_Pagar.Enabled = true;
                                            Boton_Cancelar.Enabled = true;
                                            Boton_CancelarProducto.Enabled = true;
                                            Input_CodProducto.Text = "";
                                            Input_PesoProducto.Text = "";
                                            break;
                                    }
                                }

                                break;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Ingresaste un dato erroneo; Revisa que los datos que ingresaste sean correctos, puede que hayas escrito mal algo o que falte algun dato.", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }//Agregar Producto


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


        private void Timer_Segundero_Tick(object sender, EventArgs e)
        {
            Label_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Boton_Pagar_Click(object sender, EventArgs e)
        {

            string mensaje, titulo, valorDefecto;
            object miValor;
            string SW_totalVenta = string.Format("{0:0.00}", (double.Parse(Label_TotalDinero.Text) * 1.16));

            mensaje = "Monto a Pagar: " + String.Format("{0:0.00}", (double.Parse(Label_TotalDinero.Text)));
            titulo = "Pago";
            valorDefecto = "0.00";

            miValor = Microsoft.VisualBasic.Interaction.InputBox(mensaje, titulo, valorDefecto);
           
                double sw_DineroUsuario = double.Parse(miValor.ToString());
                if (sw_DineroUsuario >= double.Parse(Label_TotalDinero.Text))
                {

                    string urlAddress = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/PuntoVenta_GuardarVenta.php";


                    using (WebClient client = new WebClient())
                    {
                        NameValueCollection postData = new NameValueCollection()
                        {
                            { "bd_idVenta", Label_NumTicket.Text },
                            { "bd_numeroProductos", Tabla_ProdcutosDeVenta.Items.Count.ToString() },
                            { "bd_subTotal", Label_TotalDinero.Text },
                            { "bd_total", (double.Parse(Label_TotalDinero.Text)*1.16).ToString() },
                            { "bd_fecha", DateTime.Now.ToString("dd/MM/yyyy") },
                            { "bd_hora", DateTime.Now.ToString("HH:mm:ss") }
                        };

                        string SW_respuesta = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                        switch (SW_respuesta[0])
                        {
                            case '0':
                                MessageBox.Show("ERROR EN LA SENTENCIA SQL", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            case '9':
                                MessageBox.Show("NO SE PUDO ESTABLECER CONEXION CON LA BASE DE DATOS", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            default:

                                for (int i = 0; i < Tabla_ProdcutosDeVenta.Items.Count; i++)
                                {
                                    string urlAddress2 = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/PuntoVenta_GuardarProducto.php";

                                    using (WebClient client2 = new WebClient())
                                    {
                                        NameValueCollection postData2 = new NameValueCollection()
                        {
                            { "bd_fkVenta", Label_NumTicket.Text },
                            { "bd_fkProducto", Tabla_ProdcutosDeVenta.Items[i].SubItems[0].Text },
                            { "bd_peso", Tabla_ProdcutosDeVenta.Items[i].SubItems[2].Text },
                            { "bd_precioKilo", Tabla_ProdcutosDeVenta.Items[i].SubItems[3].Text },
                            { "bd_precioProducto", Tabla_ProdcutosDeVenta.Items[i].SubItems[4].Text }
                        };

                                        string SW_respuesta2 = Encoding.UTF8.GetString(client2.UploadValues(urlAddress2, postData2));
                                    }


                                }

                            string SW_cambio = String.Format("{0:0.00}", (sw_DineroUsuario - double.Parse(Label_TotalDinero.Text)));
                                MessageBox.Show("Cambio: " + SW_cambio  + "\nGracias por su compra c:");
                                SW_TotalVentasCorte += double.Parse(Label_TotalDinero.Text);
                            string direccion = "";
                            {


                                string html = "";

                                html += "<table style'border-collapse: collapse; width: 100%;' border='1'>";
                                html += "<tbody>";
                                html += "<tr>";
                                html += "<td style='width: 400 %; '>";
                                html += "< h1 style='text-align: center;'>";
                                html += " < strong> Carniceria y Obrador Nueva Mentalidad Mexicana S.A.de C.V.</ strong>";
                                html += "</ h1>";
                                html += "<  h3 style='text-align: center;'>";
                                html += "  < span style='color: #808080;'> Industria #1625, col. Las Huertas</span></h3>";
                                html += "     < p style='text-align: center;'> ***********************************************</ p>";
                                html += " < h3 style='text-align: center;'> Ticket de Venta #" + Label_NumTicket.Text + "</ h3>";
                                html += " < h3 style='text-align: left;'> Hora: " + DateTime.Now.ToString("HH:mm:ss") + "</ h3>";
                                html += " < h3 style='text-align: left;'> Fecha: " + DateTime.Now.ToString("dd/MM/yyyy") + "</ h3>";
                                html += "        < p style='text-align: center;'> ***********************************************</ p>";



                                //Adding DataRow.



                                html += "   < table style='height: 85px; width: 100%; border-collapse: collapse; border-style: none;' border='0'>";
                                html += "       < tbody>";
                                html += "<tr>";


                                html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + "DESCRIPCION" + "</th>";
                                html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + "PESO" + "</th>";
                                html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + "PRECIO KILO" + "</th>";
                                html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + "PRECIO PRODUCTO" + "</th>";

                                html += "</tr>";
                                
                                for (int i = 0; i < Tabla_ProdcutosDeVenta.Items.Count; i++)
                                {
                                    html += "<tr>";
                                    html += "<td style='width:120px;border: 1px solid #ccc'>" + Tabla_ProdcutosDeVenta.Items[i].SubItems[1].Text + "</td>";
                                    html += "<td style='width:120px;border: 1px solid #ccc'>" + Tabla_ProdcutosDeVenta.Items[i].SubItems[2].Text + "</td>";
                                    html += "<td style='width:120px;border: 1px solid #ccc'>" + Tabla_ProdcutosDeVenta.Items[i].SubItems[3].Text + "</td>";
                                    html += "<td style='width:120px;border: 1px solid #ccc'>" + Tabla_ProdcutosDeVenta.Items[i].SubItems[4].Text + "</td>";
                                    html += "</tr>";

                                }
                                



                                html += "      </ tbody>";
                                html += "  </ table>";


                                html += "  < p> &nbsp;</ p>";
                                html += "  < p style='text-align: center;'> ***********************************************</ p>";
                                html += "  < p style='text-align: left;'> SubTotal:&nbsp; " + Label_TotalDinero.Text + "</ p>";
                                html += "  < p style='text-align: left;'> Iva:&nbsp;" + "0.16" + "</ p>";
                                html += "  < h3 style='text-align: left;'> Total:&nbsp;" + SW_totalVenta + "</ h3>";
                                html += "  < p style='text-align: left;'> Efectivo:&nbsp;"+sw_DineroUsuario+"</ p>";
                                html += "  < h3 style='text-align: left;'> Cambio:&nbsp;"+SW_cambio+"</ h3>";
                                html += "  < p style='text-align: center;'> ***********************************************</ p>";
                                html += "  < p style='text-align: center;'> &nbsp;</ p>";
                                html += "  < p style='text-align: center;'> ***********************************************</ p>";
                                html += "  < p style='text-align: center;'> &nbsp;</ p>";
                                html += "  < h4 style='text-align: center;'>";
                                html += "      < strong> GRACIAS POR SU PREFERENCIA! </ strong>";
                                html += "  </ h4>";
                                html += "</td>";
                                html += "</tr>";
                                html += "</tbody>";
                                html += "</table>";



                                //Creating Folder for saving PDF.
                                string folderPath = "C:\\PDFs\\";
                                if (!Directory.Exists(folderPath))
                                {
                                    Directory.CreateDirectory(folderPath);
                                }

                                //Exporting HTML to PDF file.
                                
                                using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
                                {
                                    direccion = folderPath + "DataGridViewExport.pdf";
                                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                                    pdfDoc.Open();
                                    StringReader sr = new StringReader(html);
                                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                                    pdfDoc.Close();
                                    stream.Close();

                                }


                            }//GENERAR TICKET
                            string pdfPath = Path.Combine(Application.StartupPath, direccion);

                            Process.Start(pdfPath);
                            _LimpiarCampos();

                            break;
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Error al pagar, la cantidad que ingresaste es insuficiente.", "ERROR #11:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
          
        }



        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deceas cancelar la venta actual",
                           "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (dr)
            {
                case DialogResult.Yes:
                    int totalItems = Tabla_ProdcutosDeVenta.Items.Count;
                    for (int i = 0; i < totalItems; i++)
                    {
                        int BD_idProducto = int.Parse(Tabla_ProdcutosDeVenta.Items[0].SubItems[0].Text);
                        double BD_peso = double.Parse(Tabla_ProdcutosDeVenta.Items[0].SubItems[2].Text); ;
                        Tabla_ProdcutosDeVenta.Items.Remove(Tabla_ProdcutosDeVenta.Items[0]);
                        string urlAddress = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/PuntoVenta_CancelarProducto.php";


                        using (WebClient client = new WebClient())
                        {
                            NameValueCollection postData = new NameValueCollection()
                        {
                            { "bd_fkProducto", BD_idProducto.ToString() },
                            { "bd_peso", BD_peso.ToString() }
                        };

                            string SW_respuesta = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                            switch (SW_respuesta[0])
                            {
                                case '0':
                                    MessageBox.Show("NO SE ENCUENTRA NINGUN PRODUCTO CON ESTE CODIGO", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;

                                case '9':
                                    MessageBox.Show("NO SE PUDO ESTABLECER CONEXION CON LA BASE DE DATOS", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;

                                default:

                                    break;
                            }
                        }
                    }
                    MessageBox.Show("Venta Cancelada");
                    _LimpiarCampos();
                    break;
            }
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

            Label_NumTicket.Text = "";
        }


        private void Boton_RealizarCorte_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Quieres realizar el corte del dia?",
                           "CORTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Yes:
                    MessageBox.Show("El saldo al corte es: " + SW_TotalVentasCorte.ToString(),
                           "CORTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
            }
        }

        private void Boton_CancelarProducto_Click(object sender, EventArgs e)
        {


            int BD_idProducto = int.Parse(Tabla_ProdcutosDeVenta.SelectedItems[0].SubItems[0].Text);
            double BD_peso = double.Parse(Tabla_ProdcutosDeVenta.SelectedItems[0].SubItems[2].Text);
            Label_TotalDinero.Text = (double.Parse(Label_TotalDinero.Text) - double.Parse(Tabla_ProdcutosDeVenta.Items[0].SubItems[4].Text)).ToString();
            Label_TotalDinero.Text = String.Format("{0:0.00}", double.Parse(Label_TotalDinero.Text));
            Tabla_ProdcutosDeVenta.Items.Remove(Tabla_ProdcutosDeVenta.SelectedItems[0]);
            string urlAddress = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/PuntoVenta_CancelarProducto.php";


            using (WebClient client = new WebClient())
            {
                NameValueCollection postData = new NameValueCollection()
                        {
                            { "bd_fkProducto", BD_idProducto.ToString() },
                            { "bd_peso", BD_peso.ToString() }
                        };

                string SW_respuesta = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                switch (SW_respuesta[0])
                {
                    case '0':
                        MessageBox.Show("NO SE ENCUENTRA NINGUN PRODUCTO CON ESTE CODIGO", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case '9':
                        MessageBox.Show("NO SE PUDO ESTABLECER CONEXION CON LA BASE DE DATOS", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    default:
                        MessageBox.Show("Producto Cancelado");
                        break;
                }
            }

            if (Tabla_ProdcutosDeVenta.Items.Count == 0)
            {
                Boton_Cancelar.Enabled = false;
                Boton_Pagar.Enabled = false;
                Boton_CancelarProducto.Enabled = false;
            }
        }
    }
}
