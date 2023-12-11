using Domain.Enums;

namespace Domain.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }
        public DateTime PlaceAt { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        private Status Status { get; set; }
        public Status CurrentStatus 
        {
            get { return this.Status; }       
        }


    }
}
