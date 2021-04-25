using System;
using NetDevPack.Domain;

namespace PlanB.Domain.Entities
{
    public class Email : Entity, IAggregateRoot
    {
        public Email(Guid id, string address)
        {
            Id = id;
            Address = address;
        }

        protected Email() {}
        public string Address { get; private set; }
        
    }
}