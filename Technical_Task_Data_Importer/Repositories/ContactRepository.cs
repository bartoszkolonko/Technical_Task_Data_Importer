using CrmEarlyBound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technical_Task_Data_Importer.Entities;
using Technical_Task_Data_Importer.Interfaces;

namespace Technical_Task_Data_Importer.Repositories
{
    public class ContactRepository : IContactRepository
    {
        public Contact PrepareRecord(Lead lead)
        {
            Contact contact = new Contact
            {
                Id = new Guid(),
                FirstName = lead.FirstName,
                LastName = lead.LastName,
                EMailAddress1 = lead.Email,
                GenderCode = new Microsoft.Xrm.Sdk.OptionSetValue((int)lead.Gender),
                Address1_Country = lead.Country,
                BirthDate = DateTime.Today.Date.AddYears(-lead.Age),               
            };

            return contact;
        }
    }
}
