using ANT.API.Data;
using ANT.API.Models.Domain;
using ANT.API.Models.DTO;
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

        public async Task<IEnumerable <Category>> GetAllAsync()
        {
            return await dbContext.Categories.ToListAsync();
        }

        public async Task<Category?> GetById(Guid id)
        {
            return await dbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);
        }



        public async Task<CategoryNameDto?> GetByName(string name)
        {
            var categories = await dbContext.CategoryNameResults
                .FromSqlInterpolated(
                    $"EXEC dbo.PRC_GetBY_Name @Name={name}")
                .ToListAsync();

            var category = categories.FirstOrDefault();

            if (category is null)
            {
                return null;
            }

            return new CategoryNameDto
            {
                Name = category.Name,
                UrlHandle = category.UrlHandle
            };
        }


    }
}
