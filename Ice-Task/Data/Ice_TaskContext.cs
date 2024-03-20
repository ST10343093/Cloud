using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ice_Task.Models;

namespace Ice_Task.Data
{
    public class Ice_TaskContext : DbContext
    {
        public Ice_TaskContext (DbContextOptions<Ice_TaskContext> options)
            : base(options)
        {
        }

        public DbSet<Ice_Task.Models.Shopping> Shopping { get; set; } = default!;
    }
}
