using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Armchair_rest_server.Models;

namespace Armchair_rest_server.Controllers
{
    public class FurnitureWithLikeController : ApiController
    {
        private IFurnitureWithLikeRepository repo;
        public int pageSize = 18;

        public FurnitureWithLikeController(IFurnitureWithLikeRepository furnitureWithLikeRepository)
        {
            this.repo = furnitureWithLikeRepository;
        }

        // GET api/furniturewithlike
        public IQueryable<FurnitureWithLike> GetAll(string userName = null, int page = 0)
        {
            return repo.GetAll(userName).OrderBy(f => f.Id).Skip(page * pageSize).Take(pageSize); 
        }

        // GET api/furniturewithlike/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/furniturewithlike
        public void Post([FromBody]string value)
        {
        }

        // PUT api/furniturewithlike/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/furniturewithlike/5
        public void Delete(int id)
        {
        }
    }
}
