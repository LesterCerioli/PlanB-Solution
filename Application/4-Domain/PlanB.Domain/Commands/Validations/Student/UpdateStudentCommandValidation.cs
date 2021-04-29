using PlanB.Domain.Commands.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.Domain.Commands.Validations.Student
{
    public class UpdateStudentCommandValidation : StudentValidation<UpdateStudentCommand>
    {
        public UpdateStudentCommandValidation()
        {
            ValidateId();
            ValidateCPF();
            ValidateFirstName();
            ValidateLastName();
            ValidateBirthDate();
            ValidateEmail();
            
        }
    }
}
