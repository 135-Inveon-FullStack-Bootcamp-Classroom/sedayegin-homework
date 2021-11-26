using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _6_InveonMoviesWebApi.Concrete;
using _6_InveonMoviesWebApi.Data;

namespace _6_InveonMoviesWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProducersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producer>>> GetProducers()
        {
            return await _context.Producers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Producer>> GetProducer(int id)
        {
            var producer = await _context.Producers.FindAsync(id);

            if (producer == null)
            {
                return NotFound();
            }

            return producer;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducer(int id, Producer producer)
        {
            if (id != producer.Id)
            {
                return BadRequest();
            }

            _context.Entry(producer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProducerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Producer>> PostProducer(Producer producer)
        {
            _context.Producers.Add(producer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducer", new { id = producer.Id }, producer);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducer(int id)
        {
            var producer = await _context.Producers.FindAsync(id);
            if (producer == null)
            {
                return NotFound();
            }

            _context.Producers.Remove(producer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProducerExists(int id)
        {
            return _context.Producers.Any(e => e.Id == id);
        }
    }
}
