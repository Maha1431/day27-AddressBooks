using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook address = new AddressBook();
            bool value = false;
            int options;
            while (!value)
            {
                Console.WriteLine("\n1.CreateContacts\n 2.DisplayContact \n 3.EditContacts\n4.Delete Contacts\n5. MultiContacts Addition\n 6. Display AddressBookInDictionary ");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        address.CreateContacts();
                        break;
                    case 2:
                        address.DisplayContact();
                        break;
                    case 3:
                        address.EditContact();
                        break;
                    case 4:
                        address.DeleteContacts();
                        break;
                    case 5:
                        address.AddMultiContacts(2);
                        break;
                    case 6:
                        address.AddressBookInDictionary();
                        break;
                    case 7:
                        address.ReadAllLines();
                        break;
                    case 8:
                        address.WriteToFile();
                        break;
                    case 9:
                        address.ImplementCSVDataHandling();
                        break;
                    case 10:
                        address.ImplementCsvtoJSON();
                        break;
                   default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
        }

    }
}