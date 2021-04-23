using System;
using NetDevPack.Domain;

namespace PlanB.Domain.Entities
{
    public class City : Entity, IAggregateRoot
    {
        public City(Guid id, string nameCity, State state)
        {
            Id = id;
            NameCity = nameCity;
            State = state;
        }

        protected City() {}

        public string NameCity { get; private set; }
        public virtual State State {get; private set;}
        
    }
}