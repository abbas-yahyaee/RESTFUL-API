using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Models;

namespace Project1.DAL
{
    public interface IContactDataAccessLayer
    {
        IEnumerable<Contact> GetContacts();
        Contact GetContactById(int contactId);
        byte InsertContact(Contact contact);
        byte UpdateContact(Contact contact);
        byte DeleteContact(int contactId);
        void SaveChanges();
    }
}
