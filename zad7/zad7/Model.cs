using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    public string ConnectionString { get; }

    public BloggingContext(string connectionString)
    {
        this.ConnectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(this.ConnectionString);
    }
}

public class Blog
{
    public long Id { get; set; }
    public string Url { get; set; }

    public List<Post> Posts { get; } = new List<Post>();
}

public class Post
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public long BlogId { get; set; }
    public Blog Blog { get; set; }
}

public class User
{
    public long Id { get; set; }
    public string FullName { get; set; }
    public long TaskId { get; set; }
    public long RoleId { get; set; }
}

public class Roles
{
    public long Id { get; set; }
    public string RoleName { get; set; }
}

public class Tasks
{
    public long Id { get; set; }
    public string TaskName { get; set; }
    public string TaskDescrytion { get; set; }
}