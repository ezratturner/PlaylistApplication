using Microsoft.AspNetCore.Mvc;
using PlaylistWeb.Data;
using PlaylistWeb.Models;
using System;
//using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;

namespace PlaylistWeb.Controllers
{
    [Route("[Controller]")]
    public class SongsController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public SongsController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }

        //READ

        [Route("")]
        public IActionResult Index()
        {
            var allSongs = dbContext.Songs.ToList();
            return View(allSongs);
        }
        [Route("details/{id:int}")]

        public IActionResult Details(int id)
        {
            var songsById = dbContext.Songs.FirstOrDefault(c => c.ID == id);
            return View(songsById);
        }

        public IActionResult Create() //CREATE
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AddSongBindingModel bindingModel)
        {
            var playlistToCreate = new Song
            {
                Name = bindingModel.Name,
                Artist = bindingModel.Artist,
                Album = bindingModel.Album,
                Thumbnail = "https://i.redd.it/qbb3wd0wpdd21.jpg",
                CreatedAt = DateTime.Now
            };
            dbContext.Playlists.Add(playlistToCreate);
            dbContext.SaveChanges();
            return RedirectToAction("Index");

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
}
