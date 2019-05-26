using System;
using CrmEarlyBound;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Moq;
using Technical_Task_Data_Importer.Entities;
using Technical_Task_Data_Importer.Repositories;

namespace Technical_Task_Data_Importer.Tests
{
    [TestClass]
    public class ContactTests
    {
        private ContactRepository repo = new ContactRepository();

        [TestMethod]
        public void PrepareRecord_HappyPath_OK()
        {
            Lead leadForTest = new Lead
            {
                No = 1,
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                Email = "test@test.test",
                Age = 26,
                Country = "Poland",
                Gender = Enums.Gender.Male,
                CreationDate = new DateTime(2019, 11, 23),
                Id = "3251"
            };

            Contact contactForTest = repo.PrepareRecord(leadForTest);

            Assert.AreEqual(contactForTest.FirstName, leadForTest.FirstName);
            Assert.AreEqual(contactForTest.GenderCode.Value, 1);

        }       
    }
}
