using System;
using NetDevPack.Messaging;
using PlanB.Domain.Entities;
using PlanB.Domain.ValueObjcts;

namespace PlanB.Domain.Events.Payment
{
    public class PaymentUpdatedEvent : Event
    {
        public PaymentUpdatedEvent(Guid id, string number, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email)
        {
            Id = id;
            Number = number;
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            Document = document;
            Address = address;
            Email = email;
            AggregateId = id;
        }

        public Guid Id { get; set; }
        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string Payer { get; private set; }
        public Document Document { get; private set; }
        public Address Address { get; private set; }
        public Email Email { get; private set; }
        
        
        
    }
}