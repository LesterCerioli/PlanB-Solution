using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PlanB.Application.ViewModels.Student
{
    public class StudentViewModel
    {

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [MinLength(11)]
        [MaxLength(11)]
        [DisplayName("CPF")]
        public string CPF { get; private set; }

        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [MinLength(4)]
        [MaxLength(25)]
        [DisplayName("Primeiro Nome")]
        public string FirstName { get; private set; }
        
        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [MinLength(4)]
        [MaxLength(25)]
        [DisplayName("SobreNome")]
        public string LastName { get; private set; }
        
        
        
    }
}