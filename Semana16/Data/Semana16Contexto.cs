using Microsoft.EntityFrameworkCore;
using Semana16;
using Semana16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana16.Data
{
    public class Semana16Contexto  : DbContext
    {
        public Semana16Contexto(DbContextOptions<Semana16Contexto> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
    }
}
