using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class TrailerToSeason
    {
        public int Id { get; set; }
        public int TrailerId { get; set; }
        public int SeasonId { get; set; }

        public virtual Season Season { get; set; }
        public virtual Trailer Trailer { get; set; }
    }
}
