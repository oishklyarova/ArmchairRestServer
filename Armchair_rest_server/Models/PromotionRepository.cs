using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armchair_rest_server.Models
{
    public class PromotionRepository : IPromotionRepository
    {
        private static PromotionRepository repo = new PromotionRepository();

        private ArmchairDB context = new ArmchairDB();

        public static IPromotionRepository getRepository()
        {
            return repo;
        }

        public IEnumerable<Promotion> GetAll()
        {
            return context.Promotions;
        }
    }
}