using Prism.Events;
using System;

namespace FriendOrganizer.UI.Event
{
    public class AfterDetailCloseEvent : PubSubEvent<AdterDetaiCloseEventArgs>
    {
    }

    public class AdterDetaiCloseEventArgs
    {
        public Guid Id { get; set; }
        public string ViewModelName { get; set; }
    }
}
