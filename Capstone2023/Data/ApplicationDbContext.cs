using Capstone2023.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

namespace Capstone2023.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Admin> Admins { get; set; } = null!;
        public DbSet<Classroom> Classrooms { get; set; } = null!;
        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<Division> Divisions { get; set; } = null!;
        public DbSet<Incident> Incidents { get; set; } = null!;
        public DbSet<Notification> Notifications { get; set; } = null!;
        public DbSet<School> Schools { get; set; } = null!;
        public DbSet<SchoolUser> Schoolusers { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<StudentClassroom> StudentClassrooms { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Capstone2023;Integrated Security=True;");
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}