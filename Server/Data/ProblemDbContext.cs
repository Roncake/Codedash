using Codedash.Shared;
using Microsoft.EntityFrameworkCore;

namespace Codedash.Server.Data;

public class ProblemDbContext : DbContext
{
    #region Contructor
    public ProblemDbContext(DbContextOptions<ProblemDbContext> options) : base(options)
    {
    
    }
    #endregion

    #region Public properties
    public DbSet<Problem>? Problem { get; set; }
    #endregion

    #region Overidden methods
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Problem>().HasData(GetProblems());
        base.OnModelCreating(modelBuilder);
    }
    #endregion


    #region Private methods

    private static IEnumerable<Problem> GetProblems()
    {
        return new List<Problem>
        {
            new()
            {
                Id = Guid.NewGuid().ToString().ToLowerInvariant(),
                Chunks = "print(\"Hi\")\u000aprint(\u001f0\u001f-1\u001e\"Hello, World!\"\u001f1\u001f13\u001e)\u001f0\u001f-1",
                Output = "Hi\u000aHello, World!",
                Title = "Sample 0",
                Difficulty = 0,
                IsUserMade = false
            },
            new()
            {
                Id = Guid.NewGuid().ToString().ToLowerInvariant(),
                Chunks = "for i in range(6):\n    print(\u001F0\u001F-1\u001E\"ay\"\u001F1\u001F6\u001E, end='')\nprint('9')\n\nprint('ay' * 64 + '9')\u001F0\u001F-1",
                Output = "ayayayayayay9\u000aayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayayay9",
                Title = "Sample 1",
                Difficulty = 0,
                IsUserMade = false
            }
        };
    }

    #endregion
}