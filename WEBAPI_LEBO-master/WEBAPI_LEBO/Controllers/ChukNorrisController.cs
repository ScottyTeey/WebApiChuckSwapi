using Microsoft.AspNetCore.Mvc;
using WEBAPI_LEBO.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEBAPI_LEBO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChukNorrisController : ControllerBase
    {
   /// <summary>
   /// This Api is used to get All Chuck norris Jokes
   /// </summary>
   /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Returns all values matches the category 1", "value1", "value2" };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET api/<ChukNorrisController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Retuns values of Chuck using ID";
        }

        // POST api/<ChukNorrisController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ChukNorrisController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ChukNorrisController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
