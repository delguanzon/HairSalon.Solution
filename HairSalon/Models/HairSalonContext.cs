using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{   
    // This class is a "database context" class we will use to allow Entity Framework to communicate with our MySQL database.
    // The "ProjectNameContext" class represents a session with our MySQL database allowing us to query for data.
    // In this class, we will create a DbSet for each model we create. A DbSet is a property that is used for accessing and querying our database tables.
    // For example, if we had a "ClassName" model, we would add a DbSet for "ClassNames" here.
    // The "ProjectNameContext" class inherits from the "DbContext" class provided by Entity Framework Core.
    // The "DbContext" class provides a "DbSet" property, which we will use to communicate with our MySQL database.

e
    public class HaiorSalonContext : DbContext
    {
        public HaiorSalonContext (DbContextOptions<HaiorSalonContext> options)
            : base(options)
        {
        }

        //Database tables go here
        public DbSet<HairSalon.Models.Clients> Clients { get; set; }
        public DbSet<HairSalon.Models.Stylists> Stylists { get; set; }
    }
}