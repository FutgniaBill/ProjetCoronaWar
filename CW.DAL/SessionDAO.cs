using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CW.BO;
using Newtonsoft.Json;



namespace CW.DAL
{
    public class SessionDAO
    {
        private static List<Session> sessions;
        private const string FILE_NAME = @"sessions.json";
        private readonly string dbFolder;  //elle se lit seulement dans le constructeur
        private FileInfo file;

        public SessionDAO(string dbFolder)
        {
            this.dbFolder = dbFolder;
            file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }
            if (file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    sessions = JsonConvert.DeserializeObject<List<Session>>(json);
                }

            }
            if (sessions == null)
            {
                sessions = new List<Session>();
            }
        }
        public void Add(Session session)
        {
            var index = sessions.IndexOf(session);
            if (index >= 0)
                throw new DuplicateNameException("This session description already exists !");
            sessions.Add(session);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))//false implique qu'à chaque fois qu'on écrit on efface ce qu'il y'avait dans le fichier
            {
                string json = JsonConvert.SerializeObject(sessions);
                sw.WriteLine(json);

            }
        }

        public void Remove(Session session)
        {
            sessions.Remove(session);// basé sur la méthode equals de product ie product.equal
            Save();
        }
        public IEnumerable<Session> Find()
        {
            return new List<Session>(sessions);
        }
        public IEnumerable<Session> Find(Func<Session, bool> predicate)
        {
            return new List<Session>(sessions.Where(predicate).ToArray());
        }
        public void Set(Session oldSession, Session newSession)
        {
            var oldIndex = sessions.IndexOf(oldSession);
            var newIndex = sessions.IndexOf(newSession);
            if (oldIndex < 0)
                throw new KeyNotFoundException("The session doesn't exists !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This session reference already exists !");
            sessions[oldIndex] = newSession;
            Save();
        }
    }
}
