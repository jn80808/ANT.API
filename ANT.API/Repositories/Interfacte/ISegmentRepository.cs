using ANT.API.Models.Domain;

namespace ANT.API.Repositories.Interfacte
{
    public interface ISegmentRepository
    {
        Task<Segment> CreateAsync(Segment segment);


    }
}
