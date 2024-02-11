using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ControlDeUsuarios
{
    public partial class UsuariosLista : Form
    {
        Trabajador trabajador;
        MySqlConnection myCon;
        String idT = "";
        String nombreT = "";
        String apellidoT = "";
        String uidT = "";
        public UsuariosLista()
        {
            InitializeComponent();
            conectar();
            llenarTabla();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUIDTargeta_TextChanged(object sender, EventArgs e)
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
        private void llenarTabla()
        {

            String query = "select id,nombre,apellido,uid from trabajador;";
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
                        int n = dgvDatos.Rows.Add();
                        dgvDatos.Rows[n].Cells[0].Value = reader.GetString(0);
                        dgvDatos.Rows[n].Cells[1].Value = reader.GetString(1);
                        dgvDatos.Rows[n].Cells[2].Value = reader.GetString(2);
                        dgvDatos.Rows[n].Cells[3].Value = reader.GetString(3);
                       

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

        private Boolean existe(String buscar)
        {
            Boolean existe = false;

            for (int i = 0; i<= dgvDatos.Rows.Count; i++)
            {
                if (buscar.Equals(dgvDatos.Rows[i].Cells[0].Value.ToString()))
                {
                    existe = true;
                }
            }

            return existe;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
             idT = txtIDTrabajador.Text;
              nombreT = txtNombreTrabajador.Text;
             apellidoT = txtApellidoTrabajador.Text;
              uidT = txtUIDTargeta.Text;
            

            String query = "";

            if (txtIDTrabajador.Text ==""|| txtNombreTrabajador.Text == "" || txtApellidoTrabajador.Text == "" || txtApellidoTrabajador.Text == "" || txtUIDTargeta.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacios!!");
            } else
            {
                if (MessageBox.Show("Quiere agregar el Trabajador?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    query = "insert into trabajador " +
                    "(id,nombre,apellido,uid) values " +
                       "('"+ idT +"','" + nombreT + "','" + apellidoT + "','" + uidT + "')";
                    MySqlCommand comando = new MySqlCommand(query, myCon);
                    comando.CommandTimeout = 60;
                    MySqlDataReader reader;
                    try
                    {
                        reader = comando.ExecuteReader();
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    MessageBox.Show("Agregado con Exito!!");
                    dgvDatos.Rows.Clear();
                    dgvDatos.Refresh();
                    llenarTabla();

                    txtIDTrabajador.Text = "";
                    txtNombreTrabajador.Text = "";
                    txtApellidoTrabajador.Text = "";
                    txtUIDTargeta.Text = "";
                }


            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           

            String query = "";

            if (txtNombreTrabajador.Text == "" || txtApellidoTrabajador.Text == "" || txtApellidoTrabajador.Text == "" || txtUIDTargeta.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacios!!");
            }
            else
            {
                idT = txtIDTrabajador.Text;
                nombreT = txtNombreTrabajador.Text;
                apellidoT = txtApellidoTrabajador.Text;
                uidT = txtUIDTargeta.Text;

                if (MessageBox.Show("Quiere modificar los datos del trabajador?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    query = "update trabajador set nombre = '"+nombreT+"',apellido ='"+apellidoT+"',uid ='"+uidT+"' WHERE trabajador.id ='"+idT+"' ";

                    //UPDATE `trabajador` SET `uid` = 'aaaah' WHERE `trabajador`.`id` = 'dsfs';
                    MySqlCommand comando = new MySqlCommand(query, myCon);
                    comando.CommandTimeout = 60;
                    MySqlDataReader reader;
                    try
                    {
                        reader = comando.ExecuteReader();
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    MessageBox.Show("Modificado con Exito!!");
                    
                    dgvDatos.Rows.Clear();
                    dgvDatos.Refresh();
                    llenarTabla();

                    txtIDTrabajador.Text = "";
                    txtNombreTrabajador.Text = "";
                    txtApellidoTrabajador.Text = "";
                    txtUIDTargeta.Text = "";
                }

                
            }
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDTrabajador.Text = dgvDatos.SelectedRows[0].Cells[0].Value.ToString();
                txtNombreTrabajador.Text = dgvDatos.SelectedRows[0].Cells[1].Value.ToString();
                txtApellidoTrabajador.Text = dgvDatos.SelectedRows[0].Cells[2].Value.ToString();
                txtUIDTargeta.Text = dgvDatos.SelectedRows[0].Cells[3].Value.ToString();

                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
               
            }
            catch(Exception ) {
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String query = "";

            if (txtNombreTrabajador.Text == "" || txtApellidoTrabajador.Text == "" || txtApellidoTrabajador.Text == "" || txtUIDTargeta.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacios!!");
            }
            else
            {
                idT = txtIDTrabajador.Text;
                nombreT = txtNombreTrabajador.Text;
                apellidoT = txtApellidoTrabajador.Text;
                uidT = txtUIDTargeta.Text;

                if (MessageBox.Show("Quiere ELIMINAR los datos del trabajador?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    query = "delete from trabajador  WHERE trabajador.id =  + '"+idT+"'";

                    //"DELETE FROM trabajador WHERE `trabajador`.`id` = 'dsf'"
                    MySqlCommand comando = new MySqlCommand(query, myCon);
                    comando.CommandTimeout = 60;
                    MySqlDataReader reader;
                    try
                    {
                        reader = comando.ExecuteReader();
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    MessageBox.Show("Eliminado con Exito!!");

                    dgvDatos.Rows.Clear();
                    dgvDatos.Refresh();
                    llenarTabla();

                    txtIDTrabajador.Text = "";
                    txtNombreTrabajador.Text = "";
                    txtApellidoTrabajador.Text = "";
                    txtUIDTargeta.Text = "";
                }


            }
        }
    }
}
