using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class FilmToComment
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public int CommentId { get; set; }

        public virtual Comment Comment { get; set; }
        public virtual Film Film { get; set; }
    }
}
