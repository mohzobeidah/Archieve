using Archieve.DataAccess.IRepository;
using Archieve.DataAccess.DataConfigration;
using Archieve.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Archieve.DataAccess.ViewModel;

namespace Archieve.DataAccess.Repository
{
    public class WorkPlaceService : Repository<WorkPlace>, IWorkPlaceService
    {
        public WorkPlaceService(DataContext dataContext):base(dataContext)
        {
                    
        }
        public List<StructureTree> GetWorkPlaces(string filter)
        {
            var x =  GetQueryable(z => z.IsDeleted == false) ;                
              return   x.Select(x =>
              new StructureTree
              {
                  id = x.Id.ToString(),
                  parent = (x.ParentId.ToString() == "0" ? "#" : x.ParentId.ToString()),
                  text = x.Text,
                  DepType = x.FK_WpId.ToString(),
                  IsDeleted = x.IsDeleted
              }).ToList();
        }
    }
}
