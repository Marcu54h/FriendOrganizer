using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data.Repositories
{
    public interface IMeetingRepository : IGenericRepository<Meeting>
    {
        Task<IEnumerable<Friend>> GetAllFriendsAsync();
        Task ReloadFriendAsync(Guid friendId);
    }
}