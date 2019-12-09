﻿// <auto-generated />
using JokeApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JokeApi.Migrations
{
    [DbContext(typeof(JokesContext))]
    [Migration("20191208194330_Seeding")]
    partial class Seeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("JokeApi.Joke", b =>
                {
                    b.Property<int>("JokeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("JokeText")
                        .HasColumnType("TEXT");

                    b.Property<string>("JokeType")
                        .HasColumnType("TEXT");

                    b.HasKey("JokeId");

                    b.ToTable("Jokes");

                    b.HasData(
                        new
                        {
                            JokeId = 1,
                            JokeText = "Why did the invisible man turn down the job offer? He couldn't see himself doing it.",
                            JokeType = "general"
                        },
                        new
                        {
                            JokeId = 2,
                            JokeText = "Why couldn't the bike standup by itself? It was too tired.",
                            JokeType = "general"
                        },
                        new
                        {
                            JokeId = 3,
                            JokeText = "What do you call a deer with no eyes? No eye deer!",
                            JokeType = "general"
                        },
                        new
                        {
                            JokeId = 4,
                            JokeText = "How many tickles does it take to make an octupus laugh? Ten-tickles.",
                            JokeType = "general"
                        },
                        new
                        {
                            JokeId = 5,
                            JokeText = "When a woman is giving birth, she is literally kidding.",
                            JokeType = "general"
                        },
                        new
                        {
                            JokeId = 6,
                            JokeText = "Why did the crab never share? Because he's shellfish.",
                            JokeType = "general"
                        },
                        new
                        {
                            JokeId = 7,
                            JokeText = "What did the buffalo say to his son when he dropped him off at school? Bison.",
                            JokeType = "general"
                        },
                        new
                        {
                            JokeId = 8,
                            JokeText = "Can February March? No, but April May!",
                            JokeType = "general"
                        },
                        new
                        {
                            JokeId = 9,
                            JokeText = "A ham sandwich walks into a bar and orders a beer. The bartender says, \"Sorry, we don't serve food here.\"",
                            JokeType = "general"
                        },
                        new
                        {
                            JokeId = 10,
                            JokeText = "When you ask a dad if he's alright: \"No, I'm half left.\"",
                            JokeType = "general"
                        },
                        new
                        {
                            JokeId = 11,
                            JokeText = "Did you hear about the guy who invented the knock-knock joke? He won the 'no-bell' prize.",
                            JokeType = "general"
                        },
                        new
                        {
                            JokeId = 12,
                            JokeText = "I used to hate facial hair...but then it grew on me.",
                            JokeType = "general"
                        },
                        new
                        {
                            JokeId = 13,
                            JokeText = "I wouldn't buy anything with velcro. It's a total rip-off.",
                            JokeType = "general"
                        },
                        new
                        {
                            JokeId = 14,
                            JokeText = "What do you call a mouse that swears? A cursor.",
                            JokeType = "general"
                        },
                        new
                        {
                            JokeId = 15,
                            JokeText = "What's the difference between a poorly dressed monkey on a tricycle and a well-dressed monkey on a bicycle? Attire.",
                            JokeType = "general"
                        },
                        new
                        {
                            JokeId = 16,
                            JokeText = "Did you know the first French fries weren't actually cooked in France? They were cooked in Greece.",
                            JokeType = "general"
                        },
                        new
                        {
                            JokeId = 17,
                            JokeText = "What do you call someone with no body and no nose? Nobody knows.",
                            JokeType = "general"
                        },
                        new
                        {
                            JokeId = 18,
                            JokeText = "What has two butts and kills people? An assassin.",
                            JokeType = "general"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
