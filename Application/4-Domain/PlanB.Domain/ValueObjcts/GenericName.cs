using PlanB.Domain.Core.ValueObjects;

namespace PlanB.Domain.ValueObjcts
{
    public class GenericName : ValueObject
    {
        public GenericName(string name, bool active)
        {
            Name = name;
            Active = active;
        }

        public string Name { get; set; }
        public bool Active { get; set; }
        
        
        
        
        
    }
}