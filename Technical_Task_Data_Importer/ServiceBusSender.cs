using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;
using System.Configuration;
using CrmEarlyBound;

namespace Technical_Task_Data_Importer
{
    public class ServiceBusSender
    {
        static IQueueClient queueClient;

        public static async Task SendMessage(string contacts)
        {
            string _connectionString = ConfigurationManager.AppSettings["SBConnectionString"];
            string _queueName = ConfigurationManager.AppSettings["SBQueueName"];
            queueClient = new QueueClient(_connectionString, _queueName);

            try
            {
                var message = new Message(Encoding.UTF8.GetBytes(contacts));
                await queueClient.SendAsync(message);
                await queueClient.CloseAsync();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }                     
        }
    }
}
