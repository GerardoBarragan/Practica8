namespace videojuegos
{
    partial class Videojuegos
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
            this.dataver = new System.Windows.Forms.DataGridView();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxAño = new System.Windows.Forms.TextBox();
            this.textBoxCompañia = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.Compañia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGenero = new System.Windows.Forms.TextBox();
            this.Genero = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataver)).BeginInit();
            this.SuspendLayout();
            // 
            // dataver
            // 
            this.dataver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataver.Location = new System.Drawing.Point(12, 12);
            this.dataver.Name = "dataver";
            this.dataver.Size = new System.Drawing.Size(402, 275);
            this.dataver.TabIndex = 0;
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(673, 222);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(100, 20);
            this.textBuscar.TabIndex = 55;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 48);
            this.button1.TabIndex = 56;
            this.button1.Text = "Agregar Video juego";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(487, 40);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 57;
            // 
            // textBoxAño
            // 
            this.textBoxAño.Location = new System.Drawing.Point(487, 130);
            this.textBoxAño.Name = "textBoxAño";
            this.textBoxAño.Size = new System.Drawing.Size(100, 20);
            this.textBoxAño.TabIndex = 58;
            // 
            // textBoxCompañia
            // 
            this.textBoxCompañia.Location = new System.Drawing.Point(487, 83);
            this.textBoxCompañia.Name = "textBoxCompañia";
            this.textBoxCompañia.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompañia.TabIndex = 59;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(420, 43);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(44, 13);
            this.nombre.TabIndex = 60;
            this.nombre.Text = "Nombre";
            // 
            // Compañia
            // 
            this.Compañia.AutoSize = true;
            this.Compañia.Location = new System.Drawing.Point(420, 86);
            this.Compañia.Name = "Compañia";
            this.Compañia.Size = new System.Drawing.Size(54, 13);
            this.Compañia.TabIndex = 61;
            this.Compañia.Text = "Compañia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Año";
            // 
            // textBoxGenero
            // 
            this.textBoxGenero.Location = new System.Drawing.Point(487, 170);
            this.textBoxGenero.Name = "textBoxGenero";
            this.textBoxGenero.Size = new System.Drawing.Size(100, 20);
            this.textBoxGenero.TabIndex = 63;
            // 
            // Genero
            // 
            this.Genero.AutoSize = true;
            this.Genero.Location = new System.Drawing.Point(420, 173);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(42, 13);
            this.Genero.TabIndex = 64;
            this.Genero.Text = "Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Buscar";
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(698, 287);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 66;
            this.Salir.Text = "salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Videojuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 330);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.textBoxGenero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Compañia);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.textBoxCompañia);
            this.Controls.Add(this.textBoxAño);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.dataver);
            this.Name = "Videojuegos";
            this.Text = "Videojuegos";
            this.Load += new System.EventHandler(this.Videojuegos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataver;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxAño;
        private System.Windows.Forms.TextBox textBoxCompañia;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label Compañia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGenero;
        private System.Windows.Forms.Label Genero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Salir;
    }
}