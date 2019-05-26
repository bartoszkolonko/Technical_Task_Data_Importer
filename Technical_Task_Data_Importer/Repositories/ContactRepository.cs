using CrmEarlyBound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technical_Task_Data_Importer.Entities;
using Technical_Task_Data_Importer.Interfaces;
using Microsoft.Xrm.Sdk;

namespace Technical_Task_Data_Importer.Repositories
{
    public class ContactRepository : IContactRepository
    {
        public Contact PrepareRecord(Lead lead)
        {
            OptionSetValue riskinessOfSigning;

            if(lead.Age < 25 || lead.Age > 50)
            {
                riskinessOfSigning = new OptionSetValue((int)Contact_new_riskofsigning.Unsafe);
            }
            else
            {
                riskinessOfSigning = new OptionSetValue((int)Contact_new_riskofsigning.Safe);
            }

            Contact contact = new Contact
            {
                ContactId = Guid.NewGuid(),                
                FirstName = lead.FirstName,
                LastName = lead.LastName,
                EMailAddress1 = lead.Email,
                GenderCode = new OptionSetValue((int)lead.Gender),
                Address1_Country = lead.Country,
                BirthDate = DateTime.Today.Date.AddYears(-lead.Age),  
                new_riskofsigning = riskinessOfSigning
            };

            return contact;
        }
    }
}
