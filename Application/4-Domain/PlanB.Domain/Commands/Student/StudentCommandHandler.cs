using FluentValidation.Results;
using MediatR;
using NetDevPack.Messaging;
using PlanB.Domain.Events.Student;
using PlanB.Domain.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PlanB.Domain.Commands.Student
{
    public class StudentCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewStudentCommand, ValidationResult>,
        IRequestHandler<UpdateStudentCommand, ValidationResult>,
        IRequestHandler<RemoveStudentCommand, ValidationResult>
    {

        private readonly IStudentRepository _studentRepository;

        public StudentCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<ValidationResult> Handle(RegisterNewStudentCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var student = new Student(Guid.NewGuid(), message.CPF, message.FirstName, message.LastName, message.BirthDate, message.Email);

            if (await _studentRepository.GetByEmail(student.Email) != null)
            {
                AddError("Email enviado com sucesso");
                return ValidationResult;

            }

            student.AddDomainEvent(new StudentRegisteredEvent(student.Id, student.CPF, student.FirstName, student.LastName, student.BirthDate, student.Email));

            _studentRepository.Add(student);

            return await Commit(_studentRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateStudentCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;
            
            var student = new Student(message.Id, message.FirstName, message.LastName, message.CPF, message.BirthDate, message.Email);
            var existingStudent = await _studentRepository.GetByEmail(student.Email);
        }
    }
}