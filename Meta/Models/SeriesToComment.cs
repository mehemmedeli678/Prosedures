using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class SeriesToComment
    {
        public int Id { get; set; }
        public int SeriesId { get; set; }
        public int CommentId { get; set; }

        public virtual Comment Comment { get; set; }
        public virtual Series Series { get; set; }
    }
}
