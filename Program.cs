using Address_Book_System_ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookAdv
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookManagement addressBookManagement = new AddressBookManagement();


            AddressBookModel model = new AddressBookModel();
            model.FirstName = "Sangmeshwar";
            model.LastName = "Patil";
            model.Address = "Latur";
            model.City = "Udgir";
            model.State = "Maharashtra";
            model.Zip = 413517;
            model.PhoneNumber = 2635145678;
            model.EmailId = "patil@gmail.com";
            model.AddressBookType = "Contact";
            model.AddressBookName = "AddressBook";
            bool res = addressBookManagement.AddDataToTable(model);

            Console.WriteLine(res);



            Console.ReadLine();
        }

    }

}