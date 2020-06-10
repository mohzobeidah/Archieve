using Archieve.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Archieve.DataAccess.IRepository
{
   public interface IPostTypeService : IRepository<PostType>
    {
        IQueryable<PostType> GetPostTypes(
                                 string filter, 
                                 int initalPage, 
                                 int pageSize,
                                 out int totalRecord,
                                 out int recordsFilter
                                 );

    }
}
