using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace PlanB.Domain.Events.Payment
{
    public class PaymentEventHandler :
        INotificationHandler<PaymentRegisteredEvent>,
        INotificationHandler<PaymentUpdatedEvent>,
        INotificationHandler<PaymentRemovedEvent>

    {
        public Task Handle(PaymentRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(PaymentUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(PaymentRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}