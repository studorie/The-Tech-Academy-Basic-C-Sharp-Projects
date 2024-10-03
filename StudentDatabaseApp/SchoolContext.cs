using System.Data.Entity;

public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
}
