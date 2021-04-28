using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation.Results;
using PlanB.Application.ViewModels.Payment;

namespace PlanB.Application.Interfaces.Payment
{
    public interface IPaymentAppService : IDisposable
    {
        Task<IEnumerable<PaymentViewModel>> GetAll();
        Task<PaymentViewModel> GetById(Guid id);

        Task<ValidationResult> Register(PaymentViewModel pamentViewModel);
        Task<ValidationResult> Update(PaymentViewModel paymentViewModel);
        Task<ValidationResult> Remove(PaymentViewModel paymentViewModel);

        //pending Event Non Normalizers implementation
         
    }
}