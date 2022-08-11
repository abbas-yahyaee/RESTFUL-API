using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project1.DAL;
using Project1.Models;

namespace Project1.BusinessLayer
{
    public class ContactBusinessLayer : IContactBusinessLayer
    {
        private IContactDataAccessLayer _obj;
        public ContactBusinessLayer(IContactDataAccessLayer obj)
        {
            _obj = obj;
        }
        public Contact GetContact(int contactId)
        {
            return _obj.GetContactById(contactId);
        }

        public IEnumerable<Contact> GetContacts()
        {
            return _obj.GetContacts();
        }
       
        public byte DeleteContact(int contactId)
        {
            return _obj.DeleteContact(contactId);
        }

        public byte UpdateContact(Contact contact)
        {
            return _obj.UpdateContact(contact);
        }

        public byte InsertContact(Contact contact)
        {
            return _obj.InsertContact(contact);
        }
    }
}