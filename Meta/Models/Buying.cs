using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class Buying
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FilmId { get; set; }
        public DateTime BuyingDate { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Film Film { get; set; }
        public virtual User User { get; set; }
    }
}
