using ANT.API.Models.Domain;

namespace ANT.API.Repositories.Interfacte
{
    public interface ICategoryRepository
    {
        //define the definition of a method and not an actual implementation.
        //definition of a method for Create Category Method 
        Task<Category> CreateAsyn(Category category);


    }
}
