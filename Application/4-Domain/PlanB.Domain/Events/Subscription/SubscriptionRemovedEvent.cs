using System;
using NetDevPack.Messaging;

namespace PlanB.Domain.Events.Subscription
{
    public class SubscriptionRemovedEvent : Event
    {
        public SubscriptionRemovedEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }
        
        
        
    }
}