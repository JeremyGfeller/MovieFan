using System;
using System.Collections.Generic;

namespace MovieFan.Models
{
    public partial class Movies
    {
        public Movies()
        {
            UserLikeMovie = new HashSet<UserLikeMovie>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? Release { get; set; }
        public string Picture { get; set; }
        public string Synopsis { get; set; }
        public int CategoryId { get; set; }
        public int RatingId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Ratings Rating { get; set; }
        public virtual ICollection<UserLikeMovie> UserLikeMovie { get; set; }
    }
}
