using System;
using NetDevPack.Domain;

namespace PlanB.Domain.Entities
{
    public class State : Entity, IAggregateRoot
    {
        public State(Guid id, string nameState, Country country)
        {
            Id = id;
            NameState = nameState;
            Country = country;
        }

        protected State() {}

        public string NameState { get; private set; }
        public virtual Country Country {get; private set;}
        
        
        
    }
}