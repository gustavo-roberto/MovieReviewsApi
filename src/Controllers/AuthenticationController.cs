using Microsoft.AspNetCore.Mvc;
using MovieReviewsApi.Services;
using MovieReviewsApi.Models;
using System;
using Microsoft.Net.Http.Headers;

namespace MovieReviewsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _service;

        public AuthenticationController(IAuthenticationService service)
        {
            _service = service;            
        }

        [HttpPost("UserLogin")]
        public IActionResult UserLogin([FromBody] UserLoginApi user)
        {
            try
            {
                _service.LoginUser(user);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost("UserCreation")]
        public IActionResult UserCreation([FromBody] UserCreationApi user)
        {
            try
            {
                _service.UserCreation(user);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest();
            }

        }

    }
}