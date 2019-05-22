using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Technical_Task_Data_Importer.Entities;
using System.IO;

namespace Technical_Task_Data_Importer
{
    public class JsonReader
    {
       public static List<Lead> ReadData(string pathToFile)
        {
            List<Lead> importData = new List<Lead>();
            using (StreamReader r = new StreamReader(pathToFile))
            {
                string json = r.ReadToEnd();
                importData = JsonConvert.DeserializeObject<List<Lead>>(json, new JsonSerializerSettings
                {
                    DateFormatString = "dd.MM.yyyy"
                });
            }
            return importData;
        }
    }
}
