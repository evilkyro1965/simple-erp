using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using simpleerp.model;

namespace simpleerp.model.test
{
    [TestClass]
    public class UnitTest1:BaseTest
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            setupDB();
            DaoContext dao = new DaoContext();

            InventoryCategory inventoryCategory = new InventoryCategory();
            inventoryCategory.Name = "test";

            dao.InventoryCategories.Add(inventoryCategory);
            dao.SaveChanges();
        }
    }
}
