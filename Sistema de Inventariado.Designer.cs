namespace PROYECTOIS1
{
    partial class Sistema_de_Inventariado
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
            this.Tabla_Productos = new System.Windows.Forms.ListView();
            this.Cod_Prod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kilos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Segundero = new System.Windows.Forms.Timer(this.components);
            this.buttonActualizar = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // Tabla_Productos
            // 
            this.Tabla_Productos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cod_Prod,
            this.Nombre,
            this.Kilos,
            this.Precio,
            this.Proveedor});
            this.Tabla_Productos.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabla_Productos.HideSelection = false;
            this.Tabla_Productos.Location = new System.Drawing.Point(12, 12);
            this.Tabla_Productos.Name = "Tabla_Productos";
            this.Tabla_Productos.Size = new System.Drawing.Size(813, 229);
            this.Tabla_Productos.TabIndex = 7;
            this.Tabla_Productos.UseCompatibleStateImageBehavior = false;
            this.Tabla_Productos.View = System.Windows.Forms.View.Details;
            // 
            // Cod_Prod
            // 
            this.Cod_Prod.Text = "Codigo Del Producto";
            this.Cod_Prod.Width = 110;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 240;
            // 
            // Kilos
            // 
            this.Kilos.Text = "Kilos Actuales";
            this.Kilos.Width = 120;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio Actual";
            this.Precio.Width = 120;
            // 
            // Proveedor
            // 
            this.Proveedor.Text = "Proveedor";
            this.Proveedor.Width = 160;
            // 
            // Segundero
            // 
            this.Segundero.Enabled = true;
            this.Segundero.Interval = 1000;
            this.Segundero.Tick += new System.EventHandler(this.Segundero_Tick);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonActualizar.BorderColor = System.Drawing.Color.Transparent;
            this.buttonActualizar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(12)))), ((int)(((byte)(7)))));
            this.buttonActualizar.FlatAppearance.BorderSize = 0;
            this.buttonActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizar.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.Location = new System.Drawing.Point(301, 299);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.buttonActualizar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.buttonActualizar.OnHoverTextColor = System.Drawing.Color.Black;
            this.buttonActualizar.Size = new System.Drawing.Size(220, 55);
            this.buttonActualizar.TabIndex = 48;
            this.buttonActualizar.Text = " Actualizar Inventario";
            this.buttonActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonActualizar.TextColor = System.Drawing.Color.White;
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.ButtonActualizar_Click);
            // 
            // Sistema_de_Inventariado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 399);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.Tabla_Productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sistema_de_Inventariado";
            this.Text = "Sistema_de_Inventariado";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView Tabla_Productos;
        private System.Windows.Forms.ColumnHeader Cod_Prod;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Kilos;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Proveedor;
        private System.Windows.Forms.Timer Segundero;
        private ePOSOne.btnProduct.Button_WOC buttonActualizar;
    }
}