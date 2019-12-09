using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace JokeApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokeController : ControllerBase
    {
        private readonly JokesContext _context;
        private readonly ILogger _logger;

        public JokeController(JokesContext context, ILogger<JokeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Gets list of jokes
        /// </summary>
        // GET: api/Joke
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Joke>>> GetJokes(string category, string searchString)
        {
            var jokes = from j in _context.Jokes 
                select j;
            
            if(!String.IsNullOrEmpty(category))
                jokes = jokes.Where(j => j.JokeType.ToLower().Equals(category.ToLower()));

            if(!String.IsNullOrEmpty(searchString))
                jokes = jokes.Where(j => j.JokeText.ToLower().Contains(searchString.ToLower()));
            
            return await jokes.ToListAsync();
        }

        /// <summary>
        /// Gets a random joke
        /// </summary>
        [HttpGet("/Joke/random")]
        public async Task<ActionResult<Joke>> GetRandomJoke()
        {   
            var rand = new Random();
            var skip = (int)(rand.NextDouble() * _context.Jokes.Count());
            var joke = _context.Jokes.OrderBy(j => j.JokeId).Skip(skip).Take(1);
            
            return await joke.FirstAsync();
        }

        /// <summary>
        /// Gets paginated list of jokes
        /// </summary>
        [HttpGet("/Joke/page/{page}/size/{size}")]
        public async Task<ActionResult<PaginatedList<Joke>>> GetJokes(int page, int size, string category, string searchString)
        {
            var jokes = from j in _context.Jokes 
                select j;

            if(!String.IsNullOrEmpty(category))
                jokes = jokes.Where(j => j.JokeType.ToLower().Equals(category.ToLower()));

            if(!String.IsNullOrEmpty(searchString))
                jokes = jokes.Where(j => j.JokeText.ToLower().Contains(searchString.ToLower()));

            return await PaginatedList<Joke>.CreateAsync(jokes.AsNoTracking(),page,size);
        }

        /// <summary>
        /// Gets a specific joke by id
        /// </summary>
        // GET: api/Joke/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Joke>> GetJoke(int id)
        {
            var joke = await _context.Jokes.FindAsync(id);

            if (joke == null)
            {
                _logger.LogWarning(LoggingEvents.GetJokeNotFound, "Getting joke {Id} NOT FOUND", id);
                return NotFound();
            }

            return joke;
        }

        /// <summary>
        /// Updates a joke specified by id
        /// </summary>
        // PUT: api/Joke/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJoke(int id, Joke joke)
        {
            if (id != joke.JokeId)
            {
                _logger.LogWarning(LoggingEvents.PutJokeBadRequest, "PutJoke({Id)} - Id ({Id2}) does not match body ({Id3})", id, id, joke.JokeId);
                return BadRequest();
            }

            _context.Entry(joke).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!JokeExists(id))
                {
                    _logger.LogWarning(LoggingEvents.PutJokeNotFound, "PutJoke({Id}) - Joke NOT FOUND", id);
                    return NotFound();
                }
                else
                {
                    _logger.LogError(LoggingEvents.PutJokeConcurrencyException, ex, "PutJoke({Id}) - concurrency exception occured", id);
                    throw;
                }
            }

            return NoContent();
        }

        /// <summary>
        /// Adds a new joke to database
        /// </summary>
        // POST: api/Joke
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Joke>> PostJoke(Joke joke)
        {
            _context.Jokes.Add(joke);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJoke", new { id = joke.JokeId }, joke);
        }

        /// <summary>
        /// Deletes a joke specified by id
        /// </summary>
        // DELETE: api/Joke/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Joke>> DeleteJoke(int id)
        {
            var joke = await _context.Jokes.FindAsync(id);
            if (joke == null)
            {
                return NotFound();
            }

            _context.Jokes.Remove(joke);
            await _context.SaveChangesAsync();

            return joke;
        }

        private bool JokeExists(int id)
        {
            return _context.Jokes.Any(e => e.JokeId == id);
        }
    }
}
