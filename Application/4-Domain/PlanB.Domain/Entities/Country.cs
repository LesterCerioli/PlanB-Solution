using System;
using System.Collections.Generic;
using NetDevPack.Domain;

namespace PlanB.Domain.Entities
{
    public class Country : Entity, IAggregateRoot
    {
        public Country(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        protected Country() {}
        public string Name { get; private set; }
        public virtual ICollection<City> Cities {get; private set;}
        
        
        
    }
}