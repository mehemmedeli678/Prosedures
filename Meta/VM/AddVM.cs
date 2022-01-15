using Meta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meta.VM
{
    public class AddVM
    {
        public List<Category> Categories { get; set; }
        public List<Director> Directors { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Language> Languages { get; set; }
    }
}
