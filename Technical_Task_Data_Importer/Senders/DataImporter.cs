using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;
using System.ServiceModel.Description;
using CrmEarlyBound;
using System.Configuration;
using NLog;

namespace Technical_Task_Data_Importer
{
    public class DataImporter
    {
        private Logger logger = LogManager.GetCurrentClassLogger();

        public void RunImport(List<Contact> listOfContacts)
        {                   
            OrganizationServiceProxy _serviceProxy;
            Uri uri = new Uri(ConfigurationManager.AppSettings["OrganizationServiceUri"]);
            ClientCredentials credentials = new ClientCredentials();
            credentials.UserName.UserName = ConfigurationManager.AppSettings["Username"];
            credentials.UserName.Password = ConfigurationManager.AppSettings["Password"];

            try
            {
                using (_serviceProxy = new OrganizationServiceProxy(uri, null, credentials, null))
                {
                    _serviceProxy.EnableProxyTypes();

                    foreach(var contact in listOfContacts)
                    {
                        _serviceProxy.Create(contact);
                        logger.Info("Created contact with guid {0}", contact.Id);
                    }
                }
            }
            catch(Exception e)
            {
                logger.Error(e.Message);
            }
        }
    }
}
