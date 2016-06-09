using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http.Results;
using System.Net;
using System.Collections.Generic;
using Armchair_rest_server.Models;
using Armchair_rest_server.Controllers;

namespace Armchair_rest_server.Tests
{
    [TestClass]
    public class TestFurnitureController
    {
        [TestMethod]
        public void GetFurniture_ShouldReturnAllFurniture()
        {
            var repo = new TestFurnitureRepository();
            for (int i = 0; i < 20; i++)
            {
                repo.Furniture.Add(new Furniture { Id = i + 1, Name = "Demo", Price = 0, Description = "", Type_ = 1 });
            }

            var controller = new FurnitureController(repo);

            var result = controller.GetAllFurniture() as List<Furniture>;

            Assert.IsNotNull(result);
            Assert.AreEqual(18, result.Count);
            Assert.AreEqual(1, result[0].Id); 

            result = controller.GetAllFurniture(1) as List<Furniture>;

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(19, result[0].Id);
        }
    }
}
