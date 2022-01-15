using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Meta.Models
{
    public class GetTvShowById
    {
        [Key]
        public int ID { get; set; }
        public int ContentId { get; set; }
        public decimal Imdb { get; set; }
        public string Type { get; set; }
        public string MainPicture { get; set; }
        public string Age { get; set; }
        public DateTime ContentDate { get; set; }
        public DateTime AddDate { get; set; }
        public bool IsFree { get; set; }
        public int Hit { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
