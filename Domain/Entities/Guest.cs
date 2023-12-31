﻿using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Guest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public PersonId DocumentId { get; set; }
    }
}
