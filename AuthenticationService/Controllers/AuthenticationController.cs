using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationService.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AuthenticationService.Controllers
{

    [Route("[controller]")]
    public class AuthenticationController : Controller
    {
        private readonly UserManager<User> _UserManager;

        public AuthenticationController(UserManager<User> UserManager)
        {
            _UserManager = UserManager;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromQuery]string userName , [FromQuery]string email , [FromQuery]string password)
        {
            if (ModelState.IsValid)
            {
                var result = await _UserManager.CreateAsync(
                    new User()
                    {
                        UserName = userName,
                        Email = email
                        
                    }, 
                    password);

                return CreatedAtAction("Register", result);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}