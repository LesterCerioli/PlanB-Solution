using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetDevPack.Data;
using PlanB.Domain.Entities;

namespace PlanB.Domain.Interfaces
{
    public interface IPaymentRepository : IRepository<Payment>
    {
        Task<Payment> GetById(Guid id);
        Task<Payment> GetByNumber(string number);
        Task<Payment> GetByPaidDate(DateTime paidDate);
        Task<Payment> GetByExpiredDate(DateTime expiredDate);
        Task<IEnumerable<Payment>> GetAll();

        void Add(Payment payment);
        void Update(Payment payment);
        void Remove(Payment payment);


    }
    
}