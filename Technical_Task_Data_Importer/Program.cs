using CrmEarlyBound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technical_Task_Data_Importer.Entities;
using Technical_Task_Data_Importer.Interfaces;
using Technical_Task_Data_Importer.Repositories;
using System.Configuration;
using Newtonsoft.Json;

namespace Technical_Task_Data_Importer
{
    public class Program
    {       
        static void Main(string[] args)
        {
            IContactRepository contactRepo = new ContactRepository();          
            List<Lead> leads = JsonRepository.ReadData(ConfigurationManager.AppSettings["ImportFilePath"]);
            List <Contact> contactsToImport = new List<Contact>();
            foreach(var lead in leads)
            {
                Contact contact = contactRepo.PrepareRecord(lead);
                contactsToImport.Add(contact);
            }

            DataImporter di = new DataImporter();
            di.RunImport(contactsToImport);

            //List<Contact> contactsFromUsa = contactsToImport.Where(x => x.Address1_Country == "United States").ToList();
            //string contactJson = JsonConvert.SerializeObject(contactsFromUsa);
            //await ServiceBusSender.SendMessage(contactJson);

            //List<Contact> contactsFromFrance = contactsToImport.Where(x => x.Address1_Country == "France").ToList();
            //EmailSender emailSender = new EmailSender();
            //emailSender.SendEmail(contactsFromFrance);
           
            Console.ReadKey();
        }
    }
}
