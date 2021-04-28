using System;
using NetDevPack.Messaging;

namespace PlanB.Domain.Events.Student
{
    public class StudentUpdatedEvent : Event
    {
        public StudentUpdatedEvent(Guid id, string cPF, string firstName, string lastName)
        {
            Id = id;
            CPF = cPF;
            FirstName = firstName;
            LastName = lastName;
            AggregateId = id;
        }

        public Guid Id { get; set; }
        public string CPF { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        
    }
}