using CrmEarlyBound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technical_Task_Data_Importer.Entities;
using Technical_Task_Data_Importer.Interfaces;
using Technical_Task_Data_Importer.Repositories;

namespace Technical_Task_Data_Importer
{
    public class Program
    {
        const string ServiceBusConnectionString = "";
        const string QueueName = "";
        

        static void Main(string[] args)
        {
            //Connector connect = new Connector(ServiceBusConnectionString, QueueName);
            IContactRepository contactRepo = new ContactRepository();          
            List<Lead> leads = JsonReader.ReadData(@"test.json");
            List<Contact> contactsToImport = new List<Contact>();
            foreach(var lead in leads)
            {
                Contact contact = contactRepo.PrepareRecord(lead);
                contactsToImport.Add(contact);
            }
        }
    }
}
