using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Meta.Models
{
    public class GetSeriesById
    {
        [Key]
        public int ID { get; set; }
        public int SeasonID { get; set; }
        public string SeriaNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string SeasonNumber { get; set; }
        public string SeasonPicture { get; set; }
        public decimal Imdb { get; set; }
        public bool IsSubscribe { get; set; }
        public int ContentId { get; set; }
        public string ContentPicture { get; set; }
        public string Age { get; set; }
        public bool IsFree { get; set; }
        public int Hit { get; set; }
        public int TwShowId { get; set; }
        public string Name { get; set; }
        public int UrlId { get; set; }
        public string UrlName { get; set; }
        public string Description { get; set; }
    }
}
