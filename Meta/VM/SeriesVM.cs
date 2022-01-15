using Meta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meta.VM
{
    public class SeriesVM
    {
        public GetSeriesById Series { get; set; }
        public List<Season>  Seasons { get; set; }
        public List<Comment>  Comment { get; set; }
        public List<Audio>  Audios { get; set; }
        public List<Subtitle>  Subtitles { get; set; }
        public List<GetCategoryBycontent>  Categories { get; set; }
    }
}
