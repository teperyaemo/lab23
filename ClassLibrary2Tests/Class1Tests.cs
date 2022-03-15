using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void AddUserTest()
        {
            Class1 test = new Class1();
            string add_user = test.AddUser("test", "test", "User");
            string title = "User";
            Assert.AreEqual(add_user, title);
        }

        [TestMethod()]
        public void AuthUserTest()
        {
            Class1 test = new Class1();
            string auth_user = test.AuthUser("User", "User");
            string title = "User";
            Assert.AreEqual(auth_user, title);
        }

        [TestMethod()]
        public void UserStatusTest()
        {
            Class1 test = new Class1();
            string status_user = test.UserStatus("Admin", "Admin");
            string title = "Admin";
            Assert.AreEqual(status_user, title);
        }
    }
}