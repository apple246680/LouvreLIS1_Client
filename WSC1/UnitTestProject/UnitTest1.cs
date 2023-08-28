using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Session1Entities session1 = new Session1Entities();
            User user = new User();
            user.GUID = Guid.NewGuid();
            user.UserTypeID = 2;
            user.Username = "test";
            user.Password = "test";
            user.FullName = "test";
            user.Gender = true;
            user.BirthDate = DateTime.Now;
            user.FamilyCount = 1;
            try
            {
                session1.Users.Add(user);
                session1.SaveChanges();
                session1.Users.Remove(session1.Users.FirstOrDefault(x => x.Username == "test"));
                session1.SaveChanges();
                return;
            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}