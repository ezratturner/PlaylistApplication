using Microsoft.AspNetCore.Mvc;
using PlaylistWeb.Data;
using PlaylistWeb.Models;
using PlaylistWeb.Models.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistWeb.Controllers
{
    [Route("Songs")] // relevant for each method
    public class SongsController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public SongsController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }

        [Route("Create/{id:int}")]
        public IActionResult Create() //CREATE
        {
            return View();
        }
        [HttpPost]

        [Route("Create/{id:int}")]
        public IActionResult Create(AddSongBindingModel bindingModel, int id)
        {
            var songToCreate = new Song
            {
                Name = bindingModel.Name,
                Thumbnail = bindingModel.Thumbnail,
                Artist = bindingModel.Artist,
                Album = bindingModel.Album,
                CreatedAt = DateTime.Now
            };

            var playlist = dbContext.Playlists.FirstOrDefault(c => c.ID == id);
            if (playlist.Songs == null)
            {
                playlist.Songs = new List<Song>();
            }
            playlist.Songs.Add(songToCreate);
            dbContext.SaveChanges();
            return RedirectToAction("Index");

        }
        //READ
        [Route("{id:int}")]

        public IActionResult Index(int id) //loading the songs to the database
        {
            var playlist = dbContext.Playlists.FirstOrDefault(c => c.ID == id);
            if (playlist.Songs == null)
            {
                return View (new List<Song>());
            }
            return View(playlist.Songs); //returns all songs
        }
        
        

        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var songById = dbContext.Songs.FirstOrDefault(c => c.ID == id);
            return View(songById);
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(Song song, int id)
        {
            var songToUpdate = dbContext.Songs.FirstOrDefault(c => c.ID == id);
            songToUpdate.Name = song.Name;
            songToUpdate.Artist = song.Artist;
            songToUpdate.Album = song.Album;
            songToUpdate.Thumbnail = song.Thumbnail;

            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var songToDelete = dbContext.Songs.FirstOrDefault(c => c.ID == id);
            dbContext.Songs.Remove(songToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

