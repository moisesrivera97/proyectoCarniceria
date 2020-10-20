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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Boton_Actualizar = new System.Windows.Forms.Button();
            this.Input_CantidadKg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Input_NumProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(0, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 10);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Boton_Actualizar
            // 
            this.Boton_Actualizar.Location = new System.Drawing.Point(120, 216);
            this.Boton_Actualizar.Name = "Boton_Actualizar";
            this.Boton_Actualizar.Size = new System.Drawing.Size(121, 39);
            this.Boton_Actualizar.TabIndex = 25;
            this.Boton_Actualizar.Text = "Actualizar";
            this.Boton_Actualizar.UseVisualStyleBackColor = true;
            this.Boton_Actualizar.Click += new System.EventHandler(this.Boton_Actualizar_Click);
            // 
            // Input_CantidadKg
            // 
            this.Input_CantidadKg.Location = new System.Drawing.Point(156, 161);
            this.Input_CantidadKg.Name = "Input_CantidadKg";
            this.Input_CantidadKg.Size = new System.Drawing.Size(142, 20);
            this.Input_CantidadKg.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cantidad De Kilogramos";
            // 
            // Input_NumProd
            // 
            this.Input_NumProd.Location = new System.Drawing.Point(156, 92);
            this.Input_NumProd.Name = "Input_NumProd";
            this.Input_NumProd.Size = new System.Drawing.Size(142, 20);
            this.Input_NumProd.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Numero Del Producto";
            // 
            // Actualizar_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Boton_Actualizar);
            this.Controls.Add(this.Input_CantidadKg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Input_NumProd);
            this.Controls.Add(this.label3);
            this.Name = "Actualizar_Inventario";
            this.Text = "Actualizar_Inventario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Actualizar_Inventario_FormClosed_1);
            this.Load += new System.EventHandler(this.Actualizar_Inventario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Boton_Actualizar;
        private System.Windows.Forms.TextBox Input_CantidadKg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Input_NumProd;
        private System.Windows.Forms.Label label3;
    }
}