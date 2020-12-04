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
            this.Boton_RealizarCorte = new System.Windows.Forms.Button();
            this.Label_TotalDinero = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.Boton_Pagar = new System.Windows.Forms.Button();
            this.Tabla_ProdcutosDeVenta = new System.Windows.Forms.ListView();
            this.Boton_AgregarProducto = new System.Windows.Forms.Button();
            this.Input_PesoProducto = new System.Windows.Forms.TextBox();
            this.Input_CodProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_NumTicket = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_Hora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer_Segundero = new System.Windows.Forms.Timer(this.components);
            this.Boton_CancelarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_RealizarCorte
            // 
            this.Boton_RealizarCorte.Location = new System.Drawing.Point(415, 138);
            this.Boton_RealizarCorte.Name = "Boton_RealizarCorte";
            this.Boton_RealizarCorte.Size = new System.Drawing.Size(110, 61);
            this.Boton_RealizarCorte.TabIndex = 49;
            this.Boton_RealizarCorte.Text = "Realizar Corte";
            this.Boton_RealizarCorte.UseVisualStyleBackColor = true;
            this.Boton_RealizarCorte.Click += new System.EventHandler(this.Boton_RealizarCorte_Click);
            // 
            // Label_TotalDinero
            // 
            this.Label_TotalDinero.AutoSize = true;
            this.Label_TotalDinero.BackColor = System.Drawing.Color.Transparent;
            this.Label_TotalDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalDinero.Location = new System.Drawing.Point(82, 172);
            this.Label_TotalDinero.Name = "Label_TotalDinero";
            this.Label_TotalDinero.Size = new System.Drawing.Size(45, 24);
            this.Label_TotalDinero.TabIndex = 44;
            this.Label_TotalDinero.Text = "0.00";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox6.Location = new System.Drawing.Point(74, 168);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(3, 33);
            this.pictureBox6.TabIndex = 43;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox5.Location = new System.Drawing.Point(284, 168);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(3, 33);
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(74, 198);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(210, 3);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(74, 168);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(210, 3);
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 33);
            this.label5.TabIndex = 39;
            this.label5.Text = "$";
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Enabled = false;
            this.Boton_Cancelar.Location = new System.Drawing.Point(299, 216);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(110, 61);
            this.Boton_Cancelar.TabIndex = 38;
            this.Boton_Cancelar.Text = "Cancelar Venta";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // Boton_Pagar
            // 
            this.Boton_Pagar.Enabled = false;
            this.Boton_Pagar.Location = new System.Drawing.Point(429, 216);
            this.Boton_Pagar.Name = "Boton_Pagar";
            this.Boton_Pagar.Size = new System.Drawing.Size(110, 61);
            this.Boton_Pagar.TabIndex = 37;
            this.Boton_Pagar.Text = "Pagar";
            this.Boton_Pagar.UseVisualStyleBackColor = true;
            this.Boton_Pagar.Click += new System.EventHandler(this.Boton_Pagar_Click);
            // 
            // Tabla_ProdcutosDeVenta
            // 
            this.Tabla_ProdcutosDeVenta.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Tabla_ProdcutosDeVenta.HideSelection = false;
            this.Tabla_ProdcutosDeVenta.Location = new System.Drawing.Point(43, 66);
            this.Tabla_ProdcutosDeVenta.Name = "Tabla_ProdcutosDeVenta";
            this.Tabla_ProdcutosDeVenta.Size = new System.Drawing.Size(250, 83);
            this.Tabla_ProdcutosDeVenta.TabIndex = 36;
            this.Tabla_ProdcutosDeVenta.UseCompatibleStateImageBehavior = false;
            this.Tabla_ProdcutosDeVenta.View = System.Windows.Forms.View.Details;
            // 
            // Boton_AgregarProducto
            // 
            this.Boton_AgregarProducto.Location = new System.Drawing.Point(574, 117);
            this.Boton_AgregarProducto.Name = "Boton_AgregarProducto";
            this.Boton_AgregarProducto.Size = new System.Drawing.Size(109, 32);
            this.Boton_AgregarProducto.TabIndex = 35;
            this.Boton_AgregarProducto.Text = "Agregar";
            this.Boton_AgregarProducto.UseVisualStyleBackColor = true;
            this.Boton_AgregarProducto.Click += new System.EventHandler(this.Boton_AgregarProducto_Click);
            // 
            // Input_PesoProducto
            // 
            this.Input_PesoProducto.Location = new System.Drawing.Point(517, 74);
            this.Input_PesoProducto.Name = "Input_PesoProducto";
            this.Input_PesoProducto.Size = new System.Drawing.Size(131, 20);
            this.Input_PesoProducto.TabIndex = 34;
            this.Input_PesoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_PesoProducto_KeyPress_1);
            // 
            // Input_CodProducto
            // 
            this.Input_CodProducto.Location = new System.Drawing.Point(153, 40);
            this.Input_CodProducto.Name = "Input_CodProducto";
            this.Input_CodProducto.Size = new System.Drawing.Size(97, 20);
            this.Input_CodProducto.TabIndex = 33;
            this.Input_CodProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_CodProducto_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Peso del Producto (Kg):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
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
            this.label2.Location = new System.Drawing.Point(150, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Numero de Ticket:";
            // 
            // Label_Hora
            // 
            this.Label_Hora.AutoSize = true;
            this.Label_Hora.Location = new System.Drawing.Point(426, 64);
            this.Label_Hora.Name = "Label_Hora";
            this.Label_Hora.Size = new System.Drawing.Size(13, 13);
            this.Label_Hora.TabIndex = 27;
            this.Label_Hora.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Hora:";
            // 
            // Timer_Segundero
            // 
            this.Timer_Segundero.Enabled = true;
            this.Timer_Segundero.Interval = 1000;
            this.Timer_Segundero.Tick += new System.EventHandler(this.Timer_Segundero_Tick);
            // 
            // Boton_CancelarProducto
            // 
            this.Boton_CancelarProducto.Enabled = false;
            this.Boton_CancelarProducto.Location = new System.Drawing.Point(299, 140);
            this.Boton_CancelarProducto.Name = "Boton_CancelarProducto";
            this.Boton_CancelarProducto.Size = new System.Drawing.Size(110, 61);
            this.Boton_CancelarProducto.TabIndex = 51;
            this.Boton_CancelarProducto.Text = "Cancelar Producto";
            this.Boton_CancelarProducto.UseVisualStyleBackColor = true;
            this.Boton_CancelarProducto.Click += new System.EventHandler(this.Boton_CancelarProducto_Click);
            // 
            // Punto_de_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 399);
            this.Controls.Add(this.Boton_CancelarProducto);
            this.Controls.Add(this.Boton_RealizarCorte);
            this.Controls.Add(this.Label_TotalDinero);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Pagar);
            this.Controls.Add(this.Tabla_ProdcutosDeVenta);
            this.Controls.Add(this.Boton_AgregarProducto);
            this.Controls.Add(this.Input_PesoProducto);
            this.Controls.Add(this.Input_CodProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label_NumTicket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label_Hora);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Punto_de_Venta";
            this.Text = "Punto_de_Venta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Punto_de_Venta_FormClosed_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_RealizarCorte;
        private System.Windows.Forms.Label Label_TotalDinero;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Boton_Cancelar;
        private System.Windows.Forms.Button Boton_Pagar;
        private System.Windows.Forms.ListView Tabla_ProdcutosDeVenta;
        private System.Windows.Forms.Button Boton_AgregarProducto;
        private System.Windows.Forms.TextBox Input_PesoProducto;
        private System.Windows.Forms.TextBox Input_CodProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_NumTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_Hora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer_Segundero;
        private System.Windows.Forms.Button Boton_CancelarProducto;
    }
}