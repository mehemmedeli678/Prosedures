using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class Trailer
    {
        public Trailer()
        {
            TrailerToContents = new HashSet<TrailerToContent>();
            TrailerToSeasons = new HashSet<TrailerToSeason>();
            TrailerToSeries = new HashSet<TrailerToSeries>();
        }

        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<TrailerToContent> TrailerToContents { get; set; }
        public virtual ICollection<TrailerToSeason> TrailerToSeasons { get; set; }
        public virtual ICollection<TrailerToSeries> TrailerToSeries { get; set; }
    }
}
