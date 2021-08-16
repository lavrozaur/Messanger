using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPCoreServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mess : ControllerBase
    {
        // GET api/<Mess>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Hochy v VDV"+id.ToString();
        }

        // POST api/<Mess>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Mess>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Mess>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
