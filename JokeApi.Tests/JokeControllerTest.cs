using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace JokeApi.Tests
{
    public class JokeControllerTest
    {
         public JokeControllerTest()
        {
            InitContext();
        }

        private JokesContext _jokesContext;
        private ILogger<JokeController> _logger;

        private void InitContext()
        {
            var builder = new DbContextOptionsBuilder<JokesContext>()
                .UseInMemoryDatabase(databaseName: "jokestestdb");

            var context = new JokesContext(builder.Options);

            var jokes = Enumerable.Range(1,10)
                .Select(i => new Joke { JokeId = i, JokeText = $"Joke{i}", JokeType = "general"});

            context.Jokes.AddRange(jokes);
            _jokesContext = context;

        }

        [Fact]
        public async Task TestGetJokeById()
        {
            string expectedJokeText = "Joke2";
            _logger = Mock.Of<ILogger<JokeController>>();
            JokeController controller = new JokeController(_jokesContext, _logger);
            ActionResult<Joke> result =  await controller.GetJoke(2);
            Joke contentResult = Assert.IsType<Joke>(result.Value);
            Assert.Equal(expectedJokeText, contentResult.JokeText);
        }
    }
}
