using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ContactManager.Core
{
    public class ContactStore
    {
        private int NextId = 1;
        private Contact[] contacts = new Contact[100];

        public Contact Add(Contact contact)
        {
            contact.Id = NextId++;
            contacts[contact.Id] = contact;
            return contact;
        }
    }
}
