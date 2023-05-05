namespace Domain.Repositories
{
    public interface INationalityRepository : IGenericRepository<Nationality>
    {
        Nationality? GetByCode(string code);
    }
}
