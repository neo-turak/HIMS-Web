using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HIMS_Web.Models;

namespace HIMS_Web.Data
{
    public class LocationsContext : DbContext
    {
        public LocationsContext (DbContextOptions<LocationsContext> options)
            : base(options)
        {
        }

        public DbSet<HIMS_Web.Models.Locations> Locations { get; set; }
    }
}
