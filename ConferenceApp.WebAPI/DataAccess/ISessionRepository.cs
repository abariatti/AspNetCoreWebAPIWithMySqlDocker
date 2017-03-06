using ConferenceApp.WebAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceApp.WebAPI.DataAccess
{
    public interface ISessionRepository
    {
        Task<List<Session>> GetSessionsAsync();
        Task Insert(Session session);
    }
}
