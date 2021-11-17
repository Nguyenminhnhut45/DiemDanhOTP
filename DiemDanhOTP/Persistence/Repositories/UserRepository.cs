using DiemDanhOTP.Core.Domain;
using DiemDanhOTP.Core.Repositorises;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Upico.Persistence.Repositories;

namespace DiemDanhOTP.Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly DiemDanhDBContext _context;
        public UserRepository(DiemDanhDBContext context)
            :base(context)
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
        public async Task<User> SearchUserByCondition(string key)
        {
            var is_id = Guid.TryParse(key, out var id);
            User user;
            if (is_id)
            {
                user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id.ToString());
            }
            else
            {
                user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == key);
            }
           
            
            if (user == null)
            {
                throw new NotImplementedException();
            }
           
            return user;
        }
    
    }
}
