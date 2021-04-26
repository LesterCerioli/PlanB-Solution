using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetDevPack.Data;
using PlanB.Domain.Entities;

namespace PlanB.Domain.Interfaces
{
    public interface IEmailRepository : IRepository<Email>
    {
        Task<Email> GetById(Guid id);
        Task<Email> GetByAddress(string address);
        Task<IEnumerable<Email>> GetAll();

        void Add(Email email);
        void Update(Email email);
        void Remove(Email email);
         
    }
}