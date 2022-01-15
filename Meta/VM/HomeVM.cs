using Meta.Migrations;
using Meta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meta.VM
{
    public class HomeVM
    {
        public List<Models.Content>  Contents { get; set; }
        public List<Category> Categories { get; set; }
        public List<Language>  Languages { get; set; }
        public string Lang { get; set; }
    }
}
