using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkOrganizerDAL.DataModels.BaseEntity;
using WorkOrganizerDAL.Enums;

namespace WorkOrganizerDAL.DataModels
{
    public class Shift : Entity
    {
        public ShiftEnum ShiftEnum { get; set; }
        public List<Worker> Workers { get; set; }
        public List<Order> Orders { get; set; }
    }
}
