using System;
using System.Data.Entity;
using Armchair_rest_server.Models;
using System.Collections.Generic;

namespace Armchair_rest_server.Tests
{
    public class TestFurnitureRepository : IFurnitureRepository
    {
        public TestFurnitureRepository()
        {
            this.Furniture = new List<Furniture>();
        }

        public List<Furniture> Furniture { get; set; }

        public IEnumerable<Furniture> GetAll()
        {
            return Furniture;
        }

        public void Dispose() { }
    }
}
