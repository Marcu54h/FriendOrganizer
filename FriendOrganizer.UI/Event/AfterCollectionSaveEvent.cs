using Prism.Events;

namespace FriendOrganizer.UI.Event
{
    public class AfterCollectionSavedEvent : PubSubEvent<AfterCollectionSaveEventArgs>
    {
    }

    public class AfterCollectionSaveEventArgs
    {
        public string ViewModelName { get; set; }
    }
}
