using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorBasicsApp.Models
{
    public class EmailPromo
    {
        public int Id { get; set; }

        public bool IsSubscribed { get; set; }

        public string Title { get; set; }
    }
}
