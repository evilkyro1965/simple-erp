using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using simpleerp.model;

namespace simpleerp.model.test
{
    [TestClass]
    public class InventoryCategoryTest:BaseTest
    {
        private DaoContext dao = new DaoContext();

        [TestInitialize()]
        public void Initialize() {
            setupDB();
        }

        [TestMethod]
        public void TestAdd()
        {
            dao = new DaoContext();

            InventoryCategory inventoryCategory = new InventoryCategory();
            inventoryCategory.Name = "test";

            dao.InventoryCategories.Add(inventoryCategory);
            dao.SaveChanges();
        }

    }
}
