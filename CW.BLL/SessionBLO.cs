using CW.BO;
using CW.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.BLL
{
    public class SessionBLO
    {
        SessionDAO sessionRepo;

        public SessionBLO(string dbFolder)
        {
            sessionRepo = new SessionDAO(dbFolder);
        }
        public void CreateSession(Session session)
        {
            sessionRepo.Add(session);
        }

        public void DeleteSession(Session session)
        {
            sessionRepo.Remove(session);
        }


        public IEnumerable<Session> GetAllSessions()
        {
            return sessionRepo.Find();
        }


        public IEnumerable<Session> GetByPseudo(string pseudo)
        {
            return sessionRepo.Find(x => x.Pseudo == pseudo);
        }

        public IEnumerable<Session> GetBy(Func<Session, bool> predicate)
        {
            return sessionRepo.Find(predicate);
        }

        public void EditSession(Session oldSession, Session newSession)
        {
            sessionRepo.Set(oldSession, newSession);
        }
    }
}
