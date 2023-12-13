using Domain.Ports;

namespace Data.Guest
{
    public class GuestRepository : IGuestRespository
    {
        private HotelDbContext _context;
        public GuestRepository(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Guest> Create(Domain.Entities.Guest guest)
        {
            await _context.SaveChangesAsync();
            return guest;
        }

        public Task<Domain.Entities.Guest> Get(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
