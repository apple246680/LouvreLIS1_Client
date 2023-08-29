using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sesosin3;
using System;
using System.Linq;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("dadada", "dadada", "dadadad", true, 1)]
        [DataRow("aagag", "aagag", "aagag", true, 1)]
        [DataRow("mahdi", "1234", "Min-Seo Young-Ho", true, 1)]
        public void TestUserRegister(string username, string password, string fullname, bool gender, 
                int familyCount)
        {
            DateTime birthdaty = DateTime.Today;
            Users user;
            try
            {
                user = Global.Register(username, fullname, password, birthdaty, familyCount, gender);
                using (Session3Entities entities = new Session3Entities())
                {
                    user = entities.Users.SingleOrDefault(t => t.ID == user.ID);
                    Assert.IsTrue(user != null, "Register user is not found.");
                    Assert.IsTrue(user.Username == username, "Register user Username value different.");
                    Assert.IsTrue(user.Password == password, "Register Password value different.");
                    Assert.IsTrue(user.FullName == fullname, "Register FullName value different.");
                    Assert.IsTrue(user.Gender == gender, "Register Gender value different.");
                    Assert.IsTrue(user.BirthDate == birthdaty, "Register BirthDate value different.");
                    Assert.IsTrue(user.FamilyCount == familyCount, "Register FamilyCount value different.");
                    entities.Users.Remove(entities.Users.SingleOrDefault(t => t.ID == user.ID));
                    entities.SaveChanges();
                }
            }
            catch (ArgumentException ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void TestItemScore()
        {
            try
            {
                Global.CheckScore();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void TestItemAvailableDate()
        {
            try
            {
                Global.CheckItemDate();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}