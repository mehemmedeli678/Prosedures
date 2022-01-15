using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class Actor
    {
        public Actor()
        {
            ContentToActors = new HashSet<ContentToActor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<ContentToActor> ContentToActors { get; set; }
    }
}
