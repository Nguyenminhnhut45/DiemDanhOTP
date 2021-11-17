using DiemDanhOTP.Core.Domain;

namespace DiemDanhOTP.Core.Repositorises
{
    public interface ISessionRepository
    {
        public Task<List<Session>> GetAll();
        public Task<Session> GetSessionById(string idSesion);
        public Task<Session> SearchUserByClassroom(string classRoom);
        public Task<Session> GetSessionByDate(DateTime dateTime);
            
        
        
    }
}
