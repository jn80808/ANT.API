using ANT.API.Data;
using ANT.API.Models.Domain;
using ANT.API.Repositories.Interfacte;
using Microsoft.EntityFrameworkCore;

namespace ANT.API.Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        //contructor ctor 
        public CategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //interface method 
        public async Task<Category> CreateAsyn(Category category)
        {
            //throw new NotImplementedException();
            //db save 
            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return category;
        }
    }
}
