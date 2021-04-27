using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace PlanB.Domain.Events.Student
{
    public class StudentEventHandler :
        INotificationHandler<StudentRegisteredEvent>,
        INotificationHandler<StudentUpdatedEvent>,
        INotificationHandler<StudentRemovedEvent>

    {
        public Task Handle(StudentUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;

        }

        public Task Handle(StudentRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(StudentRemovedEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}