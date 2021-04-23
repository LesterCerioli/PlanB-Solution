using System;
using NetDevPack.Domain;

namespace PlanB.Domain.Entities
{
    public class Address : Entity, IAggregateRoot
    {
        public Address(Guid id, string street, string number, string neighborhood, ZipCode zipCode, District district)
        {
            Id = id;
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            ZipCode = zipCode;
            District = district;
        }

        protected Address() {}
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }
        
        public virtual ZipCode ZipCode { get; private set; }
        public virtual District District {get; private set;}
        public virtual City City {get; private set;}
        public virtual State State {get; private set;}
        public virtual Country Country {get; private set;}

        
    }
}