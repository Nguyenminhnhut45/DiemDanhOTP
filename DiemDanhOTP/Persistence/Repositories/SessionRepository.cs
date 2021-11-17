using DiemDanhOTP.Core.Domain;
using DiemDanhOTP.Core.Repositorises;
using Upico.Persistence.Repositories;

namespace DiemDanhOTP.Persistence.Repositories
{
    public class SessionRepository : Repository<Session>, ISessionRepository
    {
        private readonly DiemDanhDBContext _context;
        public SessionRepository(DiemDanhDBContext context)
            :base(context)
        {
            _context = context;
        }

        public async Task<List<Session>> GetAll()
        {
            throw new NotImplementedException();
            // return await this._context.Sessions.ToListAsync();
        }
        //get by datetime
        public async Task<Session> GetSessionByDate(DateTime dateTime)
        {
            var session = await _context.Sessions.FindAsync(dateTime);

            if (session == null)
            {
                new NotImplementedException();
            }

            return session;
        }
        //get by id
        public async Task<Session> GetSessionById(string idSesion)
        {
            var session = await _context.Sessions.FindAsync(idSesion);

            if (session == null)
            {
                 new NotImplementedException();
            }

            return session;
        }
        //search theo classroom 

        public async Task<Session> SearchUserByClassroom(string classRoom)
        {
            var session = await _context.Sessions.FindAsync(classRoom);
            if (session == null)
            {
                return null;
            }
           return session;
        }
    }
}
