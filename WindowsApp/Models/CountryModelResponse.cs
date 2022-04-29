using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Models
{
    public class CountryModelResponse : BaseResult
    {
        public List<CountryModel> CountryList { get; set; }
    }
}

