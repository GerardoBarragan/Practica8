using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace videojuegos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bentrar_Click(object sender, EventArgs e)
        {

        }

        private void bentrar_Click_1(object sender, EventArgs e)
        {

            try
            {

                string myConnection = "datasource=localhost;port=3306;username=root;password=bety145";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand ComandoSelect = new MySqlCommand("select * from videojuego.Usuarios where Usuario='" + this.textBoxusuario.Text + "' and Contraseña='" + this.textBoxpass.Text + "';", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = ComandoSelect.ExecuteReader();
                int contador = 0;
                while (myReader.Read())
                {
                    contador = contador + 1;

                }
                if (contador == 1)
                {

                    MessageBox.Show("Bienvenido");
                    textBoxusuario.Enabled = false;
                    textBoxpass.Enabled = false;
                    bentrar.Enabled = false;

                    Videojuegos nuevovideojuego = new Videojuegos();
                    nuevovideojuego.Visible = true;
                    this.Visible = false;
                }
                else if (contador > 1)
                {

                    MessageBox.Show(" Usuario y Contraseña duplicados acceso denegado");
                }
                else MessageBox.Show("usuario y contraseña son incorrectos");

                myConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void bsalir_Click(object sender, EventArgs e)
        {

            Close();

        }
    }
}
