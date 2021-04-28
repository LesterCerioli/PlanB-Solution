namespace PlanB.Application.Interfaces.Subscription
{
    public interface ISubscriptionAppService : IDisposable
    {
        Task<IEnumerable<SubscriptionViewModel>> GetAll();
        Task<SubscriptionViewModel> GetById(Guid id);

        Task<ValidationResult> Register(SubscriptionViewModel subscriptionViewModel);
        Task<ValidationResult> Update(SubscriptionViewModel subscriptionViewModel);
        Task<ValidationResult> Remove(SubscriptionViewModel subscriptionViewModel);
         
    }
}