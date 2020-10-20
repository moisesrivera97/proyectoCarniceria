namespace PROYECTOIS1
{
    partial class Agregar_Proveedor
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
            this.Input_Direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Input_Telefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Input_NomProv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Boton_Verificar = new System.Windows.Forms.Button();
            this.Input_NumProv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 29);
            this.label5.TabIndex = 43;
            this.label5.Text = "Agregar";
            // 
            // Input_Direccion
            // 
            this.Input_Direccion.Location = new System.Drawing.Point(135, 215);
            this.Input_Direccion.Name = "Input_Direccion";
            this.Input_Direccion.Size = new System.Drawing.Size(168, 20);
            this.Input_Direccion.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Direccion";
            // 
            // Input_Telefono
            // 
            this.Input_Telefono.Location = new System.Drawing.Point(134, 174);
            this.Input_Telefono.Name = "Input_Telefono";
            this.Input_Telefono.Size = new System.Drawing.Size(94, 20);
            this.Input_Telefono.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Telefono";
            // 
            // Input_NomProv
            // 
            this.Input_NomProv.Location = new System.Drawing.Point(135, 128);
            this.Input_NomProv.Name = "Input_NomProv";
            this.Input_NomProv.Size = new System.Drawing.Size(168, 20);
            this.Input_NomProv.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre";
            // 
            // Boton_Verificar
            // 
            this.Boton_Verificar.Location = new System.Drawing.Point(111, 259);
            this.Boton_Verificar.Name = "Boton_Verificar";
            this.Boton_Verificar.Size = new System.Drawing.Size(130, 38);
            this.Boton_Verificar.TabIndex = 36;
            this.Boton_Verificar.Text = "Agregar";
            this.Boton_Verificar.UseVisualStyleBackColor = true;
            this.Boton_Verificar.Click += new System.EventHandler(this.Boton_Verificar_Click);
            // 
            // Input_NumProv
            // 
            this.Input_NumProv.Location = new System.Drawing.Point(137, 83);
            this.Input_NumProv.Name = "Input_NumProv";
            this.Input_NumProv.Size = new System.Drawing.Size(91, 20);
            this.Input_NumProv.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Clave del Proveedor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(1, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 10);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Agregar_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 309);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Input_Direccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Input_Telefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Input_NomProv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Boton_Verificar);
            this.Controls.Add(this.Input_NumProv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Agregar_Proveedor";
            this.Text = "Agregar_Proveedor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Agregar_Proveedor_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Input_Direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Input_Telefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Input_NomProv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Boton_Verificar;
        private System.Windows.Forms.TextBox Input_NumProv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}