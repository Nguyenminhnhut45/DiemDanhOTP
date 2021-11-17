using AutoMapper;
using DiemDanhOTP.Core;
using DiemDanhOTP.Core.Domain;
using DiemDanhOTP.Core.Services;
using DiemDanhOTP.Resource;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Upico.Core.ServiceResources;

namespace DiemDanhOTP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IUserService userService, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _userService = userService;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpGet("find/{id}")]
        public async Task<IActionResult> getUserById(string id)
        {
            // Username current user
            var currentUser = User.Identity.Name;
            var user = await _unitOfWork.User.SearchUserById(id);
            if (user == null)
                return Problem();
            var result = _mapper.Map<User, UserResource>(user);
            return Ok(result);
        }
        
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest request)
        {
            var user = await _userService.Authenticate(request);
            if (user == null)
                return Problem();

            return Ok(user);
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterRequest user)
        {
            var errors = await _userService.Register(user);
            var error = new
            {
                EmailError = "Email already in use",
                UserNameError = "Username already exists",
            };

            if (errors == null)
            {
                return Ok();
            }
            else
            {
                if (errors.Count == 1)
                {
                    if (errors[0] == "Email already in use")
                    {
                        error = new
                        {
                            EmailError = "Email already in use",
                            UserNameError = "",
                        };
                    }
                    else
                    {
                        error = new
                        {
                            EmailError = "",
                            UserNameError = "Username already exists",
                        };
                    }
                }
            }

            return BadRequest(error);
        }

    }


}
