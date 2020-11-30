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
    public partial class Menu_Productos : Form
    {
        public Menu_Productos()
        {
            InitializeComponent();
        }

        private void Boton_Agregar_Click(object sender, EventArgs e)
        {
            Agregar_Productos GP = new Agregar_Productos();
            GP.Show();
            this.Hide();
        }

     


        private void Boton_Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar_Productos GP = new Eliminar_Productos();
            GP.Show();
            this.Hide();
        }

        private void Boton_Modificar_Click_1(object sender, EventArgs e)
        {
            Modifica_Productos GP = new Modifica_Productos();
            GP.Show();
            this.Hide();
        }

        private void Menu_Productos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Ajustes_Administrativos AA = new Ajustes_Administrativos();
            AA.Show();
        }
    }
}
