using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class CinemaLab
    {
        public CinemaLab()
        {
            CinemaLabToComments = new HashSet<CinemaLabToComment>();
        }

        public int Id { get; set; }
        public int ContentId { get; set; }
        public int UrlId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }
        public virtual Content Content { get; set; }
        public virtual Url Url { get; set; }
        public virtual ICollection<CinemaLabToComment> CinemaLabToComments { get; set; }
    }
}
