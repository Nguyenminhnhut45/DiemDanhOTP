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

        //Get by id
        public async Task<User> SearchUserById(string id)
        {
            var user = await this._context.Users.SingleOrDefaultAsync(u => u.Id== id);
            if (user == null)
            {
                throw new NotImplementedException();
            }

            return user;
           
        }
        //Get by usename && pass
        public async Task<User> SearchUserByCondition(string username, string password)
        {
            var user = await this._context.Users.SingleOrDefaultAsync(u => u.Usename == username&& u.Password==password);
            
            if (user == null)
            {
                throw new NotImplementedException();
            }
           
            return user;
        }
    
    }
}
