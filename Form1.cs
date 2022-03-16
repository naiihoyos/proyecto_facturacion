using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace PROYECTO_POS_NHZ
{
    public partial class Form1_logins_ini : Form
    {

        SqlConnection conn = new SqlConnection("server=NAII; database=posnaii; integrated security = true");
        clases.C_usuarios objeto_usuario = new clases.C_usuarios();
        Form2_pantalla_principalopc llamado;


        public Form1_logins_ini()
        {
            InitializeComponent();

            try
            {
                conn.Open();

                MessageBox.Show("DB Conectada :) ");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error conexion DB :( \n" + ex.Message);
            }
            conn.Close();
        }

        private void Form1_inicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (texbusuario.Text != "" && textbcontrasena.Text != "")
            {

                try
                {
                    conn.Open();
                    string consulta = "select * from usuarios where (usuario = '" + texbusuario.Text + "'  and clave = '" + textbcontrasena.Text + "') ";
                    SqlCommand comando = new SqlCommand(consulta, conn);
                    /*SqlCommand comando = new SqlCommand("Select * from usuarios where usuario = @p1 and clave = @p2 ", conn);
                    comando.Parameters.AddWithValue("p1", txtb1usuario.Text);
                    comando.Parameters.AddWithValue("p2", txtb2contra.Text);*/
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.SelectCommand = comando;
                    DataTable resultado = new DataTable();
                    adaptador.Fill(resultado);
                    SqlDataReader leer = comando.ExecuteReader();

                    while (leer.Read())
                    {
                        clases.C_usuarios.cod_usuario = leer[0].ToString();
                        clases.C_usuarios.codigo_grupo = leer[1].ToString();
                        clases.C_usuarios.usuario = leer[2].ToString();
                        clases.C_usuarios.clave = leer[3].ToString();
                        clases.C_usuarios.nombres= leer[4].ToString();

                    }
                    conn.Close();

                    if (resultado.Rows.Count == 1)
                    {
                        llamado = new Form2_pantalla_principalopc();
                        llamado.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o clave incorrecto");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex} ERROR", "MENSAJE DE ERROR", MessageBoxButtons.OK);
                    conn.Close();
                }


            }
            else
            {
                MessageBox.Show("Debes llenar ambos campos", "MENSAJE DE ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
