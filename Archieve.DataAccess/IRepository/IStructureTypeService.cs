using Archieve.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DataAccess.IRepository
{
   public interface IStructureTypeService : IRepository<StructureType>
    {
        Task<IQueryable<StructureType>> GetStructureTypes();

    }
}
