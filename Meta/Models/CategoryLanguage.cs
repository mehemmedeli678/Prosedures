using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class CategoryLanguage
    {
        public int Id { get; set; }
        public string LanguageKey { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
