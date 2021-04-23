using System;
using NetDevPack.Domain;
using PlanB.Domain.Enums;

namespace PlanB.Domain.Entities
{
    public class DocumentK : Entity, IAggregateRoot
    {
        public DocumentK(Guid id, string number, EDocumentType type)
        {
            Id = id;
            Number = number;
            Type = type;

            
        }

        protected DocumentK() {}
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