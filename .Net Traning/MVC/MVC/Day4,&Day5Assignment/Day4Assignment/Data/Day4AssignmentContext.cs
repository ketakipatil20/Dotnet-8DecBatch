using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Day4Assignment.Models;

namespace Day4Assignment.Data
{
    public class Day4AssignmentContext : DbContext
    {
        public Day4AssignmentContext (DbContextOptions<Day4AssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<Day4Assignment.Models.Account> Account { get; set; }
    }
}
