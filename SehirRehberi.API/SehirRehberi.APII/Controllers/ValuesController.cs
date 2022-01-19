using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SehirRehberi.API.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SehirRehberi.APII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<ActionResult> GetValues()
        {
            var value = await _context.Values.ToListAsync();
            return Ok(value);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async  Task<ActionResult> Get(int id)
        {
             var value = await _context.Values.FirstOrDefaultAsync(c => c.Id == id);
             return Ok(value);
        }


        // POST api/<ValuesController>
        [HttpPost] //db ye  veri postalama 
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]// dbdeki veriyi güncelleme
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]  //db deki veriyi silme
        public void Delete(int id)
        {
        }
    }
}
