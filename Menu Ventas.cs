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
    public partial class Menu_Ventas : Form
    {
        public Menu_Ventas()
        {
            InitializeComponent();
            Tabla_ProdcutosDeVenta.Columns.Add("Codigo", 100);
            Tabla_ProdcutosDeVenta.Columns.Add("Nombre del Producto", 260);
            Tabla_ProdcutosDeVenta.Columns.Add("Peso del Producto", 120);
            Tabla_ProdcutosDeVenta.Columns.Add("Precio (Kilo)", 120);
            Tabla_ProdcutosDeVenta.Columns.Add("Precio del Producto", 120);
        }

        private void Menu_Ventas_Load(object sender, EventArgs e)
        {

        }

        private void Boton_Buscar_Click(object sender, EventArgs e)
        {
           
        }

       

    }
}
