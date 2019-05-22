using CrmEarlyBound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technical_Task_Data_Importer.Entities;

namespace Technical_Task_Data_Importer.Interfaces
{
    public interface IContactRepository
    {
        Contact PrepareRecord(Lead lead);
    }
}
