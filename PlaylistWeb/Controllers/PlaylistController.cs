using Microsoft.AspNetCore.Mvc;
using PlaylistWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistWeb.Controllers
{
    public class PlaylistController : Controller
    {
        [Route("Playlists")] //the url it takes you to, customise the url
        public IActionResult Index() //gives a list of people
        {
            List<Playlists> Playlist = new List<Playlists>
            {
                new Playlists{Name= "80s to 00s", Genre="Soul", Description="Throwbacks", Thumbnail="https://i.redd.it/qbb3wd0wpdd21.jpg" },
                new Playlists {Name = "Slow Jams", Genre="Rythm and Blues", Description = "Slow jams", Thumbnail = "https://i.redd.it/qbb3wd0wpdd21.jpg" },
                new Playlists {Name= "$$$$", Genre= "Hip Hop", Description="The hype", Thumbnail="https://i.redd.it/qbb3wd0wpdd21.jpg" },
                new Playlists {Name= "Playlit", Genre="Dancehall", Description="Caribbean Tunes", Thumbnail="https://i.redd.it/qbb3wd0wpdd21.jpg" },
            };

            return View(Playlist);
        }

  
        public IActionResult Details()
        {
            var playlist = new Playlists { Name = "80s to 00s", Genre = "Soul", Description = "Throwbacks", Thumbnail = "https://i.redd.it/qbb3wd0wpdd21.jpg" };
            return View(playlist);
        }

    }
}
