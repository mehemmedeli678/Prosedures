using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class Subscriber
    {
        public Subscriber()
        {
            SubscriperToPakets = new HashSet<SubscriperToPaket>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<SubscriperToPaket> SubscriperToPakets { get; set; }
    }
}
