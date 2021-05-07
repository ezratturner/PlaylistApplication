using Microsoft.EntityFrameworkCore;
using PlaylistWeb.Controllers;
using PlaylistWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PlaylistTests.Playlists
{
    public class SongTest
    {
        [Fact]
        public void Index()
        {

        }
        public void Create()
        {
            // arrange
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("test");
            var context = new ApplicationDbContext(optionsBuilder.Options);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var controller = new SongsController(context);

            //act



            //assert
        }

    }
}
