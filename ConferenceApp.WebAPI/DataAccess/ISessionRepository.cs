using ConferenceApp.WebAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceApp.WebAPI.DataAccess
{
    public interface ISessionRepository
    {
        Task<List<Session>> All();
        Task<Session> Get(int id);
        Task<Session> Insert(Session session);
        Task Update(Session session);
        Task Delete(int id);
    }
}
