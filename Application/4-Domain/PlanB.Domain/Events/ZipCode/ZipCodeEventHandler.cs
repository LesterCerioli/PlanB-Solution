using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace PlanB.Domain.Events.ZipCode
{
    public class ZipCodeEventHandler :
        INotificationHandler<ZipCodeRegisteredEvent>,
        INotificationHandler<ZipCodeUpdatedEvent>,
        INotificationHandler<ZipCodeRemovedEvent>
    {
        
        public Task Handle(ZipCodeUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
        
        
        public Task Handle(ZipCodeRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        

        public Task Handle(ZipCodeRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}