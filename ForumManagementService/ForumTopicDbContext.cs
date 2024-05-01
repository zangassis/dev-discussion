using Microsoft.EntityFrameworkCore;

namespace ForumManagementService;
public class ForumTopicDbContext : DbContext
{
    public ForumTopicDbContext(DbContextOptions<ForumTopicDbContext> options) : base(options) { }

    public DbSet<ForumTopic> ForumTopics { get; set; }
}