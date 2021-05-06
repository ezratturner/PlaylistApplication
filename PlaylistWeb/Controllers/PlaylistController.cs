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

    [Route("Playlists")] //the url it takes you to, customise the url
    public class PlaylistController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public PlaylistController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }

        public IActionResult Index() //gives a list of people
        {
            var allPlaylists = dbContext.Playlists.ToList();
            return View(allPlaylists);
        }

        //List<Playlists> Playlist = new List<Playlists>
        //{
        //    new Playlists{Name= "80s to 00s", Genre="Soul", Description="Throwbacks", Thumbnail="https://i.redd.it/qbb3wd0wpdd21.jpg" },
        //    new Playlists {Name = "Slow Jams", Genre="Rythm and Blues", Description = "Slow jams", Thumbnail = "https://i.redd.it/qbb3wd0wpdd21.jpg" },
        //    new Playlists {Name= "$$$$", Genre= "Hip Hop", Description="The hype", Thumbnail="https://i.redd.it/qbb3wd0wpdd21.jpg" },
        //    new Playlists {Name= "Playlit", Genre="Dancehall", Description="Caribbean Tunes", Thumbnail="https://i.redd.it/qbb3wd0wpdd21.jpg" },
        //};

        //return View(Playlist);


        [Route("details/{id:int}")]
        public IActionResult Details(int id) //READ
        {
            var playlistbyId = dbContext.Playlists.FirstOrDefault(c => c.ID == id);
            return View(playlistbyId);

            //var playlist = new Playlists { Name = "80s to 00s", Genre = "Soul", Description = "Throwbacks", Thumbnail = "https://i.redd.it/qbb3wd0wpdd21.jpg" };
            //return View(playlist);
        }

        [Route("create")]
        public IActionResult Create() //CREATE
        {
            return View();
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult Create(AddPlaylistBindingModel bindingModel)
        {
            var playlistToCreate = new Playlists
            {
                Songs = new List<Song>(),
                Name = bindingModel.Name,
                Description = bindingModel.Description,
                Genre = bindingModel.Genre,
                Thumbnail = bindingModel.Thumbnail,
                CreatedAt = DateTime.Now
            };
            dbContext.Playlists.Add(playlistToCreate);
            dbContext.SaveChanges();
            return RedirectToAction("Index");

        }

        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var playlistToUpdate = dbContext.Playlists.FirstOrDefault(c => c.ID == id);
            return View(playlistToUpdate);
        }

        [HttpPost] //modifying information

        [Route("update/{id:int}")]
        public IActionResult Update(Playlists playlists, int id)
        {
            var playlistToUpdate = dbContext.Playlists.FirstOrDefault(c => c.ID == id);
            playlistToUpdate.Name = playlists.Name;
            playlistToUpdate.Description = playlists.Description;
            playlistToUpdate.Thumbnail = playlists.Thumbnail;
            playlistToUpdate.Genre = playlists.Genre;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var playlistToDelete = dbContext.Playlists.FirstOrDefault(c => c.ID == id); //find the first playlist which matches the id
            dbContext.Playlists.Remove(playlistToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


        //SONG SECTION
        // ADDING a song to a playlist (create)

        [Route("addsong/{playlistid:int}")]
        public IActionResult AddSong(int playlistID)
        {
            var playlist = dbContext.Playlists.FirstOrDefault(c => c.ID == playlistID);
            ViewBag.PlaylistName = playlist.Name;
            ViewBag.PlaylistID = playlist.ID;
            return View();
        }
        [HttpPost]
        [Route("addsong/{playlistid:int}")] 
    
         public IActionResult AddSong(AddSongBindingModel bindingModel, int playlistId) //method definition

        {
            var song = new Song
            {
                Name = bindingModel.Name,
                Artist = bindingModel.Artist,
                Album = bindingModel.Album,
                Thumbnail = "https://i.redd.it/qbb3wd0wpdd21.jpg",
                CreatedAt = DateTime.Now
            };

            var playlistbyId = dbContext.Playlists.FirstOrDefault(c => c.ID == playlistId);
            playlistbyId.Songs.Add(song);

            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
