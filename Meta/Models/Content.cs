using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class Content
    {
        public Content()
        {
            CinemaLabs = new HashSet<CinemaLab>();
            ContentLanguages = new HashSet<ContentLanguage>();
            ContentToActors = new HashSet<ContentToActor>();
            ContentToCategories = new HashSet<ContentToCategory>();
            ContentToDirectors = new HashSet<ContentToDirector>();
            FavoryContents = new HashSet<FavoryContent>();
            Films = new HashSet<Film>();
            LikedContents = new HashSet<LikedContent>();
            LikedSeries = new HashSet<LikedSeries>();
            TrailerToContents = new HashSet<TrailerToContent>();
        }

        public int Id { get; set; }
        public string MainPicture { get; set; }
        public string Age { get; set; }
        public DateTime ContentDate { get; set; }
        public DateTime AddDate { get; set; }
        public bool IsFree { get; set; }
        public int Hit { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int TypeID { get; set; }
        public virtual Type Type { get; set; }
        public virtual ICollection<CinemaLab> CinemaLabs { get; set; }
        public virtual ICollection<ContentLanguage> ContentLanguages { get; set; }
        public virtual ICollection<ContentToActor> ContentToActors { get; set; }
        public virtual ICollection<ContentToCategory> ContentToCategories { get; set; }
        public virtual ICollection<ContentToDirector> ContentToDirectors { get; set; }
        public virtual ICollection<FavoryContent> FavoryContents { get; set; }
        public virtual ICollection<Film> Films { get; set; }
        public virtual ICollection<LikedContent> LikedContents { get; set; }
        public virtual ICollection<LikedSeries> LikedSeries { get; set; }
        public virtual ICollection<TvShow>  TvShows { get; set; }
        public virtual ICollection<TrailerToContent> TrailerToContents { get; set; }
    }
}
