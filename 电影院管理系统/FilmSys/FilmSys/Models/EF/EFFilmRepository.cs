namespace FilmSys.Models.EF
{
    public class EFFilmRepository:IFilmRepository
    {
        private FilmDbContext context;
        public EFFilmRepository(FilmDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Admin> GetAdmins => context.Admins;
        public IQueryable<DepartmentType> DepartmentTypes => context.DepartmentTypes;
        public IQueryable<Employee> Employees => context.Employees;
        public IQueryable<Film> Films=> context.Films;
        public IQueryable<FilmT> FilmTs=> context.FilmTs;
        public IQueryable<FilmType> FilmTypes=> context.FilmTypes;
        public IQueryable<UInformation> UInformations => context.UInformations;
        public IQueryable<UReserve> UReserves => context.UReserves;
    }
}
