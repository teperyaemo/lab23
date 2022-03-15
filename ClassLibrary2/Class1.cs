using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        _2_3lab.Entities entities = new _2_3lab.Entities();
        _2_3lab.Useros user = new _2_3lab.Useros();

        public string AddUser(string login, string password, string status)
        {
            user.Login = login;
            user.Password = password;
            user.Status = status;
            entities.Useros.Add(user);
            entities.SaveChanges();
            return user.Status;
        }

        public string AuthUser(string login, string password)
        {
            user = _2_3lab.Entities.GetContext().Useros.First(p => p.Password == password && p.Login == login);
            return user.Login;
        }

        public string UserStatus(string login, string password)
        {
            user = _2_3lab.Entities.GetContext().Useros.First(p => p.Password == password && p.Login == login);
            return user.Status;
        }

    }
}
