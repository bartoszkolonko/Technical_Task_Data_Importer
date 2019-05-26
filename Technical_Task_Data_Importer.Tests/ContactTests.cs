using System;
using CrmEarlyBound;
using Microsoft.Xrm.Sdk;
using Moq;
using NUnit.Framework;
using Technical_Task_Data_Importer.Entities;
using Technical_Task_Data_Importer.Repositories;

namespace Technical_Task_Data_Importer.Tests
{
    [TestFixture]
    public class ContactTests
    {
        private ContactRepository repo = new ContactRepository();

        [Test]
        public void PrepareRecord_HappyPath_OK()
        {
            Lead leadForTest = new Lead
            {
                No = 1,
                FirstName = "TestFirstName_1",
                LastName = "TestLastName_1",
                Email = "test1@test.test",
                Age = 26,
                Country = "Poland",
                Gender = Enums.Gender.Male,
                CreationDate = new DateTime(2019, 11, 23),
                Id = "1111"
            };

            Contact contactForTest = repo.PrepareRecord(leadForTest);

            Assert.AreEqual(contactForTest.FirstName, leadForTest.FirstName);
            Assert.AreEqual(contactForTest.GenderCode.Value, 1);          
        }   
        
        [Test]
        public void PrepareRecord_ContractSigningIsUnsafe()
        {
            Lead leadForTest = new Lead
            {
                No = 2,
                FirstName = "TestFirstName_2",
                LastName = "TestLastName_2",
                Email = "test@test.test",
                Age = 24,
                Country = "Poland",
                Gender = Enums.Gender.Male,
                CreationDate = new DateTime(2019, 06, 01),
                Id = "2222"
            };

            Contact contactForTest = repo.PrepareRecord(leadForTest);

            Assert.AreEqual(contactForTest.new_riskofsigning.Value, (int)Contact_new_riskofsigning.Unsafe);
        }

        [Test]
        public void PrepareRecord_BirthYearIsCorrect()
        {
            Lead leadForTest = new Lead
            {
                No = 3,
                FirstName = "TestFirstName_3",
                LastName = "TestLastName_3",
                Email = "test@test.test",
                Age = 39,
                Country = "Poland",
                Gender = Enums.Gender.Male,
                CreationDate = new DateTime(2019, 11, 23),
                Id = "3333"
            };

            Contact contactForTest = repo.PrepareRecord(leadForTest);

            Assert.AreEqual(contactForTest.BirthDate.Value.Year, 1980);
        }
    }
}
