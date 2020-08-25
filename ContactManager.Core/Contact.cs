using System;
using System.Collections.Generic;
using System.Text;

namespace ContactManager.Core
{
    public class Contact
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }
    }
}
