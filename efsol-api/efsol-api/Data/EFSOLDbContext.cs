using efsol_api.Data.Entities;
using efsol_api.Enums;
using Microsoft.EntityFrameworkCore;
using System;

namespace efsol_api.Data
{
    public class EFSOLDbContext : DbContext
    {
        public EFSOLDbContext(DbContextOptions<EFSOLDbContext> options) : base(options) { }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var data = new Question[] {
                new Question {
                    Id = Guid.NewGuid(),
                    Content = "Name",
                    SortOrder = 1,
                    Type = QuestionType.Open
                },
                new Question {
                    Id = Guid.NewGuid(),
                    Content = "Age",
                    SortOrder = 2,
                    Type = QuestionType.Integer
                },
                new Question {
                    Id = Guid.NewGuid(),
                    Content = "Gender",
                    SortOrder = 3,
                    Type = QuestionType.Enumeration
                },
                new Question {
                    Id = Guid.NewGuid(),
                    Content = "Date of birth",
                    SortOrder = 4,
                    Type = QuestionType.Date
                },
                new Question {
                    Id = Guid.NewGuid(),
                    Content = "Maritial status",
                    SortOrder = 5,
                    Type = QuestionType.Enumeration
                },
                new Question {
                    Id = Guid.NewGuid(),
                    Content = "Do you love programming?",
                    SortOrder = 6,
                    Type = QuestionType.Boolean
                },
            };

            builder.Entity<Question>()
                .HasData(data);

            builder.Entity<Question>()
                .HasIndex(e => e.SortOrder)
                .IsUnique();

            base.OnModelCreating(builder);
        }
    }
}
