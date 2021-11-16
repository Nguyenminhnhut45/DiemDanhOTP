using DiemDanhOTP.Core;
using DiemDanhOTP.Core.Repositorises;

namespace DiemDanhOTP.Persistence
{
    public class UnitOfWork: IUnitOfWork
    {
        private DiemDanhDBContext _context;

        public IUserRepository User { get; private set; }

        public UnitOfWork (DiemDanhDBContext context, IUserRepository userRepository)
        {
            _context = context;
            User = userRepository;
        }

        public async Task<int> Complete()
        {
            return await this._context.SaveChangesAsync();
        }

        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}
