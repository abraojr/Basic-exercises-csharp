using Exercise_048_Course_Management.SharedContext;
using System;

namespace Exercise_048_Course_Management.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsInactive => EndDate <= DateTime.Now;
    }
}
