using System;
using Domain.Entities.Users;

namespace Domain.Entities
{
    public abstract class ExtendedEntity : Entity
    {
        protected ExtendedEntity()
        {
        }

        public User User { get; set; }

        public DateTime Date { get; set; }

     } 
}
