using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class FavoryContent
    {
        public int Id { get; set; }
        public int ContentId { get; set; }
        public int UserId { get; set; }

        public virtual Content Content { get; set; }
        public virtual User User { get; set; }
    }
}
