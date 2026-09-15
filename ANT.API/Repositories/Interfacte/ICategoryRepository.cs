using ANT.API.Models.Domain;

namespace ANT.API.Repositories.Interfacte
{
    public interface ICategoryRepository
    {
        //define the definition of a method and not an actual implementation.

        Task<Category> CreateAsyn(Category category);


    }
}
