namespace videojuegos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bsalir = new System.Windows.Forms.Button();
            this.bentrar = new System.Windows.Forms.Button();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.textBoxusuario = new System.Windows.Forms.TextBox();
            this.lpass = new System.Windows.Forms.Label();
            this.lusuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bsalir
            // 
            this.bsalir.Location = new System.Drawing.Point(314, 200);
            this.bsalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(100, 35);
            this.bsalir.TabIndex = 11;
            this.bsalir.Text = "Salir";
            this.bsalir.UseVisualStyleBackColor = true;
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // bentrar
            // 
            this.bentrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bentrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bentrar.Location = new System.Drawing.Point(195, 200);
            this.bentrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bentrar.Name = "bentrar";
            this.bentrar.Size = new System.Drawing.Size(107, 35);
            this.bentrar.TabIndex = 10;
            this.bentrar.Text = "              Entrar";
            this.bentrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bentrar.UseVisualStyleBackColor = false;
            this.bentrar.Click += new System.EventHandler(this.bentrar_Click_1);
            // 
            // textBoxpass
            // 
            this.textBoxpass.Location = new System.Drawing.Point(195, 107);
            this.textBoxpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(132, 20);
            this.textBoxpass.TabIndex = 9;
            this.textBoxpass.UseSystemPasswordChar = true;
            // 
            // textBoxusuario
            // 
            this.textBoxusuario.Location = new System.Drawing.Point(195, 35);
            this.textBoxusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxusuario.Name = "textBoxusuario";
            this.textBoxusuario.Size = new System.Drawing.Size(132, 20);
            this.textBoxusuario.TabIndex = 8;
            // 
            // lpass
            // 
            this.lpass.AutoSize = true;
            this.lpass.Location = new System.Drawing.Point(95, 110);
            this.lpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lpass.Name = "lpass";
            this.lpass.Size = new System.Drawing.Size(61, 13);
            this.lpass.TabIndex = 7;
            this.lpass.Text = "Contraseña";
            // 
            // lusuario
            // 
            this.lusuario.AutoSize = true;
            this.lusuario.Location = new System.Drawing.Point(106, 35);
            this.lusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lusuario.Name = "lusuario";
            this.lusuario.Size = new System.Drawing.Size(43, 13);
            this.lusuario.TabIndex = 6;
            this.lusuario.Text = "Usuario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 282);
            this.Controls.Add(this.bsalir);
            this.Controls.Add(this.bentrar);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.textBoxusuario);
            this.Controls.Add(this.lpass);
            this.Controls.Add(this.lusuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bsalir;
        private System.Windows.Forms.Button bentrar;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.TextBox textBoxusuario;
        private System.Windows.Forms.Label lpass;
        private System.Windows.Forms.Label lusuario;

    }
}

