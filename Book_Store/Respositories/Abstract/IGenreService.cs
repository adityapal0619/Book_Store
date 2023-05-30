using Book_Store.Models.Domain;

namespace Book_Store.Respositories.Abstract
{
    public interface IGenreService
    {
        bool Add(Genre model);
        bool Update (Genre model);
        bool Delete (int id);
        Genre FindById (int id);
        
        IEnumerable<Genre> GetAll();

    }
}
