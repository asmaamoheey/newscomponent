using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using compents.Models;
namespace compents.Models
{



    public class newscontext : DbContext
    {
        public newscontext()
        {
        }

        public newscontext(DbContextOptions<newscontext> options) : base(options)
        {
        }

        public DbSet<News> news { get; set; }
        public DbSet<Source> sourses { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}

