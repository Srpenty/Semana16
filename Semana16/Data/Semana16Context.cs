using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Semana16.Models;

namespace Semana16.Data
{
    public class Semana16Context : DbContext
    {
        public Semana16Context (DbContextOptions<Semana16Context> options)
            : base(options)
        {
        }

        public DbSet<Semana16.Models.Movie> Movie { get; set; }
    }
}
