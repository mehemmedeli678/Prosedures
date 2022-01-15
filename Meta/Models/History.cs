using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class History
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UrlId { get; set; }

        public virtual Url Url { get; set; }
        public virtual User User { get; set; }
    }
}
