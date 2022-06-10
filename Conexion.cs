using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace EjemplosCapacitacion
{
    public static class Conexion
    {
        public static int conf;
        public static DataSet ds = new DataSet();
        public static string s = "Server=DANIELLOPEZ\\PCDANIEL; DataBase= Northwind; Integrated Security=True";
        public static SqlConnection conexion = new SqlConnection(s);
        public static SqlCommand comando = new SqlCommand();
        public static SqlDataAdapter sqlDA = new SqlDataAdapter();


        static Conexion()
        {
            //CÓDIGO DEL CONSTRUCTOR
            comando.Connection = conexion;
        }

        public static Tuple<int, DataSet> transacBD(string query, Boolean select)
        {
            DataSet dss = new DataSet();

            if (select == true)
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = query;
                sqlDA.SelectCommand = comando;
                conf = sqlDA.Fill(dss);
                return Tuple.Create(conf, dss);
            }
            else
            {
                conexion.Open();
                comando.CommandText = query;
                conf = comando.ExecuteNonQuery();
                conexion.Close();
                return Tuple.Create(conf, dss);
            }
        }

    }
}
