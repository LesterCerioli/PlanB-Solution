using PlanB.Domain.Core.ValueObjects;
using PlanB.Domain.Enums;

namespace PlanB.Domain.ValueObjcts
{
    public class Document : ValueObject
    {

        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;

            
        }
        
        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

        private bool Validate()
        {
            if (Type == EDocumentType.CNPJ && Number.Length == 14)
                return true;

            if (Type == EDocumentType.CPF && Number.Length == 11)
                return true;

            return false;
        }
        
    }
}