using DiemDanhOTP.Core.Domain;
using DiemDanhOTP.Core.Repositorises;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DiemDanhOTP.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DiemDanhDBContext _context;
        public UserRepository(DiemDanhDBContext context)
        {
            _context = context;
        }

        public async Task<User> GetUser(string userName)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.UserName == userName);
        }

        public Task<User> GetUserProfile(string username)
        {
            throw new NotImplementedException();
        }

        public Task Load(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task LoadMainAvatar(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<User> SearchUserById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<User> SearchUserByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> SearchUsersByDisplayName(string displayName)
        {
            throw new NotImplementedException();
        }
    }
}
