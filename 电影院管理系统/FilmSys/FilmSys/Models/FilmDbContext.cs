using Microsoft.EntityFrameworkCore;

namespace FilmSys.Models
{
    public class FilmDbContext:DbContext
    {
        public FilmDbContext(DbContextOptions<FilmDbContext> options) : base(options) { }
        public DbSet<Admin> Admins{ get; set; }
        public DbSet<DepartmentType> DepartmentTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Film> Films{ get; set; }
        public DbSet<FilmT> FilmTs{ get; set; }
        public DbSet<FilmType> FilmTypes{ get; set; }
        public DbSet<UInformation> UInformations { get; set; }
        public DbSet<UReserve> UReserves { get; set; }

    }
}
