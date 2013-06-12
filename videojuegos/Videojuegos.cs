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
    public partial class Videojuegos : Form
    {
        public Videojuegos()
        {
            InitializeComponent();
        }

        DataTable datos;

        private void Videojuegos_Load(object sender, EventArgs e)
        {

            string myConnection = "datasource=localhost;port=3306;username=root;password=bety145";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand ComandoSelect = new MySqlCommand("select id as 'ID VIDEOJUEGOS',nombre as 'NOMBRE',compañia as 'COMPAÑIA',nombre as 'NOMBRE',año as 'AÑO', genero as 'GENERO' from videojuego.videojuegos;", myConn);

            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = ComandoSelect;
                datos = new DataTable();
                sda.Fill(datos);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = datos;
                dataver.DataSource = bSource;
                sda.Update(datos);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            DataView DW = new DataView(datos);
            DW.RowFilter = String.Format("nombre LIKE '%{0}%'", textBuscar.Text);
            dataver.DataSource = DW;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string myConnection = "datasource=localhost;port=3306;username=root;password=bety145";
            MySqlConnection myConn = new MySqlConnection(myConnection);

            try
            {
                myConn.Open();
                string ComandoSelect = "INSERT  INTO videojuego.videojuegos (nombre,compañia,año,genero) VALUES ('" + textBoxNombre.Text + "','" + textBoxCompañia.Text + "','" + textBoxAño.Text + "','" + textBoxGenero.Text + "') ;";
                MySqlCommand guardarcontacto = new MySqlCommand(ComandoSelect, myConn);
                guardarcontacto.ExecuteNonQuery();

                MessageBox.Show("Videojuego Guardado");


                Videojuegos nuevovideojuego = new Videojuegos();
                nuevovideojuego.Visible = true;
                this.Visible = false;


                myConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Salir_Click(object sender, EventArgs e)
        {

            Close();


        }

    }
}
