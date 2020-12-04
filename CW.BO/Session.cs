using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.BO
{
    public class Session
    {
        public string Pseudo { get; set; }
        public string Sexe { get; set; }
        public byte[] Photo { get; set; }

        public long Score { get; set; }
        public Session()
        {

        }

        public Session(string pseudo, string sexe,byte[] photo,long score)
        {
            Pseudo = pseudo;
            Sexe = sexe;
            Photo = photo;
            Score = score;
        }

        public override bool Equals(object obj)
        {
            return obj is Session session &&
                   Pseudo == session.Pseudo;
        }

        public override int GetHashCode()
        {
            return 145730772 + EqualityComparer<string>.Default.GetHashCode(Pseudo);
        }
    }
}
