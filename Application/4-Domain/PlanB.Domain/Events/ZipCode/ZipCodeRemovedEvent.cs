using System;
using NetDevPack.Messaging;

namespace PlanB.Domain.Events.ZipCode
{
    public class ZipCodeRemovedEvent : Event
    {
        public ZipCodeRemovedEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }
        
        
        
    }
}