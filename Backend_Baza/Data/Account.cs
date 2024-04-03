using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Baza.Data
{
    public class Account
    {
        public static void CreateNewUser(Korisnici user)
        {
            Connections.datamodel.Register(user.ime, user.prezime,
                user.datumRodjenja, user.email, user.username,
                user.pssw, user.isProfesor, user.gradID);
        }
        public static Korisnici Login(string username, string password)
        {
            return Connections.datamodel.Login(username, password).First();
        }
    }
}
