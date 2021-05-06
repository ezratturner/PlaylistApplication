using Microsoft.EntityFrameworkCore;
using PlaylistWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Playlists> Playlists { get; set; }
        public DbSet<Song> Songs { get; set; }

    }
}
