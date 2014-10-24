using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using testmvc.WebSecurityImpl;
using testmvc.Repository;
using testmvc.Controllers;
using System.Web.Mvc;
using testmvc.Models;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace UnitTesting
{
    [TestClass]
    public class HomeControllerTests
    {
        private Mock<IWebSecurityWrapper> webSecurityMock;
        private UsersRepositoryMock usersRepositoryMock;

        [TestInitialize]
        public void Initialize()
        {
            webSecurityMock = new Mock<IWebSecurityWrapper>();
            usersRepositoryMock = new UsersRepositoryMock();
        }

        [TestMethod]
        public void GetUsersFilteredShouldReturnNotMoreThanPagesizeItems()
        {
            int pageSize = 2;
            HomeController controller = new HomeController(usersRepositoryMock.Object, webSecurityMock.Object);

            PartialViewResult view = (PartialViewResult)controller.GetUsersFiltered("", "", 0, pageSize);
            UsersListViewModel resultModel = (UsersListViewModel)view.Model;

            Assert.IsTrue(resultModel.Users.Any());
            Assert.IsTrue(resultModel.Users.Count <= pageSize);
        }

        [TestMethod]
        public void GetUsersFilteredShouldFilterDataByNameOrEmail()
        {
            string filter = "abc";

            usersRepositoryMock.Data.Clear();
            usersRepositoryMock.Data.AddRange(new []{
                new UserModel { FirstName = "qabcq", LastName = "def", Email = "ghi@jkl.com", UserId = 42 },
                new UserModel { FirstName = "def", LastName = "qabcq", Email = "ghi@jkl.com", UserId = 43 },
                new UserModel { FirstName = "ghi", LastName = "def", Email = "cba@jkl.com", UserId = 44 }
            });

            HomeController controller = new HomeController(usersRepositoryMock.Object, webSecurityMock.Object);

            PartialViewResult view = (PartialViewResult)controller.GetUsersFiltered(filter, "", 0, 10);
            UsersListViewModel resultModel = (UsersListViewModel)view.Model;

            Assert.IsTrue(resultModel.Users.Any());
            
            foreach(UserModel u in resultModel.Users)
            {
                Assert.IsTrue(u.FirstName.Contains(filter)
                           || u.LastName.Contains(filter)
                           || u.Email.Contains(filter));
            }
        }

        [TestMethod]
        public void GetUsersFilteredShouldOrderData()
        {
            string orderBy = "FirstName_desc";
            int pageSize = usersRepositoryMock.Data.Count;

            HomeController controller = new HomeController(usersRepositoryMock.Object, webSecurityMock.Object);

            PartialViewResult view = (PartialViewResult)controller.GetUsersFiltered("", orderBy, 0, pageSize);
            UsersListViewModel resultModel = (UsersListViewModel)view.Model;

            Assert.IsTrue(resultModel.Users.Any());

            string orderByProp = orderBy.Replace("_desc", "");

            PropertyInfo p = typeof(UserModel).GetProperty(orderByProp);

            IList<UserModel> realOrdered = orderBy.EndsWith("_desc")
                ? usersRepositoryMock.Data.OrderByDescending(u => p.GetValue(u)).ToList()
                : usersRepositoryMock.Data.OrderBy(u => p.GetValue(u)).ToList();

            Assert.AreEqual(realOrdered.Count(), resultModel.Users.Count);

            for (int i = 0; i < resultModel.Users.Count; i++)
            {
                Assert.AreEqual(resultModel.Users[i], realOrdered[i]);
            }
        }
    }
}
