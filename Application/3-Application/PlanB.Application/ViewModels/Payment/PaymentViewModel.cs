using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PlanB.Domain.ValueObjcts;

namespace PlanB.Application.ViewModels.Payment
{
    public class PaymentViewModel
    {

        [Key]
        public Guid Id { get; set; }

        public string Number { get; private set; }
        
        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [DisplayName("Data de Pagamento")]
        public DateTime PaidDate { get; private set; }
        
        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [DisplayName("Data de Expiracao")]
        public DateTime ExpireDate { get; private set; }
        
        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [DisplayName("Valor Total")]
        public decimal Total { get; private set; }
        
        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [DisplayName("Valor Total de Pagamento")]
        public decimal TotalPaid { get; private set; }
        
        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [DisplayName("Nome do pagante")]
        [MinLength(15)]
        [MaxLength(100)]
        public string Payer { get; private set; }
        
        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [DisplayName("Numero de CPF ou CNPJ")]
        [MinLength(11)]
        [MaxLength(15)]
        public Document Document { get; private set; }
        
        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [DisplayName("Endereco Completo")]
        [MinLength(11)]
        [MaxLength(100)]
        public Address Address { get; private set; }
        
        
        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [EmailAddress]
        [DisplayName("E-mail")]
        public Email Email { get; private set; }
        
        
        
    }
}