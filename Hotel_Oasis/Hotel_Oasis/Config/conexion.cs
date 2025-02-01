using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Oasis.Config
{
    class conexion
    {
        private static string connectionString = "Server=26.2.41.132;Database=Hotel_Quito;Trusted_Connection=true";


        public static SqlConnection Conectar()
        {
            ////SqlConnection conexion = new  SqlConnection("server=WIN-T0JD7FVAOU7;database=HotelDB;Trusted_Connection=true");
            ////conexion.Open();
            /////// SqlConnection conexion = new SqlConnection("server=WIN-T0JD7FVAOU7;database=Hotel_Oasis_Quito;Trusted_Connection=true");
            //////conexion.Open();
            //SqlConnection conexion = new SqlConnection("server=WIN-T0JD7FVAOU7;database=Hotel_Quito;Trusted_Connection=true");
            //conexion.Open();

            //return conexion;
            SqlConnection conexion = new SqlConnection(connectionString);

            try
            {
                conexion.Open(); // Intenta abrir la conexión
                Console.WriteLine("Conexión exitosa!");
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar: " + ex.Message);
                return null; // Devuelve null si hay un error
            }
        }


    }
}
