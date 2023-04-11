namespace FilmSys.Models
{
    public interface IFilmRepository
    {
        IQueryable<Admin> GetAdmins { get; }
        IQueryable<DepartmentType> DepartmentTypes { get; }
        IQueryable<Employee> Employees { get; }
        IQueryable<Film> Films { get; }
        IQueryable<FilmT> FilmTs { get; }
        IQueryable<FilmType> FilmTypes { get; }
        IQueryable<UInformation> UInformations { get; }
        IQueryable<UReserve> UReserves { get; }
    }
}
