using System.Collections.Generic;

namespace ddd_learn_coupon.core
{
    public class Events
    {
        private static List<IEvent> EventList { get; set; } = new List<IEvent>();

        public static void AddEvent(IEvent @event)
        {
            EventList.Add(@event);
        }
    }
}
