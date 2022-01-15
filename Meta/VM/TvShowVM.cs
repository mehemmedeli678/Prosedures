using Meta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meta.VM
{
    public class TvShowVM
    {
        public GetTvShowById TvShow { get; set; }
        public List<Director>  Directors { get; set; }
        public List<GetCategoryBycontent> Categories { get; set; }
        public List<Season> Seasons { get; set; }
        public List<Actor>  Actors { get; set; }
    }
}
