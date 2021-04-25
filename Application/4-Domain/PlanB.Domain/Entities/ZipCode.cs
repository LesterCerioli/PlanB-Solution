using System;
using NetDevPack.Domain;

namespace PlanB.Domain.Entities
{
    public class ZipCode : Entity, IAggregateRoot
    {
        public ZipCode(Guid id, string zipNumber)
        {
            Id = id;
            ZipNumber = zipNumber;
        }

        protected ZipCode() {}
        public string ZipNumber { get; private set; }
        
        
        
    }
}