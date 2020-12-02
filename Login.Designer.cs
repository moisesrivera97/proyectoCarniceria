namespace PROYECTOIS1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxRoundedPass = new System.Windows.Forms.TextBox();
            this.textBoxRoundedUser = new System.Windows.Forms.TextBox();
            this.buttonSalir = new ePOSOne.btnProduct.Button_WOC();
            this.buttonIngresar = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxRoundedPass
            // 
            this.textBoxRoundedPass.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoundedPass.Location = new System.Drawing.Point(26, 280);
            this.textBoxRoundedPass.Name = "textBoxRoundedPass";
            this.textBoxRoundedPass.PasswordChar = '*';
            this.textBoxRoundedPass.Size = new System.Drawing.Size(285, 30);
            this.textBoxRoundedPass.TabIndex = 14;
            // 
            // textBoxRoundedUser
            // 
            this.textBoxRoundedUser.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoundedUser.Location = new System.Drawing.Point(26, 216);
            this.textBoxRoundedUser.Name = "textBoxRoundedUser";
            this.textBoxRoundedUser.Size = new System.Drawing.Size(285, 30);
            this.textBoxRoundedUser.TabIndex = 14;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSalir.BorderColor = System.Drawing.Color.Transparent;
            this.buttonSalir.ButtonColor = System.Drawing.Color.White;
            this.buttonSalir.FlatAppearance.BorderSize = 0;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(234, 345);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.buttonSalir.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.buttonSalir.OnHoverTextColor = System.Drawing.Color.Black;
            this.buttonSalir.Size = new System.Drawing.Size(86, 26);
            this.buttonSalir.TabIndex = 15;
            this.buttonSalir.Text = "     Salir";
            this.buttonSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalir.TextColor = System.Drawing.Color.Black;
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonIngresar.BorderColor = System.Drawing.Color.Transparent;
            this.buttonIngresar.ButtonColor = System.Drawing.Color.White;
            this.buttonIngresar.FlatAppearance.BorderSize = 0;
            this.buttonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIngresar.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresar.Location = new System.Drawing.Point(26, 316);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.buttonIngresar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.buttonIngresar.OnHoverTextColor = System.Drawing.Color.Black;
            this.buttonIngresar.Size = new System.Drawing.Size(133, 55);
            this.buttonIngresar.TabIndex = 3;
            this.buttonIngresar.Text = "    Ingresar";
            this.buttonIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIngresar.TextColor = System.Drawing.Color.Black;
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.ButtonIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(332, 383);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textBoxRoundedUser);
            this.Controls.Add(this.textBoxRoundedPass);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxRoundedPass;
        private System.Windows.Forms.TextBox textBoxRoundedUser;
        private ePOSOne.btnProduct.Button_WOC buttonIngresar;
        private ePOSOne.btnProduct.Button_WOC buttonSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}