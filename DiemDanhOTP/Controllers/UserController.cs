using AutoMapper;
using DiemDanhOTP.Core;
using DiemDanhOTP.Core.Domain;
using DiemDanhOTP.Core.Services;
using DiemDanhOTP.Resource;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            var user = await _unitOfWork.User.SearchUserById(id);
            if (user == null)
                return Problem();
            var result = _mapper.Map<User, UserResource>(user);
            return Ok(result);
        }
          [HttpGet("find/{username}, {password}")]
        public async Task<IActionResult> getUserByCondition(string username, string password)
        {
            var user = await _unitOfWork.User.SearchUserByCondition(username, password);
            if (user == null)
                return Problem();
            var result = _mapper.Map<User, UserResource>(user);
            return Ok(result);
        }
        /*[HttpPost("")]
        *//*  public async Task<IActionResult> PostUser (User user)
          {
             return not

          }*/


    }


}
