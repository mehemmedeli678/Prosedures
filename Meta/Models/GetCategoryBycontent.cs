using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meta.Models
{
    public class GetCategoryBycontent
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string Name { get; set; }
    }
}
