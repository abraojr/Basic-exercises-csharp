using Exercise_048_Course_Management.NotificationContext;
using System;

namespace Exercise_048_Course_Management.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Guid Id { get; set; }

        public Base()
        {
            Id = Guid.NewGuid(); //SPOF
        }
    }
}
