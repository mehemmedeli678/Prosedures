using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class TrailerToSeries
    {
        public int Id { get; set; }
        public int TrailerId { get; set; }
        public int SeriesId { get; set; }

        public virtual Series Series { get; set; }
        public virtual Trailer Trailer { get; set; }
    }
}
