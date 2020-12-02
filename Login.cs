using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOIS1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(127, 12, 7);
        }
        private void ButtonIngresar_Click(object sender, EventArgs e)
        {
            string BD_idEmpleado = textBoxRoundedUser.Text;
            string BD_contrasena = textBoxRoundedPass.Text;

            string urlAddress = "https://ismaelzepedaudg.000webhostapp.com/Proyecto_Carniceria/Empleado_Verificar.php";

            using (WebClient client = new WebClient())
            {
                NameValueCollection postData = new NameValueCollection()
                    {
                          { "bd_idEmpleado", BD_idEmpleado},
                          { "bd_contrasena", BD_contrasena}
                   };
                string SW_respuesta = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                switch (SW_respuesta[0])
                {
                    case '0':
                        MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxRoundedUser.Text = "";
                        textBoxRoundedPass.Text = "";
                        break;

                    case '9':
                        MessageBox.Show("NO SE PUDO ESTABLECER CONEXION CON LA BASE DE DATOS", "ERROR #3:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxRoundedUser.Text = "";
                        textBoxRoundedPass.Text = "";
                        break;

                    default:
                        char SW_delimitador = ',';
                        string[] SW_campos = SW_respuesta.Split(SW_delimitador);
                        string SW_nombre = SW_campos[0];
                        int SW_tipo = int.Parse(SW_campos[1]);

                        //TIPOS: 1:Admin 2:Cajero  3:Inventariado
                        //cuentas default: usuario: 100             contraseña: nombre1         tipo: Admin
                        //cuentas default: usuario: 101             contraseña: nombre2         tipo: Cajero
                        //cuentas default: usuario: 102             contraseña: nombre3         tipo: Inventariado
                        MessageBox.Show("Nombre: " + SW_nombre + "\nTipo De Usuario: " + SW_tipo);
                        Inicio In = new Inicio(SW_tipo);
                        In.Show();
                        this.Close();
                        break;

                }


            }
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
