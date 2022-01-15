using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class Series
    {
        public Series()
        {
            FavorySeries = new HashSet<FavorySeries>();
            LikedSeries = new HashSet<LikedSeries>();
            SeriesLanguages = new HashSet<SeriesLanguage>();
            SeriesToComments = new HashSet<SeriesToComment>();
            TrailerToSeries = new HashSet<TrailerToSeries>();
        }

        public int Id { get; set; }
        public int SeasonId { get; set; }
        public string SeriaNumber { get; set; }
        public int UrlId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Season Season { get; set; }
        public virtual Url Url { get; set; }
        public virtual ICollection<FavorySeries> FavorySeries { get; set; }
        public virtual ICollection<LikedSeries> LikedSeries { get; set; }
        public virtual ICollection<SeriesLanguage> SeriesLanguages { get; set; }
        public virtual ICollection<SeriesToComment> SeriesToComments { get; set; }
        public virtual ICollection<TrailerToSeries> TrailerToSeries { get; set; }
    }
}
