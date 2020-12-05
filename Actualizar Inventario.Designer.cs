namespace PROYECTOIS1
{
    partial class Actualizar_Inventario
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumeroProducto = new TextBox3.TextBoxRounded();
            this.textBoxKilos = new TextBox3.TextBoxRounded();
            this.buttonActualizar = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Actualizacion De Inventario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 14);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cantidad De Kilogramos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "Numero Del Producto";
            // 
            // textBoxNumeroProducto
            // 
            this.textBoxNumeroProducto.colorBottom = System.Drawing.Color.White;
            this.textBoxNumeroProducto.colorTop = System.Drawing.Color.Silver;
            this.textBoxNumeroProducto.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroProducto.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNumeroProducto.Location = new System.Drawing.Point(156, 91);
            this.textBoxNumeroProducto.Name = "textBoxNumeroProducto";
            this.textBoxNumeroProducto.Size = new System.Drawing.Size(142, 27);
            this.textBoxNumeroProducto.TabIndex = 44;
            // 
            // textBoxKilos
            // 
            this.textBoxKilos.colorBottom = System.Drawing.Color.White;
            this.textBoxKilos.colorTop = System.Drawing.Color.Silver;
            this.textBoxKilos.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKilos.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxKilos.Location = new System.Drawing.Point(156, 160);
            this.textBoxKilos.Name = "textBoxKilos";
            this.textBoxKilos.Size = new System.Drawing.Size(142, 27);
            this.textBoxKilos.TabIndex = 45;
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
            this.buttonActualizar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.Location = new System.Drawing.Point(109, 230);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.buttonActualizar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.buttonActualizar.OnHoverTextColor = System.Drawing.Color.Black;
            this.buttonActualizar.Size = new System.Drawing.Size(122, 39);
            this.buttonActualizar.TabIndex = 48;
            this.buttonActualizar.Text = "   Actualizar";
            this.buttonActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonActualizar.TextColor = System.Drawing.Color.White;
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.ButtonActualizar_Click);
            // 
            // Actualizar_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 281);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.textBoxKilos);
            this.Controls.Add(this.textBoxNumeroProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Actualizar_Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar_Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private TextBox3.TextBoxRounded textBoxNumeroProducto;
        private TextBox3.TextBoxRounded textBoxKilos;
        private ePOSOne.btnProduct.Button_WOC buttonActualizar;
    }
}