using Domain.Entities;

namespace Domain.Ports
{
    public interface IGuestRespository
    {
        Task<Guest> Get(Guid id);
        Task<Guest> Save(Guest guest);

    }
}
