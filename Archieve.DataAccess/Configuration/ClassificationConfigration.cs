using Archieve.DataAccess.DataConfigration;
using Archieve.DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archieve.DataAccess.Configuration
{
    public class ClassificationConfigration
    {

        public ClassificationConfigration(EntityTypeBuilder<Classification> entity)
        {

            if (DataContext.migrate) 
            { 
                entity.HasData(new Classification { Id = 1, ClassificationName = "ترقين قيد ", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new Classification { Id = 2, ClassificationName = " طلب اجازة", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new Classification { Id = 3, ClassificationName = " طلب صيانة", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new Classification { Id = 4, ClassificationName = " اوامر ادارية", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
            }
        }
    }
}
