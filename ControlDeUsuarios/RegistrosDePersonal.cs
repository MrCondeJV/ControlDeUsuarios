using MySql.Data.MySqlClient;
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

namespace ControlDeUsuarios
{
    public partial class RegistrosDePersonal : Form
    {
        MySqlConnection myCon;
        Trabajador trabajador;
        public RegistrosDePersonal()
        {
            InitializeComponent();
            conectar();
            llenarTabla();
        }

        private void RegistrosDePersonal_Load(object sender, EventArgs e)
        {

        }

        private void conectar()
        {
            try
            {
                String server = "localhost";
                String database = "registrosacceso";
                String user = "root";
                String pwd = "";
                String cadenaConexion = "server=" + server + ";database=" + database + ";" + "Uid=" + user + ";pwd=" + pwd;
                myCon = new MySqlConnection(cadenaConexion);
                myCon.Open();
               
            }
            catch (Exception error)
            {
                MessageBox.Show("Error de Conexion: " + error);
            }
        }


       
        //Mostrando Datos

        private void llenarTabla()
        {
            
            String query = "select id,Nombre,Apellido,FechaEntrada,FechaSalida,UIDTargeta from datos;";
            MySqlCommand comandoDB = new MySqlCommand(query, myCon);
            comandoDB.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = comandoDB.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = dgvTabla.Rows.Add();
                        dgvTabla.Rows[n].Cells[0].Value = reader.GetString(0);
                        dgvTabla.Rows[n].Cells[1].Value = reader.GetString(1);
                        dgvTabla.Rows[n].Cells[2].Value = reader.GetString(2);
                        dgvTabla.Rows[n].Cells[3].Value = reader.GetString(3);
                        dgvTabla.Rows[n].Cells[4].Value = reader.GetString(4);
                        dgvTabla.Rows[n].Cells[5].Value = reader.GetString(5);
                         
                    }
                }
                else
                {
                    Console.WriteLine("No hay registros");
                }
                reader.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenarTabla();

        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            String where = "where 1=1";
            if (txtBuscarID.Text != "")
            {
                where = where + " and id like'%" + txtBuscarID.Text + "%' ";
            }
            if (txtBuscarNombre.Text != "")
            {
                where = where + " and nombre like'%" + txtBuscarNombre.Text + "%' ";
            }
            if (txtBuscarApellido.Text != "")
            {
                where = where + " and ph like'%" + txtBuscarUID.Text + "%' ";
            }

            String query = "select id,Nombre,Apellido,FechaEntrada,FechaSalida,UIDTargeta from datos " + where;
            MySqlCommand comandoBD = new MySqlCommand(query, myCon);
            comandoBD.CommandTimeout = 60;
            MySqlDataReader reader;
            dgvTabla.Rows.Clear();
            dgvTabla.Refresh();
            try
            {
                reader = comandoBD.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = dgvTabla.Rows.Add();
                        dgvTabla.Rows[n].Cells[0].Value = reader.GetString(0);
                        dgvTabla.Rows[n].Cells[1].Value = reader.GetString(1);
                        dgvTabla.Rows[n].Cells[2].Value = reader.GetString(2);
                        dgvTabla.Rows[n].Cells[3].Value = reader.GetString(3);
                        dgvTabla.Rows[n].Cells[4].Value = reader.GetString(4);
                        dgvTabla.Rows[n].Cells[5].Value = reader.GetString(5);
                    }
                }
                else
                {
                    Console.WriteLine("NO hay trabajadores");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
