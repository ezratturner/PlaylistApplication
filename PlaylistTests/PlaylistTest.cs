using System;
using Xunit;
using PlaylistWeb.Data;
using Microsoft.EntityFrameworkCore;
using PlaylistWeb.Controllers;
using PlaylistWeb.Models.Binding;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PlaylistTests
{
    public class PlaylistTest
    {
        [Fact]
        public void Index()
        {
            // arrange
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("test");
            var context = new ApplicationDbContext(optionsBuilder.Options);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var controller = new PlaylistController(context);

            //act
            var result = controller.Index();

            //assert
            Assert.NotNull(result);

            //checks playists

        }


        [Fact]
        public void Create_Post()
        {
            //arrange
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("test");
            var context = new ApplicationDbContext(optionsBuilder.Options);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            var controller = new PlaylistController(context);

            context.Playlists.Add(new PlaylistWeb.Models.Playlists { Name = "Good PlayList" });
            context.SaveChanges();

            AddPlaylistBindingModel playlist = new AddPlaylistBindingModel
            {
                Name = "Fun Playlist",
                Description = "For having fun",
                Genre = "Hip Hop",
                CreatedAt = DateTime.Now
            };

            //act
            var result = controller.Create(playlist);

            //assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            var playlists = context.Playlists.ToList();
            var addedPlaylist = playlists.Single(p => p.Name == playlist.Name);

            Assert.Equal("Index", redirectToActionResult.ActionName);
            Assert.Equal(2, playlists.Count);
            Assert.Contains(playlists, x => x.Name == "Good PlayList");
            Assert.Contains(playlists, x => x.Name == "Fun Playlist");
        }

        [Fact]
        public void Create_Get()
        {
            //arrange
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("test");
            var context = new ApplicationDbContext(optionsBuilder.Options);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var controller = new PlaylistController(context);

            //act
            var result = controller.Create();

            //assert
            Assert.NotNull(result); // something is returned
        }

        [Fact]
        public void Update_Playlist()
        {
            //arrange
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("test");
            var context = new ApplicationDbContext(optionsBuilder.Options);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var controller = new PlaylistController(context);

            context.Playlists.Add(new PlaylistWeb.Models.Playlists { Name = "Good PlayList" });
            context.SaveChanges();

            PlaylistWeb.Models.Playlists playlist = new PlaylistWeb.Models.Playlists
            {
                Name = "Fun Playlist",
                Description = "For having fun",
                Genre = "Hip Hop",
                CreatedAt = DateTime.Now
            };

            //act
            var result = controller.Update(playlist, 1);

            //assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            var playlists = context.Playlists.ToList();
            var addedPlaylist = playlists.Single(p => p.Name == playlist.Name);

            Assert.Equal("Index", redirectToActionResult.ActionName);
            Assert.Equal(1, playlists.Count);
            Assert.DoesNotContain(playlists, x => x.Name == "Good PlayList");
            Assert.Contains(playlists, x => x.Name == "Fun Playlist");
        }

      // [Fact]
        //public void Delete()
        //{
        //    ///arrange
        //    var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("test");
        //    var context = new ApplicationDbContext(optionsBuilder.Options);
        //    context.Database.EnsureDeleted();
        //    context.Database.EnsureCreated();

        //    var controller = new PlaylistController(context);

        //    AddPlaylistBindingModel playlist = new AddPlaylistBindingModel
        //    {
        //        Name = "Fun Playlist",
        //        Description = "For having fun",
        //        Genre = "Hip Hop",
        //        CreatedAt = DateTime.Now
        //    };

        //    //act
        //    var result = controller.Delete(playlist,1);

        //    //assert
        //    var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        //    var playlists = context.Playlists.ToList();
        //    var addedPlaylist = playlists.Single(p => p.Name == playlist.Name);

        //    Assert.Equal("Delete", redirectToActionResult.ActionName);
        //    Assert.Single(playlists);
        //    Assert.Contains(playlists, x => x.Name == "Good PlayList");
        //    Assert.Contains(playlists, x => x.Name == "Fun Playlist");
        // 
    }

    }

    

