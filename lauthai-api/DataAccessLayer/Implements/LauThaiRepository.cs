using System.Collections.Generic;
using System.Threading.Tasks;
using lauthai_api.DataAccessLayer.Data;
using lauthai_api.DataAccessLayer.Repository.Implements;
using lauthai_api.Models;
using Microsoft.EntityFrameworkCore;

namespace lauthai_api.DataAccessLayer
{
    public class LauThaiRepository : GenericRepository, ILauThaiRepository
    {
        private readonly LauThaiDbContext _context;
        public LauThaiRepository(LauThaiDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Profile>> GetAllProfiles()
        {
            return await _context.Profiles.Include(p => p.University).AsNoTracking().ToListAsync();
        }
        public async Task<Profile> GetProfileById(int id)
        {
            return await _context.Profiles.Include(p => p.University).FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task<IEnumerable<University>> GetAllUni()
        {
            return await _context.Universities.Include(u => u.Profiles).ToListAsync();
        }
        public async Task<University> GetUniversityById(int id)
        {
            return await _context.Universities.Include(u => u.Profiles).FirstOrDefaultAsync(u => u.Id == id);
        }
        public async Task<IEnumerable<Feedback>> GetAllFeedbacks()
        {
            return await _context.Feedbacks.AsNoTracking().ToListAsync();
        }
        public async Task<Feedback> GetFeedbackById(int id)
        {
            return await _context.Feedbacks.FirstOrDefaultAsync(a => a.Id == id);
        }
        public async Task<User> GetUserById(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<bool> IsUserExist(string username)
        {
            return await _context.Users.AnyAsync(u => u.Username == username) ? true : false;
        }

        public async Task<User> GetUserByUsername(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }
    }
}