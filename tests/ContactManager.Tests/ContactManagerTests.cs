using System;
using Xunit;
using ContactManager.Core;

namespace ContactManager.Tests
{
    public class ContactManagerTests
    {
        [Fact]
        public void Should_Be_Able_to_Add_Contact()
        {
            ContactStore manager = new ContactStore();
            var contact = manager.Add(new Contact { FirstName = "satish", LastName = "V" });
            Assert.Equal(1, contact.Id);
        }
    }
}
