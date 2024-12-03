using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SistemaGestionEmpleados
{
    internal class DatosSalario
    {

        public string EmpleadoID { get; set; }//0
        public string NombreCompleto { get; set; }//1
        public string Genero {  get; set; } //2
        public string Cargo { get; set; }//3
        public int Salario { get; set; }//4
        public string Telefono { get; set; } //5


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Spartan\Documents\empleados.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public List<DatosSalario> salariolistaDatosEmpleados()
        {
            List<DatosSalario> lisdata = new List<DatosSalario>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM empleados WHERE eliminar_fecha IS NULL ";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DatosSalario ds = new DatosSalario();
                            ds.EmpleadoID = reader["empleado_id"].ToString();
                            ds.NombreCompleto = reader["nombre_completo"].ToString();
                            ds.Genero = reader["genero"].ToString();
                            ds.Cargo = reader["cargo"].ToString();
                            ds.Salario = (int)reader["salario"];
                            ds.Telefono = reader["telefono"].ToString();

                            lisdata.Add(ds);

                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return lisdata;
        }
    }
}
