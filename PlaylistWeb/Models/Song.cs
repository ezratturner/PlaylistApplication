using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistWeb.Models
{
    public class Song
    {
        public string ID { get; set; }
        public string Thumbnail { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Playlists playlists { get; set; } //song linked to playlist
    }
}
