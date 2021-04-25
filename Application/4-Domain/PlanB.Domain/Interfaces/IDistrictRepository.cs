using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using NetDevPack.Data;
using PlanB.Domain.Entities;

namespace PlanB.Domain.Interfaces
{
    public interface IDistrictRepository : IRepository<District>
    {
        Task<District> GetById(Guid id);
        Task<District> GetByDistrictName(string districtName);
        Task<IEnumerable<District>> GetAll();

        void Add(District district);
        void Update(District district);
        void Remove(District district);

         
    }
}