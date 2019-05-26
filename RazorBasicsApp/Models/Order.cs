using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorBasicsApp.Models
{
    public class Order
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
