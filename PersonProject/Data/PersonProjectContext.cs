using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonProject.Models;

namespace PersonProject.Data
{
    public class PersonProjectContext : DbContext
    {
        public PersonProjectContext (DbContextOptions<PersonProjectContext> options)
            : base(options)
        {
        }

        public DbSet<PersonProject.Models.Course> Course { get; set; } = default!;
    }
}
