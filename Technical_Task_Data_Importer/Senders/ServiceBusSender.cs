using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;
using System.Configuration;
using CrmEarlyBound;
using NLog;

namespace Technical_Task_Data_Importer
{
    public class ServiceBusSender
    {
        static IQueueClient queueClient;        

        public async void Runner(string contacts)
        {
            SendMessage(contacts).GetAwaiter().GetResult();
        }

        static async Task SendMessage(string contacts)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            string connectionString = ConfigurationManager.AppSettings["SBConnectionString"];
            string queueName = ConfigurationManager.AppSettings["SBQueueName"];

            queueClient = new QueueClient(connectionString, queueName);

            try
            {
                logger.Info("Starting sending data to Service Bus");

                var message = new Message(Encoding.UTF8.GetBytes(contacts));

                await queueClient.SendAsync(message);
                logger.Info("Data has been sent to Service Bus");

                await queueClient.CloseAsync();
            }
            catch(Exception e)
            {
                logger.Error(e.Message);
            }                     
        }
    }
}
