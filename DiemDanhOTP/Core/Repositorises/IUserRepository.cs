
using DiemDanhOTP.Core.Domain;
using System.Linq.Expressions;

namespace DiemDanhOTP.Core.Repositorises
{
    // Sync Async
    public interface IUserRepository
    {
        public Task<User> GetUser(string userName);
        public Task<User> SearchUserByUsername(string username);
        public Task<User> SearchUserById(string id);
        public Task<List<User>> SearchUsersByDisplayName(string displayName);
        public Task LoadMainAvatar(string userName);
        public Task<User> GetUserProfile(string username);
        Task Load(Expression<Func<User, bool>> predicate);
    }
}
