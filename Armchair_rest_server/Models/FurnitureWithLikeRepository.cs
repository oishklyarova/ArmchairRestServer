using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armchair_rest_server.Models
{
    public class FurnitureWithLikeRepository : IFurnitureWithLikeRepository
    {
        private static FurnitureWithLikeRepository repo = new FurnitureWithLikeRepository();

        private ArmchairDB context = new ArmchairDB();

        public static IFurnitureWithLikeRepository getRepository()
        {
            return repo;
        }

        public IQueryable<FurnitureWithLike> GetAll(string userName)
        {
            var result = from f in context.Furniture
                         join l in context.Likes on f.Id equals l.idFurn into ls
                         from l in ls.Where(l => l.userName == userName).DefaultIfEmpty()
                         select new FurnitureWithLike()
                         {
                             Id = f.Id,
                             Name = f.Name,
                             Image = f.Image,
                             Price = f.Price,
                             Description = f.Description,
                             Type_ = f.Type_,
                             Liked = l == null ? false : true
                         };
            return result;
        }
    }
}