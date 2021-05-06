using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistWeb.Models.Binding
{
    public class AddSongBindingModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public DateTime CreatedAt { get; set; }
        public Song SongID { get; set; }

    }
}
