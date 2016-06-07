using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Armchair_rest_server.Models;

namespace Armchair_rest_server.Controllers
{
    public class LikedController : ApiController
    {
        private ILikedRepository repo = LikedRepository.getRepository();

        // GET api/liked
        [Authorize]
        public IQueryable<Liked> GetAllLiked(string userName)
        {
            return repo.GetAll(userName);
        }

        // GET api/liked/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/liked
        [Authorize]
        public void PostLiked(Liked liked)
        {
            repo.CreateLiked(liked);
        }

        // PUT api/liked/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/liked/5
        [Authorize]
        public void Delete(string userName, int idFurn)
        {
            repo.RemoveLiked(userName, idFurn);
        }
    }
}
