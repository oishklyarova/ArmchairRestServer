using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armchair_rest_server.Models
{
    public class FurnitureRepository : IFurnitureRepository
    {
        private ArmchairDB context = new ArmchairDB();

        public IEnumerable<Furniture> GetAll()
        {
            return context.Furniture;
        }
    }
}