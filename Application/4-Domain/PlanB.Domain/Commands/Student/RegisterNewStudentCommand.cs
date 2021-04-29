

using PlanB.Domain.Commands.Validations.Student;
using System;

namespace PlanB.Domain.Commands.Student
{
    public class RegisterNewStudentCommand : StudentCommand
    {
        public RegisterNewStudentCommand(string cpf, string firstName, string lastName, DateTime birthDate, string email)
        {
            CPF = cpf;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Email = email;


        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewStudentCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }

    }
}