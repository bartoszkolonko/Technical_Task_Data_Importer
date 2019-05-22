using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;

namespace Technical_Task_Data_Importer
{
    public class Connector
    {
        private string _connectionString;
        private string _queueName;
        static IQueueClient queueClient;

        public Connector(string connectionString, string queueName)
        {
            _connectionString = connectionString;
            _queueName = queueName;
        }

        public void CreateConnection()
        {
            queueClient = new QueueClient(_connectionString, _queueName);
        }
    }
}
