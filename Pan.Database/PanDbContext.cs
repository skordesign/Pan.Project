using Microsoft.EntityFrameworkCore;
using Pan.Models.Models;
namespace Pan.Database
{
    public class PanDbContext:DbContext
    {
        public PanDbContext(DbContextOptions<PanDbContext> options)
           : base(options)
        {
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<ProjectTeam> ProjectTeams { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }
        public DbSet<ProjectMember> ProjectMembers { get; set; }
        public DbSet<Position> Positions { get; set; }

        public DbSet<PanTask> Tasks { get; set; }
        public DbSet<TaskMember> TaskMembers { get; set; }
        public DbSet<Attach> Attachs { get; set; }
        public DbSet<Comment> Commnet { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Project>().HasKey(o => o.Id);
            builder.Entity<Project>().HasMany(m => m.ProjectMembers)
                .WithOne(o => o.Project)
                .HasForeignKey(f=>f.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Project>().HasMany(m => m.ProjectTeams)
                .WithOne(o => o.Project)
                .HasForeignKey(f=>f.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Project>().HasMany(m => m.Tasks)
                .WithOne(o => o.Project)
                .HasForeignKey(f => f.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Project>().HasMany(m => m.Attachs)
                .WithOne(o => o.Project)
                .HasForeignKey(f => f.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Member>().HasKey(k => k.Id);
            builder.Entity<Member>().HasMany(m => m.ProjectMembers)
                .WithOne(o => o.Member)
                .HasForeignKey(f=>f.MemberId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Member>().HasMany(m => m.TeamMembers)
                .WithOne(o => o.Member)
                .HasForeignKey(f=>f.MemberId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ProjectTeam>().HasKey(k => new { k.ProjectId, k.TeamId });

            builder.Entity<Team>().HasKey(k => k.Id);
            builder.Entity<Team>().HasMany(m => m.ProjectTeams)
                .WithOne(o => o.Team)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Team>().HasMany(m => m.TeamMembers)
                .WithOne(o => o.Team)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<TeamMember>().HasKey(k => new { k.TeamId, k.MemberId });

            builder.Entity<ProjectType>().HasKey(k => k.Id);
            builder.Entity<ProjectType>().HasMany(m => m.Projects)
                .WithOne(o => o.ProjectType)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<ProjectMember>().HasKey(k => new { k.ProjectId, k.MemberId });

            builder.Entity<Position>().HasKey(k => k.Id);
            builder.Entity<Position>().HasMany(m => m.TeamMembers)
                .WithOne(o => o.Position)
                .OnDelete(DeleteBehavior.SetNull);
            builder.Entity<Position>().HasMany(m => m.ProjectMembers)
                .WithOne(o => o.Position)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<PanTask>().HasKey(k => k.Id);
            builder.Entity<PanTask>().HasMany(m => m.SubTasks)
                .WithOne(f => f.ParentTask)
                .HasForeignKey(f => f.ParentTaskId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<PanTask>().HasMany(m => m.TaskMembers)
                .WithOne(o => o.Task)
                .HasForeignKey(f => f.TaskId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<PanTask>().HasMany(m => m.Attachs)
                .WithOne(o => o.Task)
                .HasForeignKey(f => f.PanTaskId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<TaskMember>().HasKey(k => new { k.MemberId, k.TaskId });

            builder.Entity<Attach>().HasKey(k => k.Id);

            builder.Entity<Comment>().HasKey(f => f.Id);
            builder.Entity<Comment>().HasOne(o => o.Attach)
                .WithOne(o => o.Comment)
                .HasForeignKey<Attach>(f => f.CommentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Category>().HasKey(k => k.Id);
            builder.Entity<Category>().HasMany(m => m.PanTasks)
                .WithOne(o => o.Category)
                .HasForeignKey(f => f.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
