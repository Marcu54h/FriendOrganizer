using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data.Repositories
{
    public class MeetingRepository : GenericRepository<Meeting, FriendContext>, IMeetingRepository
    {
        public MeetingRepository(FriendContext context) : base(context)
        {
        }

        public async override Task<Meeting> GetByIdAsync(Guid id)
        {
            return await Context.Meetings
                                .Include(m => m.Friends)
                                .SingleAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<Friend>> GetAllFriendsAsync()
        {
            return await Context.Set<Friend>().ToListAsync();
        }

        public async Task ReloadFriendAsync(Guid friendId)
        {
            var dbEntityEntry = Context.ChangeTracker.Entries<Friend>()
                                                     .SingleOrDefault(db => db.Entity.Id == friendId);
            if (dbEntityEntry != null)
            {
                await dbEntityEntry.ReloadAsync();
            }
        }
    }
}
