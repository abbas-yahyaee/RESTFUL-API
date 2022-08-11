﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Models;

namespace Project1.BusinessLayer
{
    public interface IContactBusinessLayer
    {
        Contact GetContact(int contactId);
        IEnumerable<Contact> GetContacts();
        byte InsertContact(Contact contact);
        byte UpdateContact(Contact contact);
        byte DeleteContact(int contactId);
    }
}
