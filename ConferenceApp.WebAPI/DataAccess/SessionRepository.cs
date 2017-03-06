using ConferenceApp.WebAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceApp.WebAPI.DataAccess
{
    public class ConferenceSessionRepository : ISessionRepository
    {
        private readonly ConferenceAppContext _context;

        public ConferenceSessionRepository(ConferenceAppContext context)
        {
            _context = context;
        }

        public async Task<List<Session>> GetSessionsAsync()
        {
            return await _context.Sessions.ToListAsync();
        }

        public async Task Insert(Session session)
        {
            _context.Sessions.Add(session);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch { }
        }
    }

}
