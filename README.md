# Data Importer
Simple data importer for Dynamics 365

# Most important part of project - App.config file

Inside Technical_Task_Data_Importer project there's a App.config file. It is required to set value for parameters shown below:
```
<appSettings>
    <add key="ImportFilePath" value="" />
    <add key="OrganizationServiceUri" value="" />
    <add key="Username" value="" />
    <add key="Password" value="" />
    <add key="SBConnectionString" value="" />
    <add key="SBQueueName" value="" />
</appSettings>
```
where
- ImportFilePath - path to json file with data to import
- OrganizationServiceUri - OrganizationServiceUri to your Dynamics 365 
- Username - login of user on behalf whom records will be imported
- Password - password for login on mentioned above user
- SBConnectionString - connection string for Azure Service Bus
- SBQueueName - queue name on service bus
