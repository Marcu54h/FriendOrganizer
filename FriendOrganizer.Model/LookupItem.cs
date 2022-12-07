using System;

namespace FriendOrganizer.Model
{
    public class LookupItem
    {
        public Guid Id { get; set; }
        public string DisplayMember { get; set; }
    }
    public class NullLookupItem : LookupItem
    {
        public new Guid? Id { get; } = null;
    }
}
