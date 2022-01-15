using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class Film
    {
        public Film()
        {
            Buyings = new HashSet<Buying>();
            FilmToComments = new HashSet<FilmToComment>();
            PayFullFilms = new HashSet<PayFullFilm>();
        }

        public int Id { get; set; }
        public int ContentId { get; set; }
        public int UrlId { get; set; }
        public decimal Imdb { get; set; }
        public bool IsSubscribe { get; set; }
        public virtual Content Content { get; set; }
        public virtual Url Url { get; set; }
        public virtual ICollection<Buying> Buyings { get; set; }
        public virtual ICollection<FilmToComment> FilmToComments { get; set; }
        public virtual ICollection<PayFullFilm> PayFullFilms { get; set; }
    }
}
