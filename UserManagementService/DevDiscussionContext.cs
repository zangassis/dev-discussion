using Microsoft.EntityFrameworkCore;

namespace UserManagementService;

public partial class DevDiscussionContext : DbContext
{
    public DevDiscussionContext()
    {
    }

    public DevDiscussionContext(DbContextOptions<DevDiscussionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }  

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_dbo.Users");

            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
