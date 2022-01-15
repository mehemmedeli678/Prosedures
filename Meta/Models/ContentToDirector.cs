using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class ContentToDirector
    {
        public int Id { get; set; }
        public int ContentId { get; set; }
        public int DirectorId { get; set; }

        public virtual Content Content { get; set; }
        public virtual Director Director { get; set; }
    }
}
