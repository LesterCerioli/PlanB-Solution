namespace PlanB.Domain.Core.Events
{
    public class EduedEvet : Event
    {

        
        public EduedEvent(Event theEvent, string data, string user)
        {
            Id = Guid.NewGuid();
            AggregateId = theEvent.AggregateId;
            MessageType = theEvent.MessageType;
            Data = data;
            User = user;
        }
        
        
        // EF Constructor
        protected EduedEvent() { }

        public Guid Id { get; private set; }

        public string Data { get; private set; }

        public string User { get; private set; }

        
    }
}