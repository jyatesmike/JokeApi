using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JokeApi
{
    public class JokesContext : DbContext
    {
        public JokesContext(DbContextOptions<JokesContext> options)
            :base(options)
        {}

        public DbSet<Joke> Jokes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             #region JokeSeed
            modelBuilder.Entity<Joke>().HasData(
                new Joke() { JokeId = 1, JokeType = "general", JokeText = "Why did the invisible man turn down the job offer? He couldn't see himself doing it." },
                new Joke() { JokeId = 2, JokeType = "general", JokeText = "Why couldn't the bike standup by itself? It was too tired." },
                new Joke() { JokeId = 3, JokeType = "general", JokeText = "What do you call a deer with no eyes? No eye deer!" },
                new Joke() { JokeId = 4, JokeType = "general", JokeText = "How many tickles does it take to make an octupus laugh? Ten-tickles." },
                new Joke() { JokeId = 5, JokeType = "general", JokeText = "When a woman is giving birth, she is literally kidding." },
                new Joke() { JokeId = 6, JokeType = "general", JokeText = "Why did the crab never share? Because he's shellfish." },
                new Joke() { JokeId = 7, JokeType = "general", JokeText = "What did the buffalo say to his son when he dropped him off at school? Bison." },
                new Joke() { JokeId = 8, JokeType = "general", JokeText = "Can February March? No, but April May!" },
                new Joke() { JokeId = 9, JokeType = "general", JokeText = "A ham sandwich walks into a bar and orders a beer. The bartender says, \"Sorry, we don't serve food here.\"" },
                new Joke() { JokeId = 10, JokeType = "general", JokeText = "When you ask a dad if he's alright: \"No, I'm half left.\"" },
                new Joke() { JokeId = 11, JokeType = "general", JokeText = "Did you hear about the guy who invented the knock-knock joke? He won the 'no-bell' prize." },
                new Joke() { JokeId = 12, JokeType = "general", JokeText = "I used to hate facial hair...but then it grew on me." },
                new Joke() { JokeId = 13, JokeType = "general", JokeText = "I wouldn't buy anything with velcro. It's a total rip-off." },
                new Joke() { JokeId = 14, JokeType = "general", JokeText = "What do you call a mouse that swears? A cursor." },
                new Joke() { JokeId = 15, JokeType = "general", JokeText = "What's the difference between a poorly dressed monkey on a tricycle and a well-dressed monkey on a bicycle? Attire." },
                new Joke() { JokeId = 16, JokeType = "general", JokeText = "Did you know the first French fries weren't actually cooked in France? They were cooked in Greece." },
                new Joke() { JokeId = 17, JokeType = "general", JokeText = "What do you call someone with no body and no nose? Nobody knows." },
                new Joke() { JokeId = 18, JokeType = "general", JokeText = "What has two butts and kills people? An assassin." }
                );
            #endregion
        }
    }
}