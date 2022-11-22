using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razerpagemovie.Models;

namespace razerpagemovie.Data
{
    public class razerpagemovieContext : DbContext
    {
        public razerpagemovieContext (DbContextOptions<razerpagemovieContext> options)
            : base(options)
        {
        }

        public DbSet<razerpagemovie.Models.Movie> Movie { get; set; }
    }
}
