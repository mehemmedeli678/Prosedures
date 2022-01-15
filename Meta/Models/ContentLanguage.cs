using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class ContentLanguage
    {
        public int Id { get; set; }
        public int ContentId { get; set; }
        public string LanguageKey { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Content Content { get; set; }
    }
}
