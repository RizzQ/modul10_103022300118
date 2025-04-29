using Microsoft.AspNetCore.Mvc;

namespace modul10_103022300118.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class MoviesController : ControllerBase
        {
            static List<String> pemainMovie1 = new List<String> { new string("Tim Robbins"), new string("Morgan Freeman"), new string("Bob Gunton") };
            static List<String> pemainMovie2 = new List<String> { new string("Marlon Brando"), new string("Al Pacino"), new string("James Caan") };
            static List<String> pemainMovie3 = new List<String> { new string("Christian Bale"), new string("Health Ledger"), new string("Aaron Eckhart") };

            private static List<Movies> movies = new List<Movies>{
            new("The Shawshank Redemption", "Frank Darabont", pemainMovie1, "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new("The Godfather", "Francis Ford Coppola", pemainMovie2,"The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new("The Dark Knight", "Christopher Nolan", pemainMovie3, "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness."),
        };
            // GET: api/<ValuesController>
            [HttpGet]
            public List<Movies> Get()
            {
                return movies;
            }

            // GET api/<ValuesController>/5
            [HttpGet("{id}")]
            public Movies Get(int id)
            {
                return movies[id];
            }

            // POST api/<ValuesController>
            [HttpPost]
            public void Post([FromBody] Movies m)
            {
                movies.Add(m);
            }

            // DELETE api/<ValuesController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
                movies.RemoveAt(id);
            }
        }
    }
