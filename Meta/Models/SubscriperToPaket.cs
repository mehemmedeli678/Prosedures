using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class SubscriperToPaket
    {
        public int Id { get; set; }
        public int SubscriberID { get; set; }
        public int PaketId { get; set; }
        public DateTime PaketDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }
        public virtual Paket Paket { get; set; }
        public virtual Subscriber Subscriber { get; set; }
    }
}
