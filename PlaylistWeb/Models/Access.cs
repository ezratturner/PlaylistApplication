using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistWeb.Models
{
    public class Access
    {
        public UserAccess UserAccess { get; set; }
    }
    public enum UserAccess
    {
        Private = 1,
        Public
    }

}
