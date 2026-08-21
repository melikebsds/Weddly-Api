using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Api.Entities;

namespace WeddingPlanner.Api.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();

    public DbSet<WeddingSpace> WeddingSpaces => Set<WeddingSpace>();

    public DbSet<CoupleMember> CoupleMembers => Set<CoupleMember>();

    public DbSet<Category> Categories => Set<Category>();

    public DbSet<WeddingTask> WeddingTasks => Set<WeddingTask>();

    public DbSet<Invitation> Invitations => Set<Invitation>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(u => u.Email).IsUnique();
            entity.Property(u => u.Name).HasMaxLength(200);
            entity.Property(u => u.Email).HasMaxLength(320);
        });

        modelBuilder.Entity<WeddingSpace>(entity =>
        {
            entity.Property(w => w.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<CoupleMember>(entity =>
        {
            entity.HasIndex(m => new { m.UserId, m.WeddingSpaceId }).IsUnique();

            entity.HasOne(m => m.User)
                .WithMany(u => u.CoupleMemberships)
                .HasForeignKey(m => m.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(m => m.WeddingSpace)
                .WithMany(w => w.Members)
                .HasForeignKey(m => m.WeddingSpaceId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(c => c.Name).HasMaxLength(200);

            entity.HasOne(c => c.WeddingSpace)
                .WithMany(w => w.Categories)
                .HasForeignKey(c => c.WeddingSpaceId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<WeddingTask>(entity =>
        {
            entity.Property(t => t.Title).HasMaxLength(300);
            entity.Property(t => t.EstimatedPrice).HasColumnType("decimal(18,2)");
            entity.Property(t => t.ActualPrice).HasColumnType("decimal(18,2)");

            entity.HasOne(t => t.Category)
                .WithMany(c => c.Tasks)
                .HasForeignKey(t => t.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Invitation>(entity =>
        {
            entity.HasIndex(i => i.InvitationCode).IsUnique();
            entity.Property(i => i.InvitationCode).HasMaxLength(50);

            entity.HasOne(i => i.WeddingSpace)
                .WithMany(w => w.Invitations)
                .HasForeignKey(i => i.WeddingSpaceId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
