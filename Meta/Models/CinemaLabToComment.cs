using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class CinemaLabToComment
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public int CinemaLabId { get; set; }

        public virtual CinemaLab CinemaLab { get; set; }
        public virtual Comment Comment { get; set; }
    }
}
