using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetDevPack.Data;
using PlanB.Domain.Entities;

namespace PlanB.Domain.Interfaces
{
    public interface ISubscriptionRepository : IRepository<Subscription>
    {
        Task<Subscription> GetById(Guid id);
        Task<Subscription> GetBySubNumber(long subNumber);
        Task<IEnumerable<Subscription>> GetAll();

        void Add(Subscription subscription);
        void Update(Subscription subscription);
        void Remove(Subscription subscription);
         
    }
}   