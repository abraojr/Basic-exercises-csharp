using Exercise_048_Course_Management.NotificationContext;
using Exercise_048_Course_Management.SharedContext;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_048_Course_Management.SubscriptionContext
{
    public class Student : Base
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

        public Student()
        {
            Subscriptions = new List<Subscription>();
        }

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "The student already has an active subscription"));
                return;
            }

            Subscriptions.Add(subscription);
        }
    }
}
