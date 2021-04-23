namespace PlanB.Domain.Core.Events
{
    public interface IEventEdu
    {
        void Save<T>(T theEvent) where T : Event;
         
    }
}