using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkOrganizerDAL.DataModels.BaseEntity;

namespace WorkOrganizerDAL.DataModels
{
    public class Order : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime WhenFinished { get; set; }
        public int NumberOfWorkingHoursNeeded { get; set; }
    }
}
