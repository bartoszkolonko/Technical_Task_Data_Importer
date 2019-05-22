using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Task_Data_Importer
{
    public class Enums
    {
        public enum Gender
        {
            [EnumMember(Value = "Female")]
            Female = 2,
            [EnumMember(Value = "Male")]
            Male = 1
        }
    }
}
