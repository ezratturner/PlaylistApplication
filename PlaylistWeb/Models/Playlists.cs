using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PlaylistWeb.Models
{

    public class Playlists
    {
        [Key]
        public int ID { get; set; }
        public string Thumbnail { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public UserAccess Access { get; set; }
        public string DateCreated { get; set; }

    }
}
