using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PlanB.Application.ViewModels.Subscription
{
    public class SubscriptionViewModel
    {
        
        [Key]
        public Guid Id {get; set;}

        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [DisplayName("Data de Criacao")]
        public DateTime CreateDate { get; private set; }
        
        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [DisplayName("Data de ultima atualizacao")]
        public DateTime LastUpdateDate { get; private set; }
        
        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [DisplayName("Data de Expiracao")]
        public DateTime? ExpireDate { get; private set; }
        
        public bool Active { get; private set; }
        public long SubNumber {get; private set;}
    }
}