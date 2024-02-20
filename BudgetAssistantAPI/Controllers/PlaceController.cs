using BudgetAssistantAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BudgetAssistantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        private readonly BudgetAssistantDbContext _context;

        public PlaceController(BudgetAssistantDbContext context)
        {
            _context = context;
        }

        // GET: api/<PlaceController>
        [HttpGet]
        public IEnumerable<Place> Get()
        {
            return _context.Places.ToList();
        }

        // GET api/<PlaceController>/5
        [HttpGet("{id}")]
        public Place Get(int id)
        {
            return _context.Places.Where(p=> p.Id == id).FirstOrDefault();
        }

        // POST api/<PlaceController>
        [HttpPost]
        public void Post([FromBody] Place value)
        {
            _context.Add(value);
            _context.SaveChanges();
        }

        // PUT api/<PlaceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Place value)
        {
            var place = _context.Places.Where(p => p.Id == id).FirstOrDefault();
            if (place != null)
            {
                place.PlaceName = value.PlaceName;
                _context.SaveChanges();
            }
        }

        // DELETE api/<PlaceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var place = _context.Places.Where(p => p.Id == id).FirstOrDefault();
            if (place != null)
            {
                _context.Places.Remove(place);
                _context.SaveChanges();
            }
        }
    }
}
