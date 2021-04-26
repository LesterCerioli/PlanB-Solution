using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetDevPack.Data;
using PlanB.Domain.Entities;

namespace PlanB.Domain.Interfaces
{
    public interface IZipCodeRepository : IRepository<ZipCode>
    {

        Task<ZipCode> GetById(Guid id);
        Task<ZipCode> GetByZipNumber(string zipNumber);
        Task<IEnumerable<ZipCode>> GetAll();

        void Add(ZipCode zipCode);
        void Update(ZipCode zipCode);
        void Remove(ZipCode zipCode);
         
    }
}