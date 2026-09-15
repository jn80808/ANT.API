using ANT.API.Data;
using ANT.API.Models.Domain;
using ANT.API.Repositories.Interfacte;

namespace ANT.API.Repositories.Implementation
{
    public class SegmentRepository : ISegmentRepository
    {
        private readonly ApplicationDbContext dbContext;

        //constructor 
        public SegmentRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //interface method 
        public async Task<Segment> CreateAsync(Segment segment)
        {
            //throw new NotImplementedException();
            //db save 
            await dbContext.Segment.AddAsync(segment);
            await dbContext.SaveChangesAsync();

            return segment;


        }
    }
}
