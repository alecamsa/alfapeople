using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Models
{
    public class BaseResult
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }
    }
}
