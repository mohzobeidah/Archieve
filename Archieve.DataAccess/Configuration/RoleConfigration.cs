using Archieve.DataAccess.DataConfigration;
using Archieve.DatabaseLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archieve.DataAccess.Configuration
{
    public class RoleConfigration
    {

        public RoleConfigration(EntityTypeBuilder<IdentityRole> entity)
        {

            if (DataContext.migrate) 
            { 
                entity.HasData(new IdentityRole { Id = Guid.NewGuid().ToString(), Name="SuperAdmin" ,NormalizedName= "SUPERADMIN" });
                entity.HasData(new IdentityRole { Id = Guid.NewGuid().ToString(), Name="Admin" ,NormalizedName= "ADMIN" });
                entity.HasData(new IdentityRole { Id = Guid.NewGuid().ToString(), Name="User" ,NormalizedName= "USER" });
                entity.HasData(new IdentityRole { Id = Guid.NewGuid().ToString(), Name="Manager" ,NormalizedName= "MANAGER" });
            }
        }
    }
}
