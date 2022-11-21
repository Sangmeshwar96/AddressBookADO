using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System_ADO
{
    class AddressBookManagement
    {
        
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AddressBookServiceDB;Integrated Security=true;";
         
        SqlConnection connection = new SqlConnection(connectionString);

        public void DataBaseConnection()
        {
            try
            {
 
                DateTime now = DateTime.Now;

                connection.Open();

                using (connection)
                {

                    Console.WriteLine("Connection is created Successful. ");
                }
 
                connection.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}