using Archieve.DataAccess.IRepository;
using Archieve.DataAccess.DataConfigration;
using Archieve.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using Microsoft.AspNetCore.Routing;

namespace Archieve.DataAccess.Repository
{
    public class ImageArchiveService : Repository<ImageArchive>, IImageArchiveService
    {
        public ImageArchiveService(DataContext dataContext) : base(dataContext)
        {

        }
        public async Task<List<ImageArchive>> getImageArchiveById(int? id)
        {
            var ImageArchive = await GetQueryable( m=>m.FK_MailArchiveID == id).ToListAsync();
            return ImageArchive;
        }
        public async Task<ImageArchive> getImageArchiveByName(string name)
        {
            var ImageArchive = await GetQueryable(m => m.Name == name).FirstOrDefaultAsync();
            return ImageArchive;
        }


    }
}
