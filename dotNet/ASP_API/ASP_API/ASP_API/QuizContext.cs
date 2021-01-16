using System;
using Microsoft.EntityFrameworkCore;

namespace ASP_API
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options) : base(options) { }
        
        public DbSet<Models.Question> questions { get; set; }
        public DbSet<Models.Quiz> quizzes { get; set; }

    }
    

}

