using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDFForm.Models
{
    public class Pizza
    {
        public string Size { get; set; }
        public string Tomatoes { get; set; }
        public string Onions { get; set; }
        public string Tuna { get; set; }
        public string Cheese { get; set; }
        public string Name { get; set; }
    }

    public enum Size
    {
        small, medium, large
    }
}
