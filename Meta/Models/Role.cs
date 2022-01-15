using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class Role
    {
        public Role()
        {
            UserToRoles = new HashSet<UserToRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<UserToRole> UserToRoles { get; set; }
    }
}
