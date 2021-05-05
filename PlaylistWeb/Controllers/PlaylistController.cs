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
    public class PlaylistController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public PlaylistController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }

        [Route("Playlists")] //the url it takes you to, customise the url
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
        

        [Route("details/{int:id}")]
        public IActionResult Details(int id) //READ
        {
            var playlistbyId = dbContext.Playlists.FirstOrDefault(c => c.ID == id);
            return View(playlistbyId);

            //var playlist = new Playlists { Name = "80s to 00s", Genre = "Soul", Description = "Throwbacks", Thumbnail = "https://i.redd.it/qbb3wd0wpdd21.jpg" };
            //return View(playlist);
        }


        public IActionResult Create() //CREATE
        {
            return View();
        }
        [Route("update/{id:int}")]


        public IActionResult Update(int id) //UPDATE
        {
            return View();
        }

    //    public IActionResult Delete() //DELETE
      //  {
     //       return View();
      //  }

    }
}
