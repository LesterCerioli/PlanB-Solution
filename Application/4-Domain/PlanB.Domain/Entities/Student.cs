using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.Domain.Entities
{
    public class Student : Entity, IAggregateRoot
    {
        private IList<Subscription> _subscriptions;

        public Student(Guid id, string cPF, string firstName, string lastname)
        {
            
            Id = id;
            CPF = cPF;
            _subscriptions = new List<Subscription>();
            FirstName = firstName;
            LastName = lastname;

            
        }

        protected Student() { }
            
        public string CPF { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public void AddSubscription(Subscription subscription)
        {
            var hasSubscriptionActive = false;
            foreach (var sub in _subscriptions)
            {
                if (sub.Active)
                    hasSubscriptionActive = true;
            }

            

            //if (Valid)
                //_subscriptions.Add(subscription);
            // Alternativa
            // if (hasSubscriptionActive)
            //     AddNotification("Student.Subscriptions", "Você já tem uma assinatura ativa");
        }
    }
}
