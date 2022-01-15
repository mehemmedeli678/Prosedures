using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class Paket
    {
        public Paket()
        {
            SubscriperToPakets = new HashSet<SubscriperToPaket>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsAdvertise { get; set; }
        public int ActiveDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<SubscriperToPaket> SubscriperToPakets { get; set; }
    }
}
