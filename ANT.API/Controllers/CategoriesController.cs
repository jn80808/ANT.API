using ANT.API.Data;
using ANT.API.Models.Domain;
using ANT.API.Models.DTO;
using ANT.API.Repositories.Implementation;
using ANT.API.Repositories.Interfacte;
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
        private readonly ICategoryRepository categoryReposiory;


        //Controller -> DTO -> Repository
        public CategoriesController(ICategoryRepository categoryReposiory)
        {
            this.categoryReposiory = categoryReposiory;
        }


        //Post 
        [HttpPost]
        public async Task<IActionResult>CreateCategory(CreateCategoryRequestDTO request)
        {

            //Map DTO to Domain Model : api -> dto -> domain
            var category = new Category
            {
                Name = request.Name, //domain = dto.value 
                UrlHandle = request.UrlHandle
            };

            await categoryReposiory.CreateAsyn(category);


            // Domain model to DTO 
            var response = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle = category.UrlHandle
            };

            return Ok(response);

        }

        //HTTPGET 
        //GET : /api/ categories
        [HttpGet]
        public async Task <IActionResult > GetAllCategories()
        {
            var categories = await categoryReposiory.GetAllAsync();

            //Map Domain model to DTO 
            var response = new List<CategoryDto>();
            foreach (var category in categories)
            {
                response.Add(new CategoryDto
                {
                    Id = category.Id,
                    Name = category.Name,
                    UrlHandle = category.UrlHandle
                });

            }
            return Ok(response);

        }



     
    }

}
