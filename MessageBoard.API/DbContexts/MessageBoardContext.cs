using MessageBoard.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace MessageBoard.API.DbContexts
{
    public class MessageBoardContext : DbContext
    {
        public MessageBoardContext(DbContextOptions<MessageBoardContext> options) : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed with dummy data
            modelBuilder.Entity<Message>().HasData(
                new Message()
                {
                    Id = Guid.Parse("B5C3E2E2-BEB2-4178-BB63-C0A749860FB1"),
                    Body = "It was a bright cold day in April, and the clocks were striking thirteen"
                },
                new Message()
                {
                     Id = Guid.Parse("12D50335-25C5-422A-B010-FBFC7726EF9A"),
                     Body = "It was the best of times, it was the worst of times"
                },
                new Message()
                {
                    Id = Guid.Parse("637EDA53-DC77-4650-B390-3EEFD42C75BF"),
                    Body = "I'll tell you what I want, what I really, really want"
                }
            );
        }
    }
}
