using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventSourcing.JsonPersistence;
using DomainModel.Users;
using System.Linq;

namespace ExperimentalTests
{
    [TestClass]
    public class JsonPersistenceForUsers
    {
        [TestMethod]
        public void AddAndPersistOneUser()
        {
            var file = new System.IO.FileInfo("user.repo");
            var repo = new UserRepository(file);

            var newUser = new User()
            {
                Guid = Guid.NewGuid(),
                Nick = "Bobber",
                Name = "Bob"
            };

            repo.Add(newUser);

            repo.Save();

            var repoAgain = new UserRepository(file);

            Assert.IsTrue(repoAgain.All.Any(u => u.Guid == newUser.Guid));

            file.Delete();
        }
    }
}
