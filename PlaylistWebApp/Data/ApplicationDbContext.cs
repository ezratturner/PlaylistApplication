using CattyWebApp.Models;
using CattyWebLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CattyWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<CattyWebLibrary.Models.Cat> Cats { get; set; } //might not be correct
        public DbSet<CattyWebLibrary.Models.Kitten> Kittens { get; set; } //might not be correct
    }
}
