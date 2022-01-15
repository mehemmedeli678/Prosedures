using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class Category
    {
        public Category()
        {
            CategoryLanguages = new HashSet<CategoryLanguage>();
            ContentToCategories = new HashSet<ContentToCategory>();
        }

        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }
        public virtual ICollection<CategoryLanguage> CategoryLanguages { get; set; }
        public virtual ICollection<ContentToCategory> ContentToCategories { get; set; }
    }
}
