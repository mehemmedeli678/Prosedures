using Meta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meta.VM
{
    public class FilmVM
    {
        public GetFilmByContent Film { get; set; }
        public List<FilmToComment> FilmToComments { get; set; }
        public List<GetCategoryBycontent> Category { get; set; }
        public List<Subtitle>  Subtitles { get; set; }
        public List<Audio>  Audios { get; set; }
    }
}
