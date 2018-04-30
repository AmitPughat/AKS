using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using AKS_API.Model;
using AKS_API.Data;

namespace AKS_API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class HeroesController : Controller
    {
        private HeroRepository _repository = new HeroRepository();

        //public HeroesController(HeroRepository repository)
        //{
        //    _repository = repository;
        //}

        // GET api/values
        [HttpGet]
        public IEnumerable<Hero> Get()
        {
            return _repository.GiveMeAllHeroes();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
