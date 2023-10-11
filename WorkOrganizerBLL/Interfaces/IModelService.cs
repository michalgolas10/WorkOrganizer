using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkOrganizerDAL.DataModels.BaseEntity;

namespace WorkOrganizerBLL.Interfaces
{
    public interface IModelService
    {
        public void Create();
        public Entity Get(int id);
        public void Delete(int id);
    }
}
