using ANT.API.Data;
using ANT.API.Models.Domain;
using ANT.API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace ANT.API.Controllers
{
    //https://localhost:xxxx/api/categories
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public CategoriesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //
        [HttpPost]
        public async Task<IActionResult>CreateCategory(CreateCategoryRequestDTO request)
        {

            //Map DTO to Domain Model : api -> dto -> domain
            var category = new Category
            {
                Name = request.Name, //domain = dto.value 
                UrlHandle = request.UrlHandle
            };

            //db save  -- will add in implementation repository
            //await dbContext.Segment.AddAsync(segment);
            //await dbContext.SaveChangesAsync();


            // Domain model to DTO 
            var response = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle = category.UrlHandle
            };

            return Ok(response);

        }
     
    }

}
