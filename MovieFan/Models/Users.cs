using System;
using System.Collections.Generic;

namespace MovieFan.Models
{
    public partial class Users
    {
        public Users()
        {
            UserLikeMovie = new HashSet<UserLikeMovie>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public byte? IsAdmin { get; set; }

        public virtual ICollection<UserLikeMovie> UserLikeMovie { get; set; }
    }
}
