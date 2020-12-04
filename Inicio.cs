﻿using System;
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
    public partial class Inicio : Form
    {
        public Inicio(int SW_TipoDeUsuario)
        {

            InitializeComponent();
            this.SW_TipoDeUsuario = SW_TipoDeUsuario;
            disenioInicial(SW_TipoDeUsuario);            

            //Animaciones de de transición de los botones del menú de ajustes
            buttonAjustesVentas.MouseEnter += OnMouseEnterbuttonAjustesVentas;
            buttonAjustesVentas.MouseLeave += OnMouseLeavebuttonAjustesVentas;

            buttonAjustesProveedores.MouseEnter += OnMouseEnterbuttonAjustesProveedores;
            buttonAjustesProveedores.MouseLeave += OnMouseLeavebuttonAjustesProveedores;

            buttonAjustesProductos.MouseEnter += OnMouseEnterbuttonAjustesProductos;
            buttonAjustesProductos.MouseLeave += OnMouseLeavebuttonAjustesProductos;

            if (SW_TipoDeUsuario == CON_TipoAdministrador)
            {

                Label_NombreDelUsuario.Text = "Juanito Banana";
                Label_Area.Text = "Oficina";
                Label_Puesto.Text = "Administrador";
            }
            else if (SW_TipoDeUsuario == CON_TipoCajero)
            {
                Label_NombreDelUsuario.Text = "Patricia Rodriguez";
                Label_Area.Text = "Carniceria";
                Label_Puesto.Text = "Cajero";
            }
            else
            {
                Label_NombreDelUsuario.Text = "Victor Pacheco";
                Label_Area.Text = "Obrador";
                Label_Puesto.Text = "Inventariado";
            }
        }

        readonly int SW_TipoDeUsuario;
        readonly int CON_TipoAdministrador = 1;
        readonly int CON_TipoInventario = 3;
        readonly int CON_TipoCajero = 2;

        #region Funciones exlusivas del diseño de la Interfaz (Para definir colores, botones activos, inactivos etc.)

        // Función que carga las opciones iniciales de la applicación (botones activos)
        private void disenioInicial(int usuario)
        {
            panelSubMenuProductos.Visible = false;
            panelSubMenuProveedores.Visible = false;
            if(usuario == CON_TipoCajero)
            {
                buttonVentas.ButtonColor = Color.FromArgb(255,255,255);
                buttonVentas.TextColor = Color.FromArgb(0,0,0);

                panelSuperiorAjustes.Visible = false;
                panelSuperiorInventario.Visible = false;

                abrirPanelEventos(new Punto_de_Venta());
            }
            else if(usuario == CON_TipoInventario)
            {
                buttonInventario.ButtonColor = Color.FromArgb(255,255,255);
                buttonInventario.TextColor = Color.FromArgb(0,0,0);

                panelSuperiorAjustes.Visible = false;
                panelSuperiorVentas.Visible = false;

                abrirPanelEventos(new Sistema_de_Inventariado(SW_TipoDeUsuario));
            }
            else if(usuario == CON_TipoAdministrador)
            {
                buttonAjustes.ButtonColor = Color.FromArgb(255,255,255);
                buttonAjustes.TextColor = Color.FromArgb(0,0,0);

                panelSuperiorInventario.Visible = false;
                panelSuperiorVentas.Visible = false;

                panelSubMenuProductos.Visible = true;
            }
        }
        // Función que oculta los páneles del menú superior
        private void ocultarSubMenus()
        {
            if(panelSuperiorAjustes.Visible == true)
            {
                panelSuperiorAjustes.Visible = false;
            }
            if (panelSuperiorInventario.Visible == true)
            {
                panelSuperiorInventario.Visible = false;
            }
            if (panelSuperiorVentas.Visible == true)
            {
                panelSuperiorVentas.Visible = false;
            }
        }
        private void ocultarOpcionesSubMenus()
        {
            if(panelSubMenuProductos.Visible == true)
            {
                panelSubMenuProductos.Visible = false;
            }
            if(panelSubMenuProveedores.Visible == true)
            {
                panelSubMenuProveedores.Visible = false;
            }
        }
        // Función que muestra un submenú
        private void mostrarSubmenus(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                ocultarSubMenus();
                subMenu.Visible = false;
            }
        }
        // Función que devuelve a su color original (texto blanco y botón rojo) a los botones
        // del menú lateral izquierdo 
        private void desactivarBotonesPrincipales()
        {
            buttonVentas.TextColor = Color.FromArgb(255, 255, 255);
            buttonVentas.ButtonColor = Color.FromArgb(127, 12, 7);

            buttonInventario.TextColor = Color.FromArgb(255, 255, 255);
            buttonInventario.ButtonColor = Color.FromArgb(127, 12, 7);

            buttonAjustes.TextColor = Color.FromArgb(255, 255, 255);
            buttonAjustes.ButtonColor = Color.FromArgb(127, 12, 7);
        }
        //Función que abre en la parte central la información requerida dependiendo del botón seleccionado
        private Form activeForm = null;
        private void abrirPanelEventos(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelEventos.Controls.Add(childForm);
            panelEventos.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region Botones del menú principal (botones Ventas, Inventario, Ajustes y Cerrar Sesión) en el menú izquierdo
        private void ButtonVentas_Click(object sender, EventArgs e)
        {
            if(SW_TipoDeUsuario == CON_TipoCajero)
            {
                if (buttonVentas.ButtonColor != Color.FromArgb(255, 255, 255))
                {
                    desactivarBotonesPrincipales();
                    buttonVentas.ButtonColor = Color.FromArgb(255, 255, 255);
                    buttonVentas.TextColor = Color.FromArgb(0, 0, 0);

                    mostrarSubmenus(panelSuperiorVentas);

                    ocultarOpcionesSubMenus();

                    abrirPanelEventos(new Punto_de_Venta());
                }
            }
            else
            {
                MessageBox.Show("El tipo de Usuario NO tiene autorizacion para realizar esta accion.", "ERROR #2:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonInventario_Click(object sender, EventArgs e)
        {
            if(SW_TipoDeUsuario == CON_TipoAdministrador || SW_TipoDeUsuario == CON_TipoInventario)
            {
                if (buttonInventario.ButtonColor != Color.FromArgb(255, 255, 255))
                {
                    desactivarBotonesPrincipales();
                    buttonInventario.ButtonColor = Color.FromArgb(255, 255, 255);
                    buttonInventario.TextColor = Color.FromArgb(0, 0, 0);
                    mostrarSubmenus(panelSuperiorInventario);

                    ocultarOpcionesSubMenus();

                    abrirPanelEventos(new Sistema_de_Inventariado(SW_TipoDeUsuario));
                }
            }
            else
            {
                MessageBox.Show("El tipo de Usuario NO tiene autorizacion para realizar esta accion.", "ERROR #2:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAjustes_Click(object sender, EventArgs e)
        {
            if (buttonAjustes.ButtonColor != Color.FromArgb(255, 255, 255))
            {
                desactivarBotonesPrincipales();
                buttonAjustes.ButtonColor = Color.FromArgb(255, 255, 255);
                buttonAjustes.TextColor = Color.FromArgb(0, 0, 0);

                mostrarSubmenus(panelSuperiorAjustes);

                //Mostrar el menú de opciones dependiendo de cual fue el último submenú seleccionado
                Point pos1 = new Point(-9, 12);
                Point pos2 = new Point(-9, 52);
                Point pos3 = new Point(-9, 92);

                if(buttonAjustesProductos.Location == pos1)
                {
                    panelSubMenuProveedores.Visible = false;
                    panelSubMenuProductos.Visible = true;
                }
                else if(buttonAjustesProveedores.Location == pos2)
                {
                    panelSubMenuProductos.Visible = false;
                    panelSubMenuProveedores.Visible = true;
                }
                else if(buttonAjustesVentas.Location == pos3)
                {
                    panelSubMenuProductos.Visible = false;
                    panelSubMenuProveedores.Visible = false;
                }
                /*
                if (SW_TipoDeUsuario == CON_TipoAdministrador)
                {
                    Ajustes_Administrativos AA = new Ajustes_Administrativos();
                    AA.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El tipo de Usuario NO tiene autorizacion para realizar esta accion.", "ERROR #2:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }*/
            }
        }

        private void Button_CerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }
        #endregion

        #region Botones del submenú de Ajustes
        private void ButtonAjustesVentas_Click(object sender, EventArgs e)
        {
            buttonAjustesVentas.BackColor = Color.Transparent;
            // Mostrar boton seleccionado
            buttonAjustesVentas.Location = new Point(-9, 92);
            buttonAjustesVentas.Text = "    Ventas";

            // Ocultar otros botones del panel
            buttonAjustesProductos.Location = new Point(-110, 12);
            buttonAjustesProductos.Text = "   Productos            ▶";
            buttonAjustesProveedores.Location = new Point(-110, 52);
            buttonAjustesProveedores.Text = "    Proveedores    ▶";

            panelSubMenuProveedores.Visible = false;
            panelSubMenuProductos.Visible = false;
        }
        private void OnMouseEnterbuttonAjustesVentas(object sender, EventArgs e)
        {
            buttonAjustesVentas.BackColor = Color.Transparent;
            Point posicion = new Point(-110, 92);
            if (buttonAjustesVentas.Location == posicion)
            {
                buttonAjustesVentas.Location = new Point(-9, 92);
            }
        }
        private void OnMouseLeavebuttonAjustesVentas(object sender, EventArgs e)
        {
            buttonAjustesVentas.BackColor = Color.Transparent;
            Point posicion = new Point(-9, 92);
            if (buttonAjustesVentas.Location == posicion
                && buttonAjustesVentas.Text == "          Ventas        ▶")
            {
                buttonAjustesVentas.Location = new Point(-110, 92);
            }
        }
        private void ButtonAjustesProveedores_Click(object sender, EventArgs e)
        {
            buttonAjustesProveedores.BackColor = Color.Transparent;
            //Mostrar botón seleccionado
            buttonAjustesProveedores.Location = new Point(-9, 52);
            buttonAjustesProveedores.Text = "   Proveedores";

            //Ocultar los otros botones del panel
            buttonAjustesProductos.Location = new Point(-110, 12);
            buttonAjustesProductos.Text = "   Productos            ▶";
            buttonAjustesVentas.Location = new Point(-110, 92);
            buttonAjustesVentas.Text = "          Ventas        ▶";

            panelSubMenuProveedores.Visible = true;
            panelSubMenuProductos.Visible = false;
        }
        private void OnMouseEnterbuttonAjustesProveedores(object sender, EventArgs e)
        {
            buttonAjustesProveedores.BackColor = Color.Transparent;
            Point posicion = new Point(-110, 52);
            if (buttonAjustesProveedores.Location == posicion)
            {
                buttonAjustesProveedores.Location = new Point(-9, 52);
            }
        }
        private void OnMouseLeavebuttonAjustesProveedores(object sender, EventArgs e)
        {
            buttonAjustesProveedores.BackColor = Color.Transparent;
            Point posicion = new Point(-9, 52);
            if (buttonAjustesProveedores.Location == posicion
                && buttonAjustesProveedores.Text == "    Proveedores    ▶")
            {
                buttonAjustesProveedores.Location = new Point(-110, 52);
            }
        }
        private void ButtonAjustesProductos_Click(object sender, EventArgs e)
        {
            buttonAjustesProductos.BackColor = Color.Transparent;
            //Mostrar botón seleccionado
            buttonAjustesProductos.Location = new Point(-9, 12);
            buttonAjustesProductos.Text = "   Productos";

            //Ocultar los otros botones del panel
            buttonAjustesProveedores.Location = new Point(-110, 52);
            buttonAjustesProveedores.Text = "    Proveedores    ▶";
            buttonAjustesVentas.Location = new Point(-110, 92);
            buttonAjustesVentas.Text = "          Ventas        ▶";

            panelSubMenuProveedores.Visible = false;
            panelSubMenuProductos.Visible = true;
        }
        private void OnMouseEnterbuttonAjustesProductos(object sender, EventArgs e)
        {
            buttonAjustesProductos.BackColor = Color.Transparent;
            Point posicion = new Point(-110, 12);
            if (buttonAjustesProductos.Location == posicion)
            {
                buttonAjustesProductos.Location = new Point(-9, 12);
            }
        }
        private void OnMouseLeavebuttonAjustesProductos(object sender, EventArgs e)
        {
            buttonAjustesProductos.BackColor = Color.Transparent;
            Point posicion = new Point(-9, 12);
            if (buttonAjustesProductos.Location == posicion
                && buttonAjustesProductos.Text == "   Productos            ▶")
            {
                buttonAjustesProductos.Location = new Point(-110, 12);
            }
        }
        #endregion
    }
}
