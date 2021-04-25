using NetDevPack.Messaging;
using System;

namespace PlanB.Domain.Core.Events
{
    public class EduedEvet : Event
    {

        
        public EduedEvet(Event theEvent, string data, string user)
        {
            Id = Guid.NewGuid();
            AggregateId = theEvent.AggregateId;
            MessageType = theEvent.MessageType;
            Data = data;
            User = user;
        }
        
        
        // EF Constructor
        protected EduedEvet() { }

        public Guid Id { get; private set; }

        public string Data { get; private set; }

        public string User { get; private set; }

        
    }
}