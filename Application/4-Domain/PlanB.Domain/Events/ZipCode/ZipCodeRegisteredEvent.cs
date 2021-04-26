using System;
using NetDevPack.Messaging;

namespace PlanB.Domain.Events.ZipCode
{
    public class ZipCodeRegisteredEvent : Event
    {
        public ZipCodeRegisteredEvent(Guid id, string zipNumber)
        {
            Id = id;
            ZipNumber = zipNumber;
            AggregateId = id;
        }

        public Guid Id { get; set; }
        public string ZipNumber { get; private set; }
        
        
        
    }
}