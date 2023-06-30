using FlightBookingSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FlightBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("angularApplication")]
    public class UserController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AirlineDbContext _context;

        public UserController(IConfiguration config, AirlineDbContext context)
        {
            _config = config;
            _context = context;
        }
        [AllowAnonymous]
        [HttpPost("CreateUser")]
        public IActionResult Create(User user)
        {
            if (_context.Users.Where(u => u.Email == user.Email).FirstOrDefault() != null)
            {
                return Ok("Already Exists");
            }
           
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok("Success");
        }
        [AllowAnonymous]
        [HttpPost("LoginUser")]
        public IActionResult Login(Login user)
        {
            var userAvailable = _context.Users.Where(u => u.Email == user.Email && u.Pwd == user.Password).FirstOrDefault();
            if (userAvailable != null)
            {

                return Ok();
            }
            return Ok("Failure");
        }
    }
}
