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
    public partial class Panel : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Spartan\Documents\empleados.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public Panel()
        {
            InitializeComponent();
            displayET();
            displayEA();
            displayEI();
        }

        public void RefreshData() 
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;

                displayET();
                displayEA();
                displayEI();

            }
        }

        public void displayET()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(id) FROM empleados WHERE eliminar_fecha IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            panel_ET.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Mensaje error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayEA()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(id) FROM empleados WHERE eliminar_fecha IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            panel_EA.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Mensaje error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayEI()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(id) FROM empleados WHERE eliminar_fecha IS NOT NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            panel_EI.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Mensaje error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}