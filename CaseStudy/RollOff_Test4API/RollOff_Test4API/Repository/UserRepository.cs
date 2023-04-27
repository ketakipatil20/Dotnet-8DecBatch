using Microsoft.EntityFrameworkCore;
using RollOff_Test4API.Data;
using RollOff_Test4API.Models.Domain;
using System.Threading.Tasks;

namespace RollOff_Test4API.Repository
{
    public class UserRepository : IUser
    {

        private RollOff4DbContext _context;

        public UserRepository(RollOff4DbContext context)
        {
            _context = context;
        }
        public async Task<Login> AddLoginDetailsAsync(Login loginTable)
        {
            await _context.login.AddAsync(loginTable);
            await _context.SaveChangesAsync();
            return loginTable;
        }

        public async Task<Login> AuthenticateUserAsync(string email, string password,string department)
        {
            var user = await _context.login.FirstOrDefaultAsync(x => x.Email == email && x.Password == password && x.Department==department);
            return user;
        }
    }
}
