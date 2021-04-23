using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using NetDevPack.Data;
using PlanB.Domain.Entities;

namespace PlanB.Domain.Interfaces
{
    public interface IDocumentKRepository : IRepository<DocumentK>
    {
        Task<DocumentK> GetById(Guid id);
        Task<DocumentK> GetByNumber(string number);
        Task<IEnumerable<DocumentK>> GetAll();

        void Add(DocumentK documentK);
        void Update(DocumentK documentK);
        void Remove(DocumentK documentK);
         
    }
}