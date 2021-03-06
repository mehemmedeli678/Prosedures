using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Meta.Models
{
    public class GetFilmByContent
    {
        [Key]
        public int FilmID { get; set; }
        public decimal Imdb { get; set; }
        public bool IsSubscribe { get; set; }
        public int ContentID { get; set; }
        public string MainPicture { get; set; }
        public string Age { get; set; }
        public bool IsFree { get; set; }
        public int Hit { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime ContentDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UrlId { get; set; }
        public string UrlName { get; set; }
    }
}
