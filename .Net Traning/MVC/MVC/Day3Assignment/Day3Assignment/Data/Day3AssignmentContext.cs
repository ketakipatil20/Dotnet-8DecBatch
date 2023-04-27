using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Day3Assignment.Models;

namespace Day3Assignment.Data
{
    public class Day3AssignmentContext : DbContext
    {
        public Day3AssignmentContext (DbContextOptions<Day3AssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<Day3Assignment.Models.User> User { get; set; }
    }
}
