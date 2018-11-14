using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularDemo.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace AngularDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;

        }
        // GET api/values
        [HttpGet]
        public IActionResult GetValues()
        {

                var value =  _context.ValuesT.ToList();

            //return new string[] { "value1", "value2" };
            return Ok(value);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetValues(int id)
        {
            var values = _context.ValuesT.FirstOrDefault(x => x.Id == id).ToString();
            return Ok(values);
            //return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
