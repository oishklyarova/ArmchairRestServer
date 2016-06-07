using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armchair_rest_server.Models
{
    public interface IFurnitureWithLikeRepository
    {
        IQueryable<FurnitureWithLike> GetAll(string userName);
    }
}
