using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace crud_dotnet.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Pessoas> Pessoas { get; set; } = default!;
    public DbSet<Cursos> Cursos { get; set; } = default!;
}

public class Cursos
{
}

public class Pessoas
{
}
