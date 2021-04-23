using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.Domain.Entities
{
    public abstract class Payment : Entity, IAggregateRoot
    {
        public Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, DocumentK documentK1, Address address, Email email)
        {
            
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            DocumentK = DocumentK;
            Address = address;
            Email = email;

            
        }

        
        
        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string Payer { get; private set; }
        public DocumentK DocumentK { get; private set; }
        public Address Address { get; private set; }
        public Email Email { get; private set; }
    }
}
