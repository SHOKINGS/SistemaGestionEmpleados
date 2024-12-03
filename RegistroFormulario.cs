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
    public partial class RegistroFormulario : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Spartan\Documents\empleados.mdf;Integrated Security=True;Connect Timeout=30");
        public RegistroFormulario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void registro_mostrarcontraseña_CheckedChanged(object sender, EventArgs e)
        {
            registro_contraseña.PasswordChar = registro_mostrarcontraseña.Checked ? '\0' : '*';
        }

        private void registrar_btn_Click(object sender, EventArgs e)
        {
            if(registro_usuario.Text == ""
                || registro_contraseña.Text == "") 
            {
                MessageBox.Show("Por favor, rellene todos los campos en blanco",
                    "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if(connect.State != ConnectionState.Open) 
                {
                    try 
                    {
                        connect.Open();

                        string selectUsuario = "SELECT COUNT(id) FROM usuarios WHERE usuario = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsuario, connect)) 
                        {
                            checkUser.Parameters.AddWithValue("@user", registro_usuario.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if(count >= 1) 
                            {
                                MessageBox.Show(registro_usuario.Text.Trim() + "ya está tomado",
                    "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else 
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO usuarios" +
                                    "(usuario, contraseña, date_register) " +
                                    "VALUES(@usuario, @contraseña, @dateReg)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usuario", registro_usuario.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contraseña", registro_contraseña.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registro Exitoso!", "Mensaje Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }

                           

                    }catch (Exception ex)
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
    }
}
