using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOrganizerDAL.DataModels.BaseEntity
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime WhenCreated { get; set; } = DateTime.Now;
    }
}
