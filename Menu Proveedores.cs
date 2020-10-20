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
    public partial class Menu_Proveedores : Form
    {
        public Menu_Proveedores()
        {
            InitializeComponent();
        }

        private void Boton_Agregar_Click(object sender, EventArgs e)
        {
            Agregar_Proveedor GP = new Agregar_Proveedor();
            GP.Show();
            this.Hide();
        }


        private void Boton_Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar_Proveedor GP = new Eliminar_Proveedor();
            GP.Show();
            this.Hide();
        }

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            Modificar_Proveedor GP = new Modificar_Proveedor();
            GP.Show();
            this.Hide();
        }

        private void Menu_Proveedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            Ajustes_Administrativos AA = new Ajustes_Administrativos();
            AA.Show();
        }
    }
}
