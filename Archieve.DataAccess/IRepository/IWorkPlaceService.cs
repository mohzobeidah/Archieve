using Archieve.DataAccess.ViewModel;
using Archieve.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DataAccess.IRepository
{
   public interface IWorkPlaceService : IRepository<WorkPlace>
    {
       List<StructureTree> GetWorkPlaces(string filter);

    }
}
