using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Simple_API.Models;

namespace Simple_API.Data
{
    public class MovieListContext : DbContext
    {
        public MovieListContext (DbContextOptions<MovieListContext> options)
            : base(options)
        {
        }

        public DbSet<Simple_API.Models.Movie> Movie { get; set; } = default!;
    }
}
