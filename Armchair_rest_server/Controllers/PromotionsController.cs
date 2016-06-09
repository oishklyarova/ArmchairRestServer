using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Armchair_rest_server.Models;

namespace Armchair_rest_server.Controllers
{
    public class PromotionsController : ApiController
    {
        private IPromotionRepository repo;

        public PromotionsController(IPromotionRepository promotionRepository)
        {
            this.repo = promotionRepository;
        }

        // GET api/promotion
        public IEnumerable<Promotion> GetAllPromotions()
        {
            return repo.GetAll();
        }

        // GET api/promotion/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/promotion
        public void Post([FromBody]string value)
        {
        }

        // PUT api/promotion/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/promotion/5
        public void Delete(int id)
        {
        }
    }
}
