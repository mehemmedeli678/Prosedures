using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class Season
    {
        public Season()
        {
            Series = new HashSet<Series>();
            TrailerToSeasons = new HashSet<TrailerToSeason>();
        }

        public int Id { get; set; }
        public int TvShowId { get; set; }
        public string SeasonNumber { get; set; }
        public string MainPicture { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }
        public virtual TvShow TvShow { get; set; }
        public virtual ICollection<Series> Series { get; set; }
        public virtual ICollection<TrailerToSeason> TrailerToSeasons { get; set; }
    }
}
