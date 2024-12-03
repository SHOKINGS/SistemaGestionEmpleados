using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SistemaGestionEmpleados
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Spartan\Documents\empleados.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void registrarse_btn_Click(object sender, EventArgs e)
        {
            RegistroFormulario regForm = new RegistroFormulario();
            regForm.Show();
            this.Hide();
        }

        private void inicio_mostrarcontraseña_CheckedChanged(object sender, EventArgs e)
        {
            inicio_contraseña.PasswordChar = inicio_mostrarcontraseña.Checked ? '\0' : '*';
        }

        private void entrar_btn_Click(object sender, EventArgs e)
        {
            if(inicio_nombreusuario.Text == ""
                || inicio_contraseña.Text == "") 
            {
                MessageBox.Show("Por favor, rellene todos los campos en blanco",
                    "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if(connect.State == ConnectionState.Closed) 
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM usuarios WHERE usuario = @usuario " +
                            "AND contraseña = @contraseña";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@usuario", inicio_nombreusuario.Text.Trim());
                            cmd.Parameters.AddWithValue("@contraseña", inicio_contraseña.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count >= 1) 
                            {
                                MessageBox.Show("Acceso Correcto!", "Mensaje informativo", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MainForm mForm = new MainForm();
                                mForm.Show();
                                this.Hide();
                            }
                            else 
                            {
                                MessageBox.Show("Acceso Incorrecto verificar nombre de usuario / contraseña", "Mensaje de error", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex,
                        "Mensjae de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                
            }
        }

        private void inicio_nombreusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
