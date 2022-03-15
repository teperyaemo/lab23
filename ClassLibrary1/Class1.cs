using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        Entities Entities = new Entities();
        private Useros user = new Useros();
        public string RegUser(string login, string password, string status)
        {
            user.Login = login;
            user.Password = password;
            user.Status = status;

            Entities.Add(user);

            Entities.SaveChanges();

            return user.Status;

        }

        public string AuthUser(string login, string password)
        {
            user = Entities.GetContext().Useros.First(p => p.Password == _currentUser.Password && p.Login == _currentUser.Login);
            if (user != null)
            {
                return user.Status;
            }
        }
    }
}
