using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkOrganizerDAL.DataModels.BaseEntity;

namespace WorkOrganizerDAL.DataModels
{
    public class Worker : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int WorkerNumber { get; set; }
    }
}
