using Microsoft.EntityFrameworkCore;

namespace TestRBackend.Models
{
    public class TestContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Server=Server;uid=myuser;password=mypassword;",
                    builder => builder.EnableRetryOnFailure());
            }
        }
        public TestContext()
        {

        }
        public DbSet<User_RobertoEscobar> User_RobertoEscobars { get; set; }        

        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {

        }
    }
}
