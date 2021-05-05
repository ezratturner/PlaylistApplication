using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistWeb.Models
{

    public class Playlists
    {
        public string Thumbnail { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public Access Access { get; set; }
        public string DateCreated { get; set; }
    }
}
