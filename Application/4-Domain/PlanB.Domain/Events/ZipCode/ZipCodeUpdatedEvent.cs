using System;
using NetDevPack.Messaging;

namespace PlanB.Domain.Events.ZipCode
{
    public class ZipCodeUpdatedEvent : Event
    {

        public Guid Id { get; set; }
        public string ZipNumber { get; private set; }
        
    }
}