using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Test
{
    internal class Program
    {
        public const string connectionString = "Data Source=192.168.56.101;Initial Catalog=CONNECTION;User ID=sa;Password=SqlServer123";
        public static void TestConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Dispose();

            try
            {
                using(SqlCommand cmd = new SqlCommand(connectionString))
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
        }
        static void Main(string[] args)
        {
            TestConnection();
        }
    }
}