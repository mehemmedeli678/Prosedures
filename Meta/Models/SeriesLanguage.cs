using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class SeriesLanguage
    {
        public int Id { get; set; }
        public int SeriesId { get; set; }
        public string LanguageKey { get; set; }
        public string Description { get; set; }

        public virtual Series Series { get; set; }
    }
}
