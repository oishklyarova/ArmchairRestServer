using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armchair_rest_server.Models
{
    public class Furniture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Type_ { get; set; }
    }
}