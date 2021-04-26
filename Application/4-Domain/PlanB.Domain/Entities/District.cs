using System;
using NetDevPack.Domain;

namespace PlanB.Domain.Entities
{
    public class District : Entity, IAggregateRoot
    {
        public District(Guid id, string districtName)
        {
            Id = Id;
            DistrictName = districtName;
        }

        protected District() {}
        public string DistrictName { get; private set; }
        
        
        
    }
}