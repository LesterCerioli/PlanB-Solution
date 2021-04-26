using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetDevPack.Data;
using PlanB.Domain.Entities;

namespace PlanB.Domain.Interfaces
{
    public interface IStateRepository : IRepository<State>
    {
        Task<State> GetById(Guid id);
        Task<State> GetByNameState(string NameState);
        Task<IEnumerable<State>> GetAll();

        void Add(State state);
        void Update(State state);
        void Remove(State state);
         
    }
}