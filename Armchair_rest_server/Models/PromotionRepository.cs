using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armchair_rest_server.Models
{
    public class PromotionRepository : IPromotionRepository
    {
        private ArmchairDB context = new ArmchairDB();

        public IEnumerable<Promotion> GetAll()
        {
            return context.Promotions;
        }
    }
}