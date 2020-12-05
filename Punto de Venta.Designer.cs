namespace PROYECTOIS1
{
    partial class Punto_de_Venta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Label_TotalDinero = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tabla_ProdcutosDeVenta = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_NumTicket = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_Hora = new System.Windows.Forms.Label();
            this.Timer_Segundero = new System.Windows.Forms.Timer(this.components);
            this.textBoxPeso = new TextBox3.TextBoxRounded();
            this.textBoxCodigoProducto = new TextBox3.TextBoxRounded();
            this.buttonAgregar = new ePOSOne.btnProduct.Button_WOC();
            this.buttonCorte = new ePOSOne.btnProduct.Button_WOC();
            this.buttonCanProd = new ePOSOne.btnProduct.Button_WOC();
            this.buttonCancelarVenta = new ePOSOne.btnProduct.Button_WOC();
            this.buttonPagar = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // Label_TotalDinero
            // 
            this.Label_TotalDinero.AutoSize = true;
            this.Label_TotalDinero.BackColor = System.Drawing.Color.Transparent;
            this.Label_TotalDinero.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalDinero.Location = new System.Drawing.Point(133, 346);
            this.Label_TotalDinero.Name = "Label_TotalDinero";
            this.Label_TotalDinero.Size = new System.Drawing.Size(54, 23);
            this.Label_TotalDinero.TabIndex = 44;
            this.Label_TotalDinero.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 35);
            this.label5.TabIndex = 39;
            this.label5.Text = "Total: $";
            // 
            // Tabla_ProdcutosDeVenta
            // 
            this.Tabla_ProdcutosDeVenta.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabla_ProdcutosDeVenta.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Tabla_ProdcutosDeVenta.HideSelection = false;
            this.Tabla_ProdcutosDeVenta.Location = new System.Drawing.Point(12, 100);
            this.Tabla_ProdcutosDeVenta.Name = "Tabla_ProdcutosDeVenta";
            this.Tabla_ProdcutosDeVenta.Size = new System.Drawing.Size(758, 220);
            this.Tabla_ProdcutosDeVenta.TabIndex = 36;
            this.Tabla_ProdcutosDeVenta.UseCompatibleStateImageBehavior = false;
            this.Tabla_ProdcutosDeVenta.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Peso del Producto (Kg):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Codigo del Producto:";
            // 
            // Label_NumTicket
            // 
            this.Label_NumTicket.AutoSize = true;
            this.Label_NumTicket.Location = new System.Drawing.Point(465, 10);
            this.Label_NumTicket.Name = "Label_NumTicket";
            this.Label_NumTicket.Size = new System.Drawing.Size(0, 13);
            this.Label_NumTicket.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Numero de Ticket:";
            // 
            // Label_Hora
            // 
            this.Label_Hora.AutoSize = true;
            this.Label_Hora.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Hora.Location = new System.Drawing.Point(688, 6);
            this.Label_Hora.Name = "Label_Hora";
            this.Label_Hora.Size = new System.Drawing.Size(20, 19);
            this.Label_Hora.TabIndex = 27;
            this.Label_Hora.Text = "0";
            // 
            // Timer_Segundero
            // 
            this.Timer_Segundero.Enabled = true;
            this.Timer_Segundero.Interval = 1000;
            this.Timer_Segundero.Tick += new System.EventHandler(this.Timer_Segundero_Tick);
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.colorBottom = System.Drawing.Color.White;
            this.textBoxPeso.colorTop = System.Drawing.Color.Silver;
            this.textBoxPeso.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPeso.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPeso.Location = new System.Drawing.Point(535, 53);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(173, 27);
            this.textBoxPeso.TabIndex = 53;
            // 
            // textBoxCodigoProducto
            // 
            this.textBoxCodigoProducto.colorBottom = System.Drawing.Color.White;
            this.textBoxCodigoProducto.colorTop = System.Drawing.Color.Silver;
            this.textBoxCodigoProducto.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigoProducto.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCodigoProducto.Location = new System.Drawing.Point(185, 53);
            this.textBoxCodigoProducto.Name = "textBoxCodigoProducto";
            this.textBoxCodigoProducto.Size = new System.Drawing.Size(145, 27);
            this.textBoxCodigoProducto.TabIndex = 52;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAgregar.BorderColor = System.Drawing.Color.Transparent;
            this.buttonAgregar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(12)))), ((int)(((byte)(7)))));
            this.buttonAgregar.FlatAppearance.BorderSize = 0;
            this.buttonAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(716, 49);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.buttonAgregar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.buttonAgregar.OnHoverTextColor = System.Drawing.Color.Black;
            this.buttonAgregar.Size = new System.Drawing.Size(110, 32);
            this.buttonAgregar.TabIndex = 54;
            this.buttonAgregar.Text = "    Agregar";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregar.TextColor = System.Drawing.Color.White;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.ButtonAgregar_Click);
            // 
            // buttonCorte
            // 
            this.buttonCorte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCorte.BorderColor = System.Drawing.Color.Transparent;
            this.buttonCorte.ButtonColor = System.Drawing.Color.DarkCyan;
            this.buttonCorte.FlatAppearance.BorderSize = 0;
            this.buttonCorte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonCorte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCorte.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCorte.Location = new System.Drawing.Point(701, 331);
            this.buttonCorte.Name = "buttonCorte";
            this.buttonCorte.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.buttonCorte.OnHoverButtonColor = System.Drawing.Color.Black;
            this.buttonCorte.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonCorte.Size = new System.Drawing.Size(135, 55);
            this.buttonCorte.TabIndex = 55;
            this.buttonCorte.Text = "  Realizar corte";
            this.buttonCorte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCorte.TextColor = System.Drawing.Color.White;
            this.buttonCorte.UseVisualStyleBackColor = true;
            this.buttonCorte.Click += new System.EventHandler(this.ButtonCorte_Click);
            // 
            // buttonCanProd
            // 
            this.buttonCanProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCanProd.BorderColor = System.Drawing.Color.Transparent;
            this.buttonCanProd.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(12)))), ((int)(((byte)(7)))));
            this.buttonCanProd.FlatAppearance.BorderSize = 0;
            this.buttonCanProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonCanProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonCanProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCanProd.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCanProd.Location = new System.Drawing.Point(526, 336);
            this.buttonCanProd.Name = "buttonCanProd";
            this.buttonCanProd.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.buttonCanProd.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.buttonCanProd.OnHoverTextColor = System.Drawing.Color.Black;
            this.buttonCanProd.Size = new System.Drawing.Size(159, 44);
            this.buttonCanProd.TabIndex = 56;
            this.buttonCanProd.Text = " Cancelar Producto";
            this.buttonCanProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCanProd.TextColor = System.Drawing.Color.White;
            this.buttonCanProd.UseVisualStyleBackColor = true;
            this.buttonCanProd.Click += new System.EventHandler(this.ButtonCanProd_Click);
            // 
            // buttonCancelarVenta
            // 
            this.buttonCancelarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCancelarVenta.BorderColor = System.Drawing.Color.Transparent;
            this.buttonCancelarVenta.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(12)))), ((int)(((byte)(7)))));
            this.buttonCancelarVenta.FlatAppearance.BorderSize = 0;
            this.buttonCancelarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonCancelarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarVenta.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarVenta.Location = new System.Drawing.Point(361, 336);
            this.buttonCancelarVenta.Name = "buttonCancelarVenta";
            this.buttonCancelarVenta.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.buttonCancelarVenta.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.buttonCancelarVenta.OnHoverTextColor = System.Drawing.Color.Black;
            this.buttonCancelarVenta.Size = new System.Drawing.Size(159, 44);
            this.buttonCancelarVenta.TabIndex = 57;
            this.buttonCancelarVenta.Text = "   Cancelar Venta";
            this.buttonCancelarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelarVenta.TextColor = System.Drawing.Color.White;
            this.buttonCancelarVenta.UseVisualStyleBackColor = true;
            this.buttonCancelarVenta.Click += new System.EventHandler(this.ButtonCancelarVenta_Click);
            // 
            // buttonPagar
            // 
            this.buttonPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPagar.BorderColor = System.Drawing.Color.Transparent;
            this.buttonPagar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(12)))), ((int)(((byte)(7)))));
            this.buttonPagar.FlatAppearance.BorderSize = 0;
            this.buttonPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPagar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPagar.Location = new System.Drawing.Point(217, 336);
            this.buttonPagar.Name = "buttonPagar";
            this.buttonPagar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.buttonPagar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.buttonPagar.OnHoverTextColor = System.Drawing.Color.Black;
            this.buttonPagar.Size = new System.Drawing.Size(113, 44);
            this.buttonPagar.TabIndex = 58;
            this.buttonPagar.Text = "      Pagar";
            this.buttonPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPagar.TextColor = System.Drawing.Color.White;
            this.buttonPagar.UseVisualStyleBackColor = true;
            this.buttonPagar.Click += new System.EventHandler(this.ButtonPagar_Click);
            // 
            // Punto_de_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 399);
            this.Controls.Add(this.buttonPagar);
            this.Controls.Add(this.buttonCancelarVenta);
            this.Controls.Add(this.buttonCanProd);
            this.Controls.Add(this.buttonCorte);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.textBoxCodigoProducto);
            this.Controls.Add(this.Label_TotalDinero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tabla_ProdcutosDeVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label_NumTicket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label_Hora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Punto_de_Venta";
            this.Text = "Punto_de_Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_TotalDinero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView Tabla_ProdcutosDeVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_NumTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_Hora;
        private System.Windows.Forms.Timer Timer_Segundero;
        private TextBox3.TextBoxRounded textBoxCodigoProducto;
        private TextBox3.TextBoxRounded textBoxPeso;
        private ePOSOne.btnProduct.Button_WOC buttonAgregar;
        private ePOSOne.btnProduct.Button_WOC buttonCorte;
        private ePOSOne.btnProduct.Button_WOC buttonCanProd;
        private ePOSOne.btnProduct.Button_WOC buttonCancelarVenta;
        private ePOSOne.btnProduct.Button_WOC buttonPagar;
    }
}