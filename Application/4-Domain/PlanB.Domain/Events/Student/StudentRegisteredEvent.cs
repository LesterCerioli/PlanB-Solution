using System;
using NetDevPack.Messaging;
using PlanB.Domain.ValueObjcts;

namespace PlanB.Domain.Events.Student
{
    public class StudentRegisteredEvent : Event
    {
        public StudentRegisteredEvent(Guid id, string cPF, string firstName, string lastName, DateTime birthDate, Email email)
        {
            Id = id;
            CPF = cPF;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDate = birthDate;
            AggregateId = id;
        }

        public Guid Id { get; set; }
        public string CPF { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Email Email { get; private set; }

    }
}