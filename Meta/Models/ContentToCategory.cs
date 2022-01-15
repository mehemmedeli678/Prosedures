using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class ContentToCategory
    {
        public int Id { get; set; }
        public int ContentId { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Content Content { get; set; }
    }
}
