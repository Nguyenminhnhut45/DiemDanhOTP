using DiemDanhOTP.Core;
using DiemDanhOTP.Core.Domain;
using DiemDanhOTP.Core.Services;
using DiemDanhOTP.Core.StaticValue;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Upico.Core.ServiceResources;

namespace DiemDanhOTP.Persistence.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _config;

        public UserService(UserManager<User> userManager,
            SignInManager<User> signInManager,
            IUnitOfWork unitOfWork,
            IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _unitOfWork = unitOfWork;
            _config  = config;
        }
        public async Task<LoginResponse> Authenticate(LoginRequest request)
        {
            // check user exitst
            var user = await _userManager.FindByNameAsync(request.Username);
            if (user == null)
                return null;

            //check password
            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
            if (!result.Succeeded)
                return null;

            //get roles
            var roles = await _userManager.GetRolesAsync(user);

            var fullName = user.FullName;
            if (fullName == null)
                fullName = "undefined";
            //create claims

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.GivenName, fullName),
                new Claim(ClaimTypes.Name,user.UserName)
            };
            foreach (var i in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, i));
            }

            //create token
            var key = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new Microsoft.IdentityModel.Tokens.SigningCredentials(key, Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity((claims)),
                Expires = DateTime.Now.AddMonths(2),
                SigningCredentials = creds,
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            var finalToken = tokenHandler.WriteToken(token);

            //Load Avatar
            //await this._unitOfWork.Avatars.Load(a => a.UserID == user.Id && a.IsMain);

            //var avatar = user.Avatars.Where(a => a.IsMain).FirstOrDefault();
            string path = null;

            //if (avatar != null)
            //    path = avatar.Path;

            var loginResponse = new LoginResponse()
            {
                UserName = user.UserName,
                Token = finalToken,
                DisplayName = user.FullName,
                AvatarUrl = path,
                RoleName = roles.FirstOrDefault()
            };

            return loginResponse;
        }

        public Task<bool> ChangePassword(string userName, string currentPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckPassword(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ConfirmChangeEmail(string username, string newEmail, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<string>> Register(RegisterRequest request)
        {
            var listError = new List<string>();

            var user = await _userManager.FindByNameAsync(request.Username);

            //check email
            if (await _userManager.FindByEmailAsync(request.Email) != null)
            {
                listError.Add("Email already in use");
            }

            //check username
            if (user != null)
            {
                listError.Add("Username already exists");
            }

            user = new User()
            {
                UserName = request.Username,
                FullName = request.FullName,
                Email = request.Email,
            };
            if (listError.Count != 0)
                return listError;

            var result = await _userManager.CreateAsync(user, request.Password);
            await _userManager.AddToRoleAsync(user, request.IsTeacher ? RoleNames.RoleTeacher : RoleNames.RoleStudent);

            if (result.Succeeded)
                return null;

            throw new Exception("Error when creating user!! oh yeah");
        }

        public Task SendChangeEmailRequest(string username, string newEmail, string callbackurl)
        {
            throw new NotImplementedException();
        }
    }
}
