using Upico.Core.ServiceResources;

namespace DiemDanhOTP.Core.Services
{
    public interface IUserService
    {
        public Task<LoginResponse> Authenticate(LoginRequest request);
        public Task<IList<string>> Register(RegisterRequest request);
        public Task SendChangeEmailRequest(string username, string newEmail, string callbackurl);
        public Task<bool> ConfirmChangeEmail(string username, string newEmail, string token);
        public Task<bool> ChangePassword(string userName, string currentPassword, string newPassword);
        public Task<bool> CheckPassword(string userName, string password);
    }
}
