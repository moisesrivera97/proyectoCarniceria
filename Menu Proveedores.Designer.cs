namespace PROYECTOIS1
{
    partial class Menu_Proveedores
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
            this.Boton_Eliminar = new System.Windows.Forms.Button();
            this.Boton_Modificar = new System.Windows.Forms.Button();
            this.Boton_Agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Boton_Eliminar
            // 
            this.Boton_Eliminar.Location = new System.Drawing.Point(25, 219);
            this.Boton_Eliminar.Name = "Boton_Eliminar";
            this.Boton_Eliminar.Size = new System.Drawing.Size(158, 55);
            this.Boton_Eliminar.TabIndex = 8;
            this.Boton_Eliminar.Text = "Eliminar";
            this.Boton_Eliminar.UseVisualStyleBackColor = true;
            this.Boton_Eliminar.Click += new System.EventHandler(this.Boton_Eliminar_Click);
            // 
            // Boton_Modificar
            // 
            this.Boton_Modificar.Location = new System.Drawing.Point(25, 120);
            this.Boton_Modificar.Name = "Boton_Modificar";
            this.Boton_Modificar.Size = new System.Drawing.Size(158, 55);
            this.Boton_Modificar.TabIndex = 7;
            this.Boton_Modificar.Text = "Modificar";
            this.Boton_Modificar.UseVisualStyleBackColor = true;
            this.Boton_Modificar.Click += new System.EventHandler(this.Boton_Modificar_Click);
            // 
            // Boton_Agregar
            // 
            this.Boton_Agregar.Location = new System.Drawing.Point(25, 26);
            this.Boton_Agregar.Name = "Boton_Agregar";
            this.Boton_Agregar.Size = new System.Drawing.Size(158, 55);
            this.Boton_Agregar.TabIndex = 6;
            this.Boton_Agregar.Text = "Agregar";
            this.Boton_Agregar.UseVisualStyleBackColor = true;
            this.Boton_Agregar.Click += new System.EventHandler(this.Boton_Agregar_Click);
            // 
            // Menu_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 292);
            this.Controls.Add(this.Boton_Eliminar);
            this.Controls.Add(this.Boton_Modificar);
            this.Controls.Add(this.Boton_Agregar);
            this.Name = "Menu_Proveedores";
            this.Text = "Menu_Proveedores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_Proveedores_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Boton_Eliminar;
        private System.Windows.Forms.Button Boton_Modificar;
        private System.Windows.Forms.Button Boton_Agregar;
    }
}