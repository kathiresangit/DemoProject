using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        // GET: api/<CandidateController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Candidate1", "Candidate2","Candidate3","Candidate4" };
        }

        // GET api/<CandidateController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CandidateController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CandidateController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CandidateController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
