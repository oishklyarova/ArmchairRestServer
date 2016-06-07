using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armchair_rest_server.Models
{
    public class Feedback
    {
        public int id { get; set; }
        public string email { get; set; }
        public string title { get; set; }
        public string question { get; set; }
    }
}