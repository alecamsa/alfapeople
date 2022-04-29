using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Models
{
    public class CountryModel
    {
        public Name NameData { get; set; }
    }
    public class Name
    {
        public string common { get; set; }
        public string official { get; set; }
    }
}
