using FluentValidation;
using PlanB.Domain.Commands.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.Domain.Commands.Validations.Student
{
    public abstract class StudentValidation<T> : AbstractValidator<T> where T: StudentCommand
    {
        protected void ValidateCPF()
        {
            RuleFor(a => a.CPF)
                .NotEmpty().WithMessage("O CPF deve ser informado")
                .Length(11).WithMessage("O CPF deve possuir 11 caracteres");

        }

        protected void ValidateFirstName()
        {
            RuleFor(a => a.FirstName)
                .NotEmpty().WithMessage("O PRIMEIRO NOME deve ser informado")
                .Length(4, 25).WithMessage("O PRIMEIRO NOME deve possuir entre 4 e 25 caracteres");
        }

        protected void ValidateLastName()
        {
            RuleFor(a => a.LastName)
                .NotEmpty().WithMessage("O PRIMEIRO NOME deve ser informado")
                .Length(4, 25).WithMessage("O SOBRENOME deve possuir entre 4 e 25 caracteres");
        }

        protected void ValidateBirthDate()
        {
            RuleFor(a => a.BirthDate)
                .NotEmpty()
                .WithMessage("A data de nascimento deve ser informada");
        }

        protected void ValidateEmail()
        {
            RuleFor(a => a.Email)
                .NotEmpty()
                .Length(40).WithMessage("O endereco do Email deve possuir no maximo 40 caracteres")
                .EmailAddress();
        }

        protected void ValidateId()
        {
            RuleFor(a => a.Id)
                .NotEqual(Guid.Empty);
        }
    }
}
