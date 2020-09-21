using Archieve.DataAccess.DataConfigration;
using Archieve.DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archieve.DataAccess.Configuration
{
    public class MilitaryRankConfigration
    {

        public MilitaryRankConfigration(EntityTypeBuilder<MilitaryRank> entity)
        {

            if (DataContext.migrate) 
            { 
                entity.HasData(new MilitaryRank { Id = 1, RankName = "لواء ", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new MilitaryRank { Id = 2, RankName = " عميد", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new MilitaryRank { Id = 3, RankName = " عقيد", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new MilitaryRank { Id = 4, RankName = " مقدم", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new MilitaryRank { Id = 5, RankName = "رائد ", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new MilitaryRank { Id = 6, RankName = " نقيب", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new MilitaryRank { Id = 7, RankName = " ملازم اول", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new MilitaryRank { Id = 8, RankName = " ملازم", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new MilitaryRank { Id = 9, RankName = "مساعد اول ", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new MilitaryRank { Id = 10, RankName = " مساعد", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new MilitaryRank { Id = 11, RankName = " رقيب اول", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new MilitaryRank { Id = 12, RankName = " رقيب", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new MilitaryRank { Id = 13, RankName = "عريف ", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new MilitaryRank { Id = 14, RankName = " جندي", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new MilitaryRank { Id = 15, RankName = " عقد بطالة", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
                entity.HasData(new MilitaryRank { Id = 16, RankName = " السيد", IsDeleted = false, InsertDate = DateTime.Now, UpdatedDate = DateTime.Now });
            }
        }
    }
}
