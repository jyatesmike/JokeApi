using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JokeApi
{
       public class Joke{
        public int JokeId { get; set; }
        public string JokeType { get; set; }
        public string JokeText { get; set; }
    }
}