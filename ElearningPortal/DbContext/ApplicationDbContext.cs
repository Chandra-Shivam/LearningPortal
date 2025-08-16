using ElearningPortal.Models;
using Microsoft.EntityFrameworkCore; // Required for DbContext
using Microsoft.AspNetCore.Identity.EntityFrameworkCore; // Required for IdentityDbContext

namespace ElearningPortal.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add DbSets for your entities here if needed
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }

    }
}
