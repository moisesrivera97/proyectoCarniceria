namespace PROYECTOIS1
{
    partial class Agregar_Productos
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
            this.label5 = new System.Windows.Forms.Label();
            this.Input_CodigoProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Input_Precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Input_NomProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Boton_Verificar = new System.Windows.Forms.Button();
            this.Input_NumProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "Agregar";
            // 
            // Input_CodigoProveedor
            // 
            this.Input_CodigoProveedor.Location = new System.Drawing.Point(135, 219);
            this.Input_CodigoProveedor.Name = "Input_CodigoProveedor";
            this.Input_CodigoProveedor.Size = new System.Drawing.Size(69, 20);
            this.Input_CodigoProveedor.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Codigo Del Proveedor";
            // 
            // Input_Precio
            // 
            this.Input_Precio.Location = new System.Drawing.Point(134, 178);
            this.Input_Precio.Name = "Input_Precio";
            this.Input_Precio.Size = new System.Drawing.Size(70, 20);
            this.Input_Precio.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Precio (Kg)";
            // 
            // Input_NomProd
            // 
            this.Input_NomProd.Location = new System.Drawing.Point(135, 132);
            this.Input_NomProd.Name = "Input_NomProd";
            this.Input_NomProd.Size = new System.Drawing.Size(181, 20);
            this.Input_NomProd.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre Del Producto";
            // 
            // Boton_Verificar
            // 
            this.Boton_Verificar.Location = new System.Drawing.Point(111, 263);
            this.Boton_Verificar.Name = "Boton_Verificar";
            this.Boton_Verificar.Size = new System.Drawing.Size(130, 38);
            this.Boton_Verificar.TabIndex = 25;
            this.Boton_Verificar.Text = "Agregar";
            this.Boton_Verificar.UseVisualStyleBackColor = true;
            this.Boton_Verificar.Click += new System.EventHandler(this.Boton_Verificar_Click);
            // 
            // Input_NumProducto
            // 
            this.Input_NumProducto.Location = new System.Drawing.Point(137, 87);
            this.Input_NumProducto.Name = "Input_NumProducto";
            this.Input_NumProducto.Size = new System.Drawing.Size(67, 20);
            this.Input_NumProducto.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Numero del Producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(1, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 10);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Agregar_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 330);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Input_CodigoProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Input_Precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Input_NomProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Boton_Verificar);
            this.Controls.Add(this.Input_NumProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Agregar_Productos";
            this.Text = "Agregar_Productos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Agregar_Productos_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Input_CodigoProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Input_Precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Input_NomProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Boton_Verificar;
        private System.Windows.Forms.TextBox Input_NumProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}