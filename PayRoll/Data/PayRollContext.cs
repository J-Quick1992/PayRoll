using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PayRoll.Models;

namespace PayRoll.Models
{
    public class PayRollContext : DbContext
    {
        public PayRollContext (DbContextOptions<PayRollContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
