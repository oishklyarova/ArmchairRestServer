using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armchair_rest_server.Models
{
    public interface ILikedRepository
    {
        IQueryable<Liked> GetAll(string userName);
        void CreateLiked(Liked liked);
        void RemoveLiked(string userName, int idFurn);
    }
}
