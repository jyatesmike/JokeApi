using Microsoft.EntityFrameworkCore.Migrations;

namespace JokeApi.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "JokeId", "JokeText", "JokeType" },
                values: new object[] { 1, "Why did the invisible man turn down the job offer? He couldn't see himself doing it.", "general" });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "JokeId", "JokeText", "JokeType" },
                values: new object[] { 16, "Did you know the first French fries weren't actually cooked in France? They were cooked in Greece.", "general" });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "JokeId", "JokeText", "JokeType" },
                values: new object[] { 15, "What's the difference between a poorly dressed monkey on a tricycle and a well-dressed monkey on a bicycle? Attire.", "general" });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "JokeId", "JokeText", "JokeType" },
                values: new object[] { 14, "What do you call a mouse that swears? A cursor.", "general" });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "JokeId", "JokeText", "JokeType" },
                values: new object[] { 13, "I wouldn't buy anything with velcro. It's a total rip-off.", "general" });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "JokeId", "JokeText", "JokeType" },
                values: new object[] { 12, "I used to hate facial hair...but then it grew on me.", "general" });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "JokeId", "JokeText", "JokeType" },
                values: new object[] { 11, "Did you hear about the guy who invented the knock-knock joke? He won the 'no-bell' prize.", "general" });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "JokeId", "JokeText", "JokeType" },
                values: new object[] { 10, "When you ask a dad if he's alright: \"No, I'm half left.\"", "general" });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "JokeId", "JokeText", "JokeType" },
                values: new object[] { 9, "A ham sandwich walks into a bar and orders a beer. The bartender says, \"Sorry, we don't serve food here.\"", "general" });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "JokeId", "JokeText", "JokeType" },
                values: new object[] { 8, "Can February March? No, but April May!", "general" });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "JokeId", "JokeText", "JokeType" },
                values: new object[] { 7, "What did the buffalo say to his son when he dropped him off at school? Bison.", "general" });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "JokeId", "JokeText", "JokeType" },
                values: new object[] { 6, "Why did the crab never share? Because he's shellfish.", "general" });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "JokeId", "JokeText", "JokeType" },
                values: new object[] { 5, "When a woman is giving birth, she is literally kidding.", "general" });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "JokeId", "JokeText", "JokeType" },
                values: new object[] { 4, "How many tickles does it take to make an octupus laugh? Ten-tickles.", "general" });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "JokeId", "JokeText", "JokeType" },
                values: new object[] { 3, "What do you call a deer with no eyes? No eye deer!", "general" });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "JokeId", "JokeText", "JokeType" },
                values: new object[] { 2, "Why couldn't the bike standup by itself? It was too tired.", "general" });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "JokeId", "JokeText", "JokeType" },
                values: new object[] { 17, "What do you call someone with no body and no nose? Nobody knows.", "general" });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "JokeId", "JokeText", "JokeType" },
                values: new object[] { 18, "What has two butts and kills people? An assassin.", "general" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "JokeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "JokeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "JokeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "JokeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "JokeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "JokeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "JokeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "JokeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "JokeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "JokeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "JokeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "JokeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "JokeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "JokeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "JokeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "JokeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "JokeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "JokeId",
                keyValue: 18);
        }
    }
}
