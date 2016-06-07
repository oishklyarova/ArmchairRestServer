using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace Armchair_rest_server.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private static IFeedbackRepository repo = new FeedbackRepository();

        private ArmchairDB context = new ArmchairDB();

        public static IFeedbackRepository getRepository()
        {
            return repo;
        }

        public IEnumerable<Feedback> GetAll()
        {
            return context.Feedbacks;
        }

        public void Add(Feedback item)
        {
            try
            {
                context.Feedbacks.Add(item);
                context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                context.Feedbacks.Remove(item);
                throw;
            }
        }
    }
}