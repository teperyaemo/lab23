using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1.Class1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Class1.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void RegUserTest()
        {
            Class1 test = new Class1();
            string reg_user = test.RegUser("testLogin", "testPass", "User");
            string title = "User";
            Assert.AreEqual(reg_user, title);
        }

        [TestMethod()]
        public void AuthUserTest()
        {
            Class1 test = new Class1();
            string auth_user_admin = test.AuthUser("Admin", "Admin");
            string title = "Admin";
            Assert.AreEqual(auth_user_admin, title);
        }

        [TestMethod]
        public void AuthUserUser()
        {
            Class1 test = new Class1();
            string auth_user_User = test.AuthUser("User", "User");
            string title = "User";
            Assert.AreEqual(auth_user_user, title);
        }
    }
}