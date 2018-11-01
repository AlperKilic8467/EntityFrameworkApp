using Entities.buildinfiles;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Context class
    /// </summary>
    public class BuildingContext: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<BuildingContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Building> Buildings { get; set; }

        
    }
}
