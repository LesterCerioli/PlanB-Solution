using System;
using NetDevPack.Messaging;

namespace PlanB.Domain.Events.Payment
{
    public class PaymentRemovedEvent : Event
    {
        public PaymentRemovedEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }
        
        
        
        
    }
}