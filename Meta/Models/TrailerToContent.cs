using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class TrailerToContent
    {
        public int Id { get; set; }
        public int ContentId { get; set; }
        public int TrailerId { get; set; }

        public virtual Content Content { get; set; }
        public virtual Trailer Trailer { get; set; }
    }
}
