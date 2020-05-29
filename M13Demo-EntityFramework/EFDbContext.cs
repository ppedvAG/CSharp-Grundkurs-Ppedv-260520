using M13Demo_EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace M13Demo_EntityFramework
{
    public class EFDbContext : DbContext
    {
        public DbSet<Akkuschrauber> DieAkkuschrauber { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            // => options.UseSqlite("Data Source=AkkuschrauberDB.db");
            // => options.UseSqlServer(DbConnectionStringBuilder, ServiceProviderOptions => ServiceProviderOptions.CommandTimeout(60)); 
            => options.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database=EFDbContext-491eb77f-450d-4e13-b775-b64ce6b36b9a;Trusted_Connection=True;MultipleActiveResultSets=true");
    }
}
