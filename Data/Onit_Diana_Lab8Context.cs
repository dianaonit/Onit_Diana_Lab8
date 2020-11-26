using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Onit_Diana_Lab8.Models;

namespace Onit_Diana_Lab8.Data
{
    public class Onit_Diana_Lab8Context : DbContext
    {
        public Onit_Diana_Lab8Context (DbContextOptions<Onit_Diana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Onit_Diana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Onit_Diana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Onit_Diana_Lab8.Models.Category> Category { get; set; }
    }
}
