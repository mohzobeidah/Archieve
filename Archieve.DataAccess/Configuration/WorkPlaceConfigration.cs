using Archieve.DataAccess.DataConfigration;
using Archieve.DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archieve.DataAccess.Configuration
{
    public class WorkPlaceConfigration
    {
        public WorkPlaceConfigration(EntityTypeBuilder<WorkPlace> entity)
        {
            if (DataContext.migrate)
            {
                entity.HasData(new WorkPlace { Id = 1, Text = "عام", ParentId = 0, FK_WpId=6, IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new WorkPlace { Id = 2, Text = "المديرية العامة للعمليات المركزية", ParentId = 1, FK_WpId = 1, IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new WorkPlace { Id = 3, Text = "هئيات خارجية", ParentId = 1, FK_WpId = 6, IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new WorkPlace { Id = 4, Text = "ادارة الاتصالات", ParentId = 2, FK_WpId = 2, IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new WorkPlace { Id = 5, Text = "دائرة نظم المعلومات", ParentId = 4, FK_WpId = 3, IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new WorkPlace { Id = 6, Text = "قسم البرمجة", ParentId = 5, FK_WpId = 4, IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new WorkPlace { Id = 7, Text = "ادارة الامداد", ParentId = 2, FK_WpId = 2, IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
            }
        }
    }
}
