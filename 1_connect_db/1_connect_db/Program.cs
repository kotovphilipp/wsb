using System;
using System.Data.SqlClient;

namespace _1_connect_db
{
    class Program
    {
        static void Main(string[] args)
        {
            string sql;
            SqlDataReader read = null;

            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS; Initial Catalog=komis; Integrated Security=true");

            try
            {
                conn.Open();
                Console.WriteLine("Prawidlowe polaczenie z baza danych komis\n");

                sql = "select * from [user]";
                SqlCommand result = new SqlCommand(sql, conn);

                read = result.ExecuteReader();


                while (read.Read())
                {

                    Console.WriteLine("Imie: {0}, nazwisko: {1}", read[1], read [2]);
                }

            }
            catch (SqlException e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
