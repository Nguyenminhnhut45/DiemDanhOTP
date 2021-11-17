
using DiemDanhOTP.Core.Domain;
using System.Linq.Expressions;
using Upico.Core.Repositories;

namespace DiemDanhOTP.Core.Repositorises
{
    // Sync Async
    public interface IUserRepository: IRepository<User>
    {
        public Task<User> SearchUserByCondition(string key);
        public Task<User> SearchUserById(string id);
        
    }
}
