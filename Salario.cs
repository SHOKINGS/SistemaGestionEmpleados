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
    public partial class Salario : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Spartan\Documents\empleados.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public Salario()
        {
            InitializeComponent();

            mostrarEmpleados();
            disableFields();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            mostrarEmpleados();
            disableFields();
        }

        public void disableFields()
        {
            salario_empleadoID.Enabled = false;
            salario_nombre.Enabled = false;
            salario_cargo.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void salario_limpiarBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void mostrarEmpleados()
        {
            DatosSalario de = new DatosSalario();
            List<DatosSalario> listData = de.salariolistaDatosEmpleados();

            dataGridView2.DataSource = listData;
        }

        private void salario_actualizarBtn_Click(object sender, EventArgs e)
        {
            if (salario_empleadoID.Text == ""
                || salario_nombre.Text == ""
                || salario_cargo.Text == ""
                || salario_salario.Text == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos en blanco", "Mensaje de Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Estás seguro que quieres ACTUALIZAR a Empleado ID: "
                    + salario_empleadoID.Text.Trim() + "?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string actualizarDatos = "UPDATE empleados SET salario = @salario, actualizar_fecha = @actualizarFecha WHERE empleado_id = @empleadoID";

                            using (SqlCommand cmd = new SqlCommand(actualizarDatos, connect))
                            {
                                // Asegurarse de convertir salario_salario.Text a tipo numérico antes de pasarlo al SQL
                                cmd.Parameters.AddWithValue("@salario", Convert.ToInt32(salario_salario.Text.Trim()));
                                cmd.Parameters.AddWithValue("@actualizarFecha", today); // Corregido el parámetro a 'actualizarFecha'
                                cmd.Parameters.AddWithValue("@empleadoID", salario_empleadoID.Text.Trim());

                                cmd.ExecuteNonQuery();

                                mostrarEmpleados();

                                MessageBox.Show("Actualización exitosa!", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Cancelado", "Mensaje de información"
                            , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cancelado", "Mensaje de información"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void clearFields()
        {
            salario_empleadoID.Text = "";
            salario_nombre.Text = "";
            salario_cargo.Text = "";
            salario_salario.Text = "";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegurarse de que la fila seleccionada sea válida y que no sea el encabezado
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // Comprobar si las celdas existen antes de acceder a ellas
                if (row.Cells.Count > 0)
                {
                    salario_empleadoID.Text = row.Cells[0].Value.ToString();
                    salario_nombre.Text = row.Cells[1].Value.ToString();
                    salario_cargo.Text = row.Cells[3].Value.ToString();
                    salario_salario.Text = row.Cells[4].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
