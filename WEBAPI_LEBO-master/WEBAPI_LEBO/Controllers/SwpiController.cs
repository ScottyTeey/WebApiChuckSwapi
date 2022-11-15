using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEBAPI_LEBO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SwpiController : ControllerBase
    {
        // GET: api/<SwpiController>
        /// <summary>
        /// this returns the name of people within the swapi api
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "{id}", "{name}" };
        }

        // GET api/<SwpiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SwpiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SwpiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SwpiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
