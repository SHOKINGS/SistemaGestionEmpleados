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
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace SistemaGestionEmpleados
{
    public partial class AddEmpleado : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Spartan\Documents\empleados.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public AddEmpleado()
        {
            InitializeComponent();
            mostrarDatosEmpleados();
        }

        public void RefreshData() 
        {
            if (InvokeRequired) 
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            mostrarDatosEmpleados();
        }

        public void mostrarDatosEmpleados() 
        {
            DatosEmpleados de = new DatosEmpleados();
            List<DatosEmpleados> listData = de.listaDatosEmpleados();

            dataGridView2.DataSource = listData;
        }

        private void AddEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addEmpleado_agregarBtn_Click(object sender, EventArgs e)
        {
            if(addEmpleado_id.Text == ""
                || addEmpleado_nombreCompleto.Text == ""
                || addEmpleado_genero.Text == ""
                || addEmpleado_telefono.Text == ""
                || addEmpleado_cargo.Text == ""
                || addEmpleado_foto.Image == null) 
            {
                MessageBox.Show("Por favor, rellene todos los campos en blanco", "Mensaje de Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if(connect.State == ConnectionState.Closed) 
                {
                    try 
                    {
                        connect.Open();
                        string checkEmID = "SELECT COUNT(*) FROM empleados WHERE empleado_id = @emID AND eliminar_fecha IS NULL";

                        using (SqlCommand chekEm = new SqlCommand(checkEmID, connect)) 
                        {
                            chekEm.Parameters.AddWithValue("@emID", addEmpleado_id.Text.Trim());
                            int count = (int)chekEm.ExecuteScalar();

                            if(count >= 1) 
                            {
                                MessageBox.Show(addEmpleado_id.Text.Trim() + " Ya está tomado", "Mensaje de Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else 
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO empleados " +
                                    "(empleado_id, nombre_completo, genero, cargo, foto, salario, insertar_fecha, telefono)" +
                                    "VALUES(@empleadoID, @nombreCompleto, @genero, @cargo, @foto, @salario, @insertarFecha, @telefono)";


                                string path = Path.Combine(@"C:\Users\Spartan\source\repos\SistemaGestionEmpleados\SistemaGestionEmpleados\Directory\"
                                    + addEmpleado_id.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath)) 
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(addEmpleado_foto.ImageLocation, path, true);

                                using(SqlCommand cmd = new SqlCommand(insertData, connect)) 
                                {
                                    cmd.Parameters.AddWithValue("@empleadoID", addEmpleado_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@nombreCompleto", addEmpleado_nombreCompleto.Text.Trim());
                                    cmd.Parameters.AddWithValue("@genero", addEmpleado_genero.Text.Trim());
                                    cmd.Parameters.AddWithValue("@cargo", addEmpleado_cargo.Text.Trim());
                                    cmd.Parameters.AddWithValue("@foto", path);
                                    cmd.Parameters.AddWithValue("@salario", 0);
                                    cmd.Parameters.AddWithValue("@insertarFecha", today);
                                    cmd.Parameters.AddWithValue("@telefono", addEmpleado_telefono.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    mostrarDatosEmpleados();

                                    MessageBox.Show("Agregado correctamente!", "Mensaje informativo", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show("Error: " + ex, "Mensaje de Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally 
                    {
                        connect.Close();
                    }
                    
                }
            } 
        }

        private void addEmpleado_importarBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Archivo de imagen (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addEmpleado_foto.ImageLocation = imagePath;

                }

            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error: " + ex, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
    
        {
            if(e.RowIndex != -1) 
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                addEmpleado_id.Text = row.Cells[1].Value.ToString();
                addEmpleado_nombreCompleto.Text = row.Cells[2].Value.ToString();
                addEmpleado_genero.Text = row.Cells[3].Value.ToString();
                addEmpleado_cargo.Text = row.Cells[4].Value.ToString();
                addEmpleado_telefono.Text = row.Cells[7].Value.ToString();

                string imagePath = row.Cells[5].Value.ToString();

                if(imagePath != null) 
                {
                    addEmpleado_foto.Image = Image.FromFile(imagePath);
                }
                else 
                {
                    addEmpleado_foto.Image = null;
                }
                
            }
        }

        public void clearFields()
        {
            addEmpleado_id.Text = "";
            addEmpleado_nombreCompleto.Text = "";
            addEmpleado_genero.SelectedIndex = -1;
            addEmpleado_telefono.Text = "";
            addEmpleado_cargo.SelectedIndex = -1;
            addEmpleado_foto.Image = null;

        }

        private void addEmpleado_actualizarBtn_Click(object sender, EventArgs e)

        {
            if (addEmpleado_id.Text == ""
                || addEmpleado_nombreCompleto.Text == ""
                || addEmpleado_genero.Text == ""
                || addEmpleado_telefono.Text == ""
                || addEmpleado_cargo.Text == ""
                || addEmpleado_foto.Image == null)
            {
                MessageBox.Show("Por favor, rellene todos los campos en blanco", "Mensaje de Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Estás seguro que quieres actualizar " + "Empleado ID: " + 
                    addEmpleado_id.Text.Trim() + "?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(check == DialogResult.Yes) 
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE empleados SET nombre_completo = @nombreCompleto, " +
                         "genero = @genero, cargo = @cargo, actualizar_fecha = @actualizarFecha, telefono = @telefono " +
                        "WHERE empleado_id = @empleadoID";


                        using (SqlCommand cmd = new SqlCommand(updateData, connect)) 
                        {
                            cmd.Parameters.AddWithValue("@nombreCompleto", addEmpleado_nombreCompleto.Text.Trim());
                            cmd.Parameters.AddWithValue("@genero", addEmpleado_genero.Text.Trim());
                            cmd.Parameters.AddWithValue("@cargo", addEmpleado_cargo.Text.Trim());
                            cmd.Parameters.AddWithValue("@actualizarFecha", today);
                            cmd.Parameters.AddWithValue("@telefono", addEmpleado_telefono.Text.Trim());
                            cmd.Parameters.AddWithValue("@empleadoID", addEmpleado_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            mostrarDatosEmpleados();

                            MessageBox.Show("Actualizado correctamente!", "Mensaje informativo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Mensaje de Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else 
                {
                    MessageBox.Show("Cancelado.", "Mensaje de información",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void addEmpleado_limpiarBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addEmpleado_eliminarBtn_Click(object sender, EventArgs e)
        {
            if (addEmpleado_id.Text == ""
                || addEmpleado_nombreCompleto.Text == ""
                || addEmpleado_genero.Text == ""
                || addEmpleado_telefono.Text == ""
                || addEmpleado_cargo.Text == ""
                || addEmpleado_foto.Image == null)
            {
                MessageBox.Show("Por favor, rellene todos los campos en blanco", "Mensaje de Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Estás seguro que quieres eliminar " + "Empleado ID: " +
                    addEmpleado_id.Text.Trim() + "?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE empleados SET eliminar_fecha = @eliminarFecha " +
                          "WHERE empleado_id = @empleadoID";



                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            
                            cmd.Parameters.AddWithValue("@eliminarFecha", today);
                            cmd.Parameters.AddWithValue("@empleadoID", addEmpleado_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            mostrarDatosEmpleados();

                            MessageBox.Show("Actualizado correctamente!", "Mensaje informativo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Mensaje de Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelado.", "Mensaje de información",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
    }
}
