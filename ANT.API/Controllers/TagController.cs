using ANT.API.Data;
using ANT.API.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ANT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;

        public TagController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category category)
        {
            await applicationDbContext.Categories.AddAsync(category);
            await applicationDbContext.SaveChangesAsync();

            return Ok(category);
        }



    }
}
