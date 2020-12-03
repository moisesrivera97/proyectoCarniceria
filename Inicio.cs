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
            if(usuario == CON_TipoCajero)
            {
                buttonVentas.ButtonColor = Color.FromArgb(255,255,255);
                buttonVentas.TextColor = Color.FromArgb(0,0,0);

                panelSuperiorAjustes.Visible = false;
                panelSuperiorInventario.Visible = false;
            }
            else if(usuario == CON_TipoInventario)
            {
                buttonInventario.ButtonColor = Color.FromArgb(255,255,255);
                buttonInventario.TextColor = Color.FromArgb(0,0,0);

                panelSuperiorAjustes.Visible = false;
                panelSuperiorVentas.Visible = false;
            }
            else if(usuario == CON_TipoAdministrador)
            {
                buttonAjustes.ButtonColor = Color.FromArgb(255,255,255);
                buttonAjustes.TextColor = Color.FromArgb(0,0,0);

                panelSuperiorInventario.Visible = false;
                panelSuperiorVentas.Visible = false;
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
        #endregion

        #region Botones del menú principal (botones Ventas, Inventario, Ajustes y Cerrar Sesión) en el menú izquierdo
        private void ButtonVentas_Click(object sender, EventArgs e)
        {
            if(buttonVentas.ButtonColor != Color.FromArgb(255,255,255))
            {
                desactivarBotonesPrincipales();
                buttonVentas.ButtonColor = Color.FromArgb(255, 255, 255);
                buttonVentas.TextColor = Color.FromArgb(0, 0, 0);

                mostrarSubmenus(panelSuperiorVentas);
                /*
                if (SW_TipoDeUsuario == CON_TipoCajero)
                {
                    Punto_de_Venta Pv = new Punto_de_Venta();
                    Pv.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El tipo de Usuario NO tiene autorizacion para realizar esta accion.", "ERROR #2:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }*/
            }
        }

        private void ButtonInventario_Click(object sender, EventArgs e)
        {
            if (buttonInventario.ButtonColor != Color.FromArgb(255, 255, 255))
            {
                desactivarBotonesPrincipales();
                buttonInventario.ButtonColor = Color.FromArgb(255, 255, 255);
                buttonInventario.TextColor = Color.FromArgb(0, 0, 0);
                mostrarSubmenus(panelSuperiorInventario);

                /*
                if (SW_TipoDeUsuario == CON_TipoAdministrador || SW_TipoDeUsuario == CON_TipoInventario)
                {
                    Sistema_de_Inventariado SI = new Sistema_de_Inventariado(SW_TipoDeUsuario);
                    SI.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El tipo de Usuario NO tiene autorizacion para realizar esta accion.", "ERROR #2:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }*/
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


    }
}
