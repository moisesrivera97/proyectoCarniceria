namespace PROYECTOIS1
{
    partial class Menu_Ventas
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tabla_ProdcutosDeVenta = new System.Windows.Forms.ListView();
            this.Label_TotalDinero = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNumeroVenta = new TextBox3.TextBoxRounded();
            this.buttonBuscar = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numero de Venta";
            // 
            // Tabla_ProdcutosDeVenta
            // 
            this.Tabla_ProdcutosDeVenta.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabla_ProdcutosDeVenta.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Tabla_ProdcutosDeVenta.HideSelection = false;
            this.Tabla_ProdcutosDeVenta.Location = new System.Drawing.Point(13, 102);
            this.Tabla_ProdcutosDeVenta.Name = "Tabla_ProdcutosDeVenta";
            this.Tabla_ProdcutosDeVenta.Size = new System.Drawing.Size(812, 197);
            this.Tabla_ProdcutosDeVenta.TabIndex = 51;
            this.Tabla_ProdcutosDeVenta.UseCompatibleStateImageBehavior = false;
            this.Tabla_ProdcutosDeVenta.View = System.Windows.Forms.View.Details;
            // 
            // Label_TotalDinero
            // 
            this.Label_TotalDinero.AutoSize = true;
            this.Label_TotalDinero.BackColor = System.Drawing.Color.Transparent;
            this.Label_TotalDinero.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalDinero.Location = new System.Drawing.Point(429, 338);
            this.Label_TotalDinero.Name = "Label_TotalDinero";
            this.Label_TotalDinero.Size = new System.Drawing.Size(54, 23);
            this.Label_TotalDinero.TabIndex = 63;
            this.Label_TotalDinero.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 34);
            this.label5.TabIndex = 58;
            this.label5.Text = "Total: $";
            // 
            // textBoxNumeroVenta
            // 
            this.textBoxNumeroVenta.colorBottom = System.Drawing.Color.White;
            this.textBoxNumeroVenta.colorTop = System.Drawing.Color.Silver;
            this.textBoxNumeroVenta.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroVenta.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNumeroVenta.Location = new System.Drawing.Point(223, 27);
            this.textBoxNumeroVenta.Name = "textBoxNumeroVenta";
            this.textBoxNumeroVenta.Size = new System.Drawing.Size(463, 30);
            this.textBoxNumeroVenta.TabIndex = 64;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBuscar.BorderColor = System.Drawing.Color.Transparent;
            this.buttonBuscar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(12)))), ((int)(((byte)(7)))));
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(692, 14);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.buttonBuscar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.buttonBuscar.OnHoverTextColor = System.Drawing.Color.Black;
            this.buttonBuscar.Size = new System.Drawing.Size(133, 55);
            this.buttonBuscar.TabIndex = 65;
            this.buttonBuscar.Text = "     Buscar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.TextColor = System.Drawing.Color.White;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // Menu_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 399);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxNumeroVenta);
            this.Controls.Add(this.Label_TotalDinero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tabla_ProdcutosDeVenta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Ventas";
            this.Text = "Menu_Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Tabla_ProdcutosDeVenta;
        private System.Windows.Forms.Label Label_TotalDinero;
        private System.Windows.Forms.Label label5;
        private TextBox3.TextBoxRounded textBoxNumeroVenta;
        private ePOSOne.btnProduct.Button_WOC buttonBuscar;
    }
}