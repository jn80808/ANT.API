using ANT.API.Models.Domain;
using ANT.API.Models.DTO;

namespace ANT.API.Repositories.Interfacte
{
    public interface ICategoryRepository
    {
        //define the definition of a method and not an actual implementation.
        //definition of a method for Create Category Method 
        Task<Category> CreateAsyn(Category category);

        Task<IEnumerable<Category>> GetAllAsync();

        Task<Category?> GetById(Guid id);



        // for SP
        Task<CategoryNameDto?> GetByName(string name);
    }
}
