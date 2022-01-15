using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class Audio
    {
        public int Id { get; set; }
        public string AudioKey { get; set; }
        public string AudioName { get; set; }
        public int UrlId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Url Url { get; set; }
    }
}
