using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ServiceModel.Description;
using CrmEarlyBound;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using NLog;

namespace Technical_Task_Data_Importer
{
    public class EmailSender
    {
        OrganizationServiceProxy _serviceProxy;
        Logger logger = LogManager.GetCurrentClassLogger();

        public void SendEmail(List<Contact> contacts)
        {           
            Uri uri = new Uri(ConfigurationManager.AppSettings["OrganizationServiceUri"]);
            ClientCredentials credentials = new ClientCredentials();
            credentials.UserName.UserName = ConfigurationManager.AppSettings["Username"];
            credentials.UserName.Password = ConfigurationManager.AppSettings["Password"];

            try
            {
                using (_serviceProxy = new OrganizationServiceProxy(uri, null, credentials, null))
                {
                    _serviceProxy.EnableProxyTypes();


                    foreach(var contact in contacts)
                    {
                        Guid emailId = PrepareEmail(contact);
                        SendEmailRequest sendEmailreq = new SendEmailRequest
                        {
                            EmailId = emailId,
                            TrackingToken = "",
                            IssueSend = true
                        };
                        SendEmailResponse sendEmailresp = (SendEmailResponse)_serviceProxy.Execute(sendEmailreq);
                        logger.Info("Email with GUID: {0} has been sent", emailId);
                    }                                      
                }
            }
            catch(Exception e)
            {
                logger.Error(e.Message);
            }
        }

        private Guid PrepareEmail(Contact contact)
        {
            Guid emailId = new Guid();

            try
            {               
                WhoAmIRequest systemUserRequest = new WhoAmIRequest();
                WhoAmIResponse systemUserResponse = (WhoAmIResponse)_serviceProxy.Execute(systemUserRequest);
                Guid userId = systemUserResponse.UserId;

                ActivityParty fromParty = new ActivityParty
                {
                    PartyId = new EntityReference(SystemUser.EntityLogicalName, userId)
                };

                ActivityParty toParty = new ActivityParty
                {
                    PartyId = new EntityReference(Contact.EntityLogicalName, (Guid)contact.ContactId)
                };

                Email email = new Email
                {
                    To = new ActivityParty[] { toParty },
                    From = new ActivityParty[] { fromParty },
                    Subject = "Thank you",
                    Description = "Thank you",
                    DirectionCode = true
                };
                emailId = _serviceProxy.Create(email);

                logger.Info("Email with GUID: {0} has been created", emailId);               
            }
            catch(Exception e)
            {
                logger.Error(e.Message);                
            }

            return emailId;
        }
    }
}
