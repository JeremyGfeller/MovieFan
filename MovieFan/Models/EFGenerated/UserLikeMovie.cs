using System;
using System.Collections.Generic;

namespace MovieFan.Models
{
    public partial class UserLikeMovie
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public string Comment { get; set; }
        public int? Stars { get; set; }
        public byte HasSeen { get; set; }

        public virtual Movies Movie { get; set; }
        public virtual Users User { get; set; }
    }
}
