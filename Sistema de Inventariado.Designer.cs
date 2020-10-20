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
            this.Boton_ActualizarInventario = new System.Windows.Forms.Button();
            this.Tabla_Productos = new System.Windows.Forms.ListView();
            this.Cod_Prod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kilos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_ActualizarInventario
            // 
            this.Boton_ActualizarInventario.Location = new System.Drawing.Point(276, 398);
            this.Boton_ActualizarInventario.Name = "Boton_ActualizarInventario";
            this.Boton_ActualizarInventario.Size = new System.Drawing.Size(234, 37);
            this.Boton_ActualizarInventario.TabIndex = 8;
            this.Boton_ActualizarInventario.Text = "Actualizar Inventario";
            this.Boton_ActualizarInventario.UseVisualStyleBackColor = true;
            this.Boton_ActualizarInventario.Click += new System.EventHandler(this.Boton_ActualizarInventario_Click);
            // 
            // Tabla_Productos
            // 
            this.Tabla_Productos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cod_Prod,
            this.Nombre,
            this.Kilos,
            this.Precio,
            this.Proveedor});
            this.Tabla_Productos.HideSelection = false;
            this.Tabla_Productos.Location = new System.Drawing.Point(23, 97);
            this.Tabla_Productos.Name = "Tabla_Productos";
            this.Tabla_Productos.Size = new System.Drawing.Size(756, 270);
            this.Tabla_Productos.TabIndex = 7;
            this.Tabla_Productos.UseCompatibleStateImageBehavior = false;
            this.Tabla_Productos.View = System.Windows.Forms.View.Details;
            this.Tabla_Productos.SelectedIndexChanged += new System.EventHandler(this.Tabla_Productos_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "INVENTARIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 5);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Sistema_de_Inventariado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Boton_ActualizarInventario);
            this.Controls.Add(this.Tabla_Productos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Sistema_de_Inventariado";
            this.Text = "Sistema_de_Inventariado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sistema_de_Inventariado_FormClosed);
            this.Load += new System.EventHandler(this.Sistema_de_Inventariado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_ActualizarInventario;
        private System.Windows.Forms.ListView Tabla_Productos;
        private System.Windows.Forms.ColumnHeader Cod_Prod;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Kilos;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}