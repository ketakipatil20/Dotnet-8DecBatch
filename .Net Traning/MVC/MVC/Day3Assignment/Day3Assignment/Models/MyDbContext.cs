using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Day3Assignment.Models
{
    public class MyDbContext
    {
        public MyDbContext(): base()

        {

        }

        public DbSet<User> Users { get; set; }
    }
}
