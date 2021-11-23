using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_23_Assignment
{
    public class ContactPerson
    {
        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public string Email;
        public string State;
        public string City;
        public string Address;
        public string Zip;

        public List<ContactPerson> addressBookList = new List<ContactPerson>();
        public Dictionary<string, ContactPerson> AddressBook = new Dictionary<string, ContactPerson>();
        public Dictionary<string, ContactPerson> CityAddressBook = new Dictionary<string, ContactPerson>();
        public Dictionary<string, ContactPerson> StateAddressBook = new Dictionary<string, ContactPerson>();

        public ContactPerson(string firstName, string lastName, string state, string city, string address, string zip, string phoneNumber, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.State = state;
            this.City = city;
            this.Address = address;
            this.Zip = zip;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }
        public void AddContact(ContactPerson contactPerson)
        {
            addressBookList.Add(contactPerson);
            AddressBook.Add(contactPerson.FirstName, contactPerson);
            CityAddressBook.Add(contactPerson.FirstName, contactPerson);
            StateAddressBook.Add(contactPerson.FirstName, contactPerson);
        }
        public void EditContact(ContactPerson contactPerson)
        {
            Console.WriteLine("Please select following options to change\n");
            Console.WriteLine(" 1.First Name \n 2.Last Name \n 3.Phone Number \n 4.Email \n");
            int chooseOption = Convert.ToInt32(Console.ReadLine());
            switch (chooseOption)
            {
                case 1:
                    Console.WriteLine("Please enter first name");
                    contactPerson.FirstName = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Please enter last name");
                    contactPerson.LastName = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Please enter phone number");
                    contactPerson.PhoneNumber = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Please enter email");
                    contactPerson.Email = Console.ReadLine();
                    break;
            }
        }
        public void DeleteContact()
        {
            string Delete;
            do
            {
                Console.WriteLine("Would you like to delete a contact (Y/N)");
                Delete = Convert.ToString(Console.ReadLine());
                if (Delete.ToUpper() == "Y")
                {
                    Console.WriteLine("Enter contact first name");
                    string firstName = Convert.ToString(Console.ReadLine());
                    var findContact = addressBookList.Find(x => x.FirstName == firstName);
                    if (findContact != null)
                    {
                        addressBookList.Remove(findContact);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }

            } while (Delete.ToUpper() == "Y");
        }
        public void DisplayAddressBook()
        {
            Console.WriteLine("Your Address Book Contact list are :\n");

            foreach (ContactPerson contactlist in addressBookList)
            {
                Console.WriteLine(" {0}\n {1}\n {2}\n {3}\n {4}\n {5}\n {6}\n {7}\n",
                    contactlist.FirstName, contactlist.LastName, contactlist.State, contactlist.
                    City, contactlist.Address, contactlist.Zip, contactlist.PhoneNumber, contactlist.Email);
            }
        }
    }
}