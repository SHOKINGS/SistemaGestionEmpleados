using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SistemaGestionEmpleados
{
    internal class DatosEmpleados

    {
        public int ID { get; set; }//0
        public string EmpleadoID { get; set; }//1
        public string NombreCompleto { get; set; }//2
        public string Genero { get; set; }//3
        public string Cargo { get; set; }//4
        public string Foto { get; set; }//5
        public int Salario { get; set; }//6
        public string Telefono { get; set; }//7
        
        



        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Spartan\Documents\empleados.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public List<DatosEmpleados>	listaDatosEmpleados() 
        {
            List<DatosEmpleados> lisdata = new List<DatosEmpleados>();

            if(connect.State != ConnectionState.Open) 
            {
                try 
                {
                    connect.Open();

                    string selectData = "SELECT * FROM empleados WHERE eliminar_fecha IS NULL ";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect)) 
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read()) 
                        {
                            DatosEmpleados de = new DatosEmpleados();
                            de.ID = (int)reader["id"];
                            de.EmpleadoID = reader["empleado_id"].ToString();
                            de.NombreCompleto = reader["nombre_completo"].ToString();
                            de.Genero = reader["genero"].ToString();
                            de.Cargo = reader["cargo"].ToString();
                            de.Foto = reader["foto"].ToString();
                            de.Salario = (int)reader["salario"];
                            de.Telefono = reader["telefono"].ToString();
                            
                          
                            lisdata.Add(de);

                        }
                    }

                }catch(Exception ex) 
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

        public List<DatosEmpleados> salariolistaDatosEmpleados()
        {
            List<DatosEmpleados> lisdata = new List<DatosEmpleados>();

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
                            DatosEmpleados de = new DatosEmpleados();
                            de.EmpleadoID = reader["empleado_id"].ToString();
                            de.NombreCompleto = reader["nombre_completo"].ToString();
                            de.Cargo = reader["cargo"].ToString();
                            de.Salario = (int)reader["salario"];

                            lisdata.Add(de);

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
