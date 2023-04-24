using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Lms.Core.Entities.Tournament> Tournament { get; set; } = default!;

        public DbSet<Lms.Core.Entities.Game> Game { get; set; } = default!;
    }
