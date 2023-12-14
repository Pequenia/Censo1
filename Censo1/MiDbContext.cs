using Censo1;
using Microsoft.EntityFrameworkCore;

public class MiDbContext : DbContext
{
    public DbSet<InformacionEquipo> InformacionEquipos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-5GVNUF2;Initial Catalog=Censo;Integrated Security=True");
        
    }
}
