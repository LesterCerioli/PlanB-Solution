using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetDevPack.Data;
using PlanB.Domain.Entities;

namespace PlanB.Domain.Interfaces
{
    public interface ICityRepository : IRepository<City>
    {
        Task<City> GetById(Guid id);
        Task<City> GetByName(string namee);
        Task<IEnumerable<City>> GetAll();

        void Add(Country country);
        void Update(Country country);
        void Remove(Country country);
         
    }
}