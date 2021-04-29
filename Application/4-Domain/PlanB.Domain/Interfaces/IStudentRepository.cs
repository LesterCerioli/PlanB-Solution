using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetDevPack.Data;
using PlanB.Domain.Entities;

namespace PlanB.Domain.Interfaces
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<Student> GetById(Guid id);
        Task<Student> GetByCPF(string CPF);
        Task<Student> GetByBirthDate(DateTime BirthDate);
        Task<Student> GetByEmail(string Email);
        Task<IEnumerable<Student>> GetAll();

        void Add(Student student);
        void Update(Student student);
        void remove(Student student);


         
    }
}