
using DiemDanhOTP.Core.Domain;
using System.Linq.Expressions;

namespace DiemDanhOTP.Core.Repositorises
{
    // Sync Async
    public interface IUserRepository
    {
      
     
        public Task<User> SearchUserByCondition(string username, string password);
        public Task<User> SearchUserById(string id);
       
        
        
    }
}
