using System.Data.Entity;
using ApplicationModel.Models;

namespace ApplicationModel
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<AboutInformation> AboutInformation { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}