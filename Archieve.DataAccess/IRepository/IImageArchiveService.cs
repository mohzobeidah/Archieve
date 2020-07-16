using Archieve.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DataAccess.IRepository
{
   public interface IImageArchiveService : IRepository<ImageArchive>
    {
        Task<List<ImageArchive>> getImageArchiveById(int? id);
        Task<ImageArchive> getImageArchiveByName(string name);

    }

}
