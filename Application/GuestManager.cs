using Application.Guest.DTO;
using Application.Guest.Ports;
using Application.Guest.Requests;
using Application.Guest.Responses;
using Domain.Ports;

namespace Application
{
    public class GuestManager : IGuestManager
    {
        private IGuestRespository _repository;
        public GuestManager(IGuestRespository repository) 
        {
            _repository = repository;
        }

        public async Task<GuestResponse> CreateGuest(CreateGuestRequest request)
        {
            try
            {
                var guest = GuestDTO.MapToEntity(request.Data);

                await _repository.Create(guest);

                return new GuestResponse
                {
                    Data = request.Data,
                    Success = true,
                };
            }
            catch (Exception e)
            {
                return new GuestResponse
                {
                    Success = false,
                    ErrorCodes = ErrorCodes.COULDNOT_STORE_DATA,
                    Message = $"There was an error when saving to DB: {e.Message}"
                };
            }

        }
    }
}
