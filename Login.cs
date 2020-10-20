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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Input_Usuario.Text == "admin" && Input_Contraseña.Text == "admin")
            {
                Inicio In = new Inicio(1);
                In.Show();
                this.Close();
            }
            else if (Input_Usuario.Text == "cajero" && Input_Contraseña.Text == "cajero")
            {
                Inicio In = new Inicio(2);
                In.Show();
                this.Close();
            }
            else if (Input_Usuario.Text == "inventariado" && Input_Contraseña.Text == "inventariado")
            {
                Inicio In = new Inicio(3);
                In.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta.", "ERROR #1:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
