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
    public partial class Ajustes_Administrativos : Form
    {
        public Ajustes_Administrativos()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Menu_Productos GP = new Menu_Productos();
            GP.Show();
            this.Hide();
        }


        private void Ajustes_Administrativos_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Inicio In = new Inicio(1);
            In.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_Proveedores GP = new Menu_Proveedores();
            GP.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu_Ventas GP = new Menu_Ventas();
            GP.Show();
            this.Hide();
        }
    }
}
