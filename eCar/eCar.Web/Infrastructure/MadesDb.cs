using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eCar.Web.Infrastructure
{
    public class MadesDb : DbContext, IMadeDatabaseSet
    {
        public MadesDb() :base ("DefaultConnection")
            {
            
            }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Made> Mades { get; set; }

        IQueryable<Car> IMadeDatabaseSet.Cars
        {
            get
            {
                return Cars ;
            }
        }

        IQueryable<Made> IMadeDatabaseSet.Mades
        {
            get
            {
                return Mades;
            }
        }
    }
}