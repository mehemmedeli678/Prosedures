using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class Url
    {
        public Url()
        {
            Audios = new HashSet<Audio>();
            CinemaLabs = new HashSet<CinemaLab>();
            Films = new HashSet<Film>();
            Histories = new HashSet<History>();
            Series = new HashSet<Series>();
            Subtitles = new HashSet<Subtitle>();
        }

        public int Id { get; set; }
        public string UrlName { get; set; }

        public virtual ICollection<Audio> Audios { get; set; }
        public virtual ICollection<CinemaLab> CinemaLabs { get; set; }
        public virtual ICollection<Film> Films { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<Series> Series { get; set; }
        public virtual ICollection<Subtitle> Subtitles { get; set; }
    }
}
