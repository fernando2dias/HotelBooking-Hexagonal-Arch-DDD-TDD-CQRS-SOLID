using Domain.Entities;

namespace Domain.Ports
{
    public interface IGuestRespository
    {
        Task<Guest> Get(Guid id);
        Task<Guest> Create(Guest guest);

    }
}
