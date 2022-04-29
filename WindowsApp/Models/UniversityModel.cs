using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Models
{
    public class UniversityModel
    {
        public string name { get; set; }
        public string webpage { get; set; }
        public string alpha_two_code { get; set; }
        public List<string> domains { get; set; }
        public string country { get; set; }
        [JsonProperty("state-province")]
        public object StateProvince { get; set; }
        public List<string> web_pages { get; set; }
        
    }
}
