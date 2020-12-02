using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBD
{
    public partial class FormConexionBD : Form
    {
        public FormConexionBD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionBase();
        }

         public void ConexionBase()
        {
            string stringConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\chris\\source\\repos\\ConexionBD\\ConexionBD\\PruebaConexion.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = stringConexion;

            try
            {
                connection.Open();
                EstadoInicial.Text = "Conectado";
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e.Message);
            }
            finally
            {
                connection.Close();
                EstadoFinal.Text = "Desconectado";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
