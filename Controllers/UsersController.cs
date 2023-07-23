using System;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using API.Entities;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController] //api creation
    [Route("api/[controller]")] // /api/users
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();

            return users;
        }

        [ HttpGet("{id}")]
        public async Task<ActionResult<AppUser>>GetUser(int id)
        {
            return await _context.Users.FindAsync(id);


        }
    }
}