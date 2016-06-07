using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armchair_rest_server.Models
{
    public class FurnitureRepository : IFurnitureRepository
    {
        private static IFurnitureRepository repo = new FurnitureRepository();

        private ArmchairDB context = new ArmchairDB();

        public static IFurnitureRepository getRepository()
        {
            return repo;
        }

        public IEnumerable<Furniture> GetAll()
        {
            return context.Furniture;
        }
    }
}