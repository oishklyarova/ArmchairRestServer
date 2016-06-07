using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Armchair_rest_server.Models;

namespace Armchair_rest_server.Controllers
{
    public class FurnitureController : ApiController
    {
        private IFurnitureRepository repo = FurnitureRepository.getRepository();
        public int pageSize = 18;

        // GET api/furniture
        public IEnumerable<Furniture> GetAllFurniture(int page = 0)
        {
            return repo.GetAll().Skip(page*pageSize).Take(pageSize);
        }

        // GET api/furniture/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/furniture
        public void Post([FromBody]string value)
        {
        }

        // PUT api/furniture/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/furniture/5
        public void Delete(int id)
        {
        }
    }
}
