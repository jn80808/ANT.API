using ANT.API.Data;
using ANT.API.Models.Domain;
using ANT.API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ANT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisionController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public DivisionController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }



        [HttpPost]
        public async Task<IActionResult> CreateDivision(CreateCategoryRequestDTO dtorequest)
        {
            //DTO to DomainModel 
            var division = new Division
            {
                Name = dtorequest.Name,
                UrlHandle = dtorequest.UrlHandle,
            };

            //db save 
            await dbContext.Division.AddAsync(division);
            await dbContext.SaveChangesAsync();


            // Domain model to DTO 
            var response = new DivisionDto
            {
                Id = division.Id,
                Name = division.Name,
                UrlHandle = division.UrlHandle
            };

            return Ok(response);




        }



    }
}
