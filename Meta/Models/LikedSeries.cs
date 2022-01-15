using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class LikedSeries
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SeriesId { get; set; }
        public DateTime LikedDate { get; set; }
        public int? ContentId { get; set; }

        public virtual Content Content { get; set; }
        public virtual Series Series { get; set; }
        public virtual User User { get; set; }
    }
}
