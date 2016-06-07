using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armchair_rest_server.Models
{
    public class Like
    {
        public int id { get; set; }
        public string userName { get; set; }
        public int idFurn { get; set; }
    }
}