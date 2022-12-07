using Prism.Events;
using System;

namespace FriendOrganizer.UI.Event
{
    public class AfterDetailDeletedEvent : PubSubEvent<AfterDetailDeletedEventArgs>
    {
    }

    public class AfterDetailDeletedEventArgs
    {
        public Guid Id { get; set; }
        public string ViewModelName { get; set; }
    }
}
