using FriendOrganizer.Model;
using System;

namespace FriendOrganizer.UI.Wrapper
{
    public class MeetingWrapper : ModelWrapper<Meeting>
    {
        public MeetingWrapper(Meeting model) : base(model)
        {
        }

        public Guid Id => Model.Id;
        public string Title
        {
            get => GetValue<string>();
            set => SetValue(value);
        }
        public DateTime DateFrom
        {
            get => GetValue<DateTime>();
            set
            {
                SetValue(value);
                if (DateTo < DateFrom) DateTo = DateFrom;
            }
        }
        public DateTime DateTo
        {
            get => GetValue<DateTime>();
            set
            {
                SetValue(value);
                if (DateTo < DateFrom) DateFrom = DateTo;
            }
        }
    }
}
