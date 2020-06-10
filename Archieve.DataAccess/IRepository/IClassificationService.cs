using Archieve.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DataAccess.IRepository
{
   public interface IClassificationService :IRepository<Classification>
    {
        IQueryable<Classification> GetClassifications(string filter, int initalPage, int pageSize,
                                 out int totalRecord,
                                 out int recordsFilter);
        //public async Task<Classification> deleteClassifiction(int? id, string username);

       // public Classification delClassifiction(int id);
    }
     
}
