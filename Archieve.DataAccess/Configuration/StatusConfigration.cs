using Archieve.DataAccess.DataConfigration;
using Archieve.DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archieve.DataAccess.Configuration
{
   public class StatusConfigration
    {

        public StatusConfigration(EntityTypeBuilder<Status> entity)
        {

            if (DataContext.migrate) { 
                entity.HasData(new Status { Id = 1, StatusName = "منجر", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new Status { Id = 2, StatusName = "غير منجر", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });

     }

        }
    }
}
