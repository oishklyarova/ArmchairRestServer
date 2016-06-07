using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Armchair_rest_server.Models;

namespace Armchair_rest_server.Controllers
{
    public class FeedbackController : ApiController
    {
        private IFeedbackRepository repo = FeedbackRepository.getRepository();

        // GET api/feedback
        public IEnumerable<Feedback> GetAllFeedbacks()
        {
            return repo.GetAll();
        }

        // GET api/feedback/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/feedback
        [HttpPost]
        public void CreateFeedback(Feedback item)
        {
            repo.Add(item);
        }

        // PUT api/feedback/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/feedback/5
        public void Delete(int id)
        {
        }
    }
}
