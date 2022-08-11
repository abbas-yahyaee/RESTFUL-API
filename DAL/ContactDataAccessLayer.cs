using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project1.Models;

namespace Project1.DAL
{
    public class ContactDataAccessLayer : IContactDataAccessLayer
    {

        public byte DeleteContact(int contactId)
        {
            return 1; // Dummy Result
        }
        public Contact GetContactById(int contactId)
        {
            //Dummy Data
            return new Contact
            {
                Id = 1,
                FirstName = "name1",
                MiddleName = "middlename1",
                LastName = "family1",
            };
        }
        public IEnumerable<Contact> GetContacts()
        {
            //Dummy Data
            return new[] {
                new Contact { Id = 1,
                FirstName = "name1",
                MiddleName = "middlename1",
                LastName = "family1", }
                ,
                new Contact { Id = 2,
                FirstName = "name2",
                MiddleName = "middlename2",
                LastName = "family2", }
                ,
                new Contact { Id = 3,
                FirstName = "name3",
                MiddleName = "middlename3",
                LastName = "family3", }


                };
        }
        public byte InsertContact(Contact contact)
        {
            return 1; // Dummy Result
        }

        public void SaveChanges()
        {
        }

        public byte UpdateContact(Contact contact)
        {
            return 1; // Dummy Result
        }

    }
}