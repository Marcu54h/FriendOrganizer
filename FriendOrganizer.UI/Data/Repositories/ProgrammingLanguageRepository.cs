using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data.Repositories
{
    public class ProgrammingLanguageRepository : GenericRepository<ProgrammingLanguage, FriendContext>, IProgrammingLanguageRepository
    {
        public ProgrammingLanguageRepository(FriendContext context) : base(context)
        {

        }

        public async Task<bool> IsReferencedByFriendAsync(Guid programmingLanguageId)
        {
            return await Context.Friends.AsNoTracking()
                                .AnyAsync(f => f.FavoriteLanguageId == programmingLanguageId);
        }
    }
}
