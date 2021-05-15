using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Songs_Web_API.Model;

namespace Songs_Web_API.Models
{
    public class Songs_WebDataContext : DbContext
    {
        public Songs_WebDataContext (DbContextOptions<Songs_WebDataContext> options)
            : base(options)
        {
        }

        public DbSet<Songs_Web_API.Model.Song> Song { get; set; }
    }
}
