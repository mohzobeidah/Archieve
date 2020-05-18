using Archieve.DatabaseLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archieve.DataAccess.DataConfigration
{
    public class DataContext:IdentityDbContext<User>
    {

        public DataContext(DbContextOptions<DataContext> dbContextOptions):base(dbContextOptions)
        {

        }
    }
}
