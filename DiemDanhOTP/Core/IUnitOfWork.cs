using DiemDanhOTP.Core.Repositorises;

namespace DiemDanhOTP.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository User { get; }
        Task<int> Complete();
    }
}
