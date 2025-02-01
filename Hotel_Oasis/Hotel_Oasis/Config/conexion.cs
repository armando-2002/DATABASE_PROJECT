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
        public static SqlConnection Conectar()
        {
            //SqlConnection conexion = new  SqlConnection("server=WIN-T0JD7FVAOU7;database=HotelDB;Trusted_Connection=true");
            //conexion.Open();
            ///// SqlConnection conexion = new SqlConnection("server=WIN-T0JD7FVAOU7;database=Hotel_Oasis_Quito;Trusted_Connection=true");
            ////conexion.Open();
            SqlConnection conexion = new SqlConnection("server=WIN-T0JD7FVAOU7;database=Hotel_Quito;Trusted_Connection=true");
            conexion.Open();

            return conexion;
                }


    }
}
