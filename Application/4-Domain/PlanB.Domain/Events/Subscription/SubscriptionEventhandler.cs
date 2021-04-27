using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace PlanB.Domain.Events.Subscription
{
    public class SubscriptionEventhandler :
        INotificationHandler<SubscriptionRegisteredEvent>,
        INotificationHandler<SubscriptionUpdatedEvent>,
        INotificationHandler<SubscriptionRemovedEvent>
    {
        public Task Handle(SubscriptionRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(SubscriptionUpdatedEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(SubscriptionRemovedEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}