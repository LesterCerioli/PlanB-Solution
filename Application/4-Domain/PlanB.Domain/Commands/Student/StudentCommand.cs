using System;
using NetDevPack.Messaging;
using PlanB.Domain.Entities;
using PlanB.Domain.ValueObjcts;

namespace PlanB.Domain.Commands.Student
{
    public abstract class StudentCommand : Command
    {
        public Guid Id { get; protected set; }
                
        public string CPF { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public Subscription Subscription { get; protected set; }
        public DateTime BirthDate { get; protected set; }
        public Email Email { get; protected set; }



    }
}