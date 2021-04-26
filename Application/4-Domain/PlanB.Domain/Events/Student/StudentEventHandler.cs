using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
