using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class ContentToActor
    {
        public int Id { get; set; }
        public int ContentId { get; set; }
        public int ActorId { get; set; }

        public virtual Actor Actor { get; set; }
        public virtual Content Content { get; set; }
    }
}
