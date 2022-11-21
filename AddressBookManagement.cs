using System;
using System.Collections.Generic;
using System.Data;
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
        public void GetAllContact()
        {
            AddressBookModel model = new AddressBookModel();
            try
            {
                using (connection)
                {

                    string query = "select * from AddressBook";

                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {


                        while (reader.Read())
                        {

                            model.FirstName = reader.GetString(0);
                            model.LastName = reader.GetString(1);
                            model.Address = reader.GetString(2);
                            model.City = reader.GetString(3);
                            model.State = reader.GetString(4);
                            model.Zip = reader.GetInt32(5);
                            model.PhoneNumber = reader.GetInt64(6);
                            model.EmailId = reader.GetString(7);
                            model.AddressBookType = reader.GetString(8);
                            model.AddressBookName = reader.GetString(9);

                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", model.FirstName, model.LastName,
                                model.Address, model.City, model.State, model.Zip, model.PhoneNumber, model.EmailId, model.AddressBookType, model.AddressBookName);
                            Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Records Found Address Book System Table");
                    }
                    reader.Close();
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {

                connection.Close();
            }

        }
        public bool AddDataToTable(AddressBookModel model)
        {
            try
            {

                using (connection)
                {

                    SqlCommand command = new SqlCommand("AddAddressDetails", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", model.FirstName);
                    command.Parameters.AddWithValue("@LastName", model.LastName);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@City", model.City);
                    command.Parameters.AddWithValue("@State", model.State);
                    command.Parameters.AddWithValue("@Zip", model.Zip);
                    command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    command.Parameters.AddWithValue("@EmailID", model.EmailId);
                    command.Parameters.AddWithValue("@addressBookType", model.AddressBookType);
                    command.Parameters.AddWithValue("@addressBookName", model.AddressBookName);

                    connection.Open();
                    var result = command.ExecuteNonQuery();


                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}