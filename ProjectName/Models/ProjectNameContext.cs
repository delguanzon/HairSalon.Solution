using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectName.Models
{
    public class ProjectNameContext : DbContext
    {
        public ProjectNameContext (DbContextOptions<ProjectNameContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectName.Model.ClassName> Items { get; set; }
    }
}