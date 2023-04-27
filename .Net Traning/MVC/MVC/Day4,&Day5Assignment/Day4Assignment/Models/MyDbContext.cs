using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace Day4Assignment.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options) :base(options)

        {

        }

        public DbSet<Account> Accounts { get; set; }
    }
}
