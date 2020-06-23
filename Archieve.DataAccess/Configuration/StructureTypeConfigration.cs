using Archieve.DataAccess.DataConfigration;
using Archieve.DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archieve.DataAccess.Configuration
{
    class StructureTypeConfigration { 
    
        public StructureTypeConfigration(EntityTypeBuilder<StructureType> entity)
        {

            if (DataContext.migrate)
            {
                entity.HasData(new StructureType { Id = 1,  Description = "الجهاز", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new StructureType { Id = 2, Description = "الادارة", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new StructureType { Id = 3, Description = "دائرة", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new StructureType { Id = 4, Description = "قسم", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new StructureType { Id = 5, Description = "وحدة", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new StructureType { Id = 6, Description = "اخرى", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
            }
        }
    }
}
