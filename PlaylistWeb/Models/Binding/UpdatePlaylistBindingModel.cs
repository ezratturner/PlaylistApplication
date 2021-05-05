using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistWeb.Models.Binding
{
    public class UpdatePlaylistBindingModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public UserAccess Access { get; set; }

    }
}
