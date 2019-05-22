using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Technical_Task_Data_Importer.Enums;

namespace Technical_Task_Data_Importer.Entities
{
    public class Lead
    {
        public int No { get; set; }

        [JsonProperty(PropertyName = "First Name")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Gender Gender { get; set; }

        public string Country { get; set; }

        public int Age { get; set; }

        [JsonProperty(PropertyName = "Creation Date")]
        public DateTime CreationDate { get; set; }

        public string Id { get; set; }
    }
}
