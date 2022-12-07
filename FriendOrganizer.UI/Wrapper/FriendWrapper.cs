using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FriendOrganizer.UI.Wrapper
{
    public class FriendWrapper : ModelWrapper<Friend>
    {
        public FriendWrapper(Friend model) : base(model)
        {

        }
        public Guid Id => Model.Id;
        public string FirstName
        {
            get => GetValue<string>();
            set
            {
                SetValue(value);
            }
        }

        public string LastName
        {
            get => GetValue<string>();
            set
            {
                SetValue(value);
            }
        }
        public string Email
        {
            get => GetValue<string>();
            set
            {
                SetValue(value);
            }
        }

        public Guid? FavoriteLanguageId
        {
            get => GetValue<Guid?>();
            set => SetValue(value);
        }

        protected override IEnumerable<string> ValidateProperty([CallerMemberName] string propertyName = null)
        {
            switch (propertyName)
            {
                case nameof(FirstName):
                    if (string.Equals(FirstName, "Robot", StringComparison.OrdinalIgnoreCase))
                    {
                        yield return "Robots are not valid friends!";
                    }
                    break;
            }
            yield break;
        }
    }
}
