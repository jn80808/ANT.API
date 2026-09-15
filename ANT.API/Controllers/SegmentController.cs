using ANT.API.Data;
using ANT.API.Models.Domain;
using ANT.API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ANT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SegmentController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public SegmentController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
   
        }


        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateSegmentRequestDTO dtorequest)
        {

            //Map DTO to Domain Model : api -> dto -> domain
            var segment = new Segment
            {
                Name = dtorequest.Name, //domain = dto.value 
                UrlHandle = dtorequest.UrlHandle
            };

            //db save -- will add in implementation repository
            //await dbContext.Segment.AddAsync(segment);
            //await dbContext.SaveChangesAsync();


            // Domain model to DTO 
            var response = new CategoryDto
            {
                Id = segment.Id,
                Name = segment.Name,
                UrlHandle = segment.UrlHandle
            };

            return Ok(response);

        }



    }
}
