using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armchair_rest_server.Models
{
    public class LikedRepository : ILikedRepository
    {
        private ArmchairDB context = new ArmchairDB();

        public IQueryable<Liked> GetAll(string userName)
        {
            var result = from l in context.Likes
                         where l.userName == userName
                         join f in context.Furniture on l.idFurn equals f.Id
                         orderby f.Type_
                         select new Liked()
                         {
                             UserName = l.userName,
                             IdFurn = l.idFurn,
                             Name = f.Name,
                             Description = f.Description,
                             Image = f.Image,
                             Price = f.Price,
                             Type_ = f.Type_
                         };
            return result;
        }

        public void CreateLiked(Liked liked)
        {
            context.Likes.Add(new Like { userName = liked.UserName, idFurn = liked.IdFurn });
            context.SaveChanges();
        }

        public void RemoveLiked(string userName, int idFurn)
        {
            Like like = context.Likes.Where(l => l.userName == userName && l.idFurn == idFurn).FirstOrDefault();
            if (like != null)
            {
                context.Likes.Remove(like);
                context.SaveChanges();
            }
        }
    }
}