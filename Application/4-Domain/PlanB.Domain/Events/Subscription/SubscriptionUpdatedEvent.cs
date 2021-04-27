using System;
using NetDevPack.Messaging;

namespace PlanB.Domain.Events.Subscription
{
    public class SubscriptionUpdatedEvent : Event
    {
        public SubscriptionUpdatedEvent(Guid id, DateTime createDate, DateTime lastUpdateDate, DateTime? expireDate, bool active, long subNumber)
        {
            Id = id;
            CreateDate = createDate;
            LastUpdateDate = lastUpdateDate;
            ExpireDate = expireDate;
            Active = active;
            SubNumber = subNumber;
            AggregateId = id;
        }

        public Guid Id { get; set; }
        
        
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active { get; private set; }
        public long SubNumber {get; private set;}
        
    }
}