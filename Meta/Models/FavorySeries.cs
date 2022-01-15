using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class FavorySeries
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SeriesId { get; set; }

        public virtual Series Series { get; set; }
        public virtual User User { get; set; }
    }
}
