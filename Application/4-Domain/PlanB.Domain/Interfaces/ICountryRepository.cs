using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetDevPack.Data;
using PlanB.Domain.Entities;

namespace PlanB.Domain.Interfaces
{
    public interface ICountryRepository : IRepository<Country>
    {
        Task<Country> GetById(Guid id);
        Task<Country> GetByName(string namee);
        Task<IEnumerable<Country>> GetAll();

        void Add(Country country);
        void Update(Country country);
        void Remove(Country country);
        
         
    }
}