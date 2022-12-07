using System;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModel
{
    public interface IDetailViewModel
    {
        Guid Id { get; }
        bool HasChanges { get; }
        Task LoadAsync(Guid? id);
    }
}