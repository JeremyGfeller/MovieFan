using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFan.Models
{
    public partial class Movies
    {
        [NotMapped]
        public List<string> Likers 
        {
            get => this.UserLikeMovie.Select(u => u.User.FullName).ToList();
        }
    }
}
