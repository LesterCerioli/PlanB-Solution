using PlanB.Domain.Core.ValueObjects;

namespace PlanB.Domain.ValueObjcts
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;

            
        }

        public string Address { get; private set; }
        
    }
}