using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armchair_rest_server.Models
{
    public interface IFurnitureRepository
    {
        IEnumerable<Furniture> GetAll();
    }
}