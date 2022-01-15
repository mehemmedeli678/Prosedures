using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class TvShow
    {
        public TvShow()
        {
            Seasons = new HashSet<Season>();
        }

        public int Id { get; set; }
        public decimal Imdb { get; set; }
        public int ContentID { get; set; }
        public bool IsSubscribe { get; set; }
        public virtual Content  Content { get; set; }
        public virtual ICollection<Season> Seasons { get; set; }
    }
}
